using Inventario.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Datos
{
    public class MovInventarioDAL
    {
        public List<MovInventario> ListarInventario(DateTime? Fechainicio, DateTime? Fechafin, string TipoMovimiento, string NroDocumento)
        {
            List<MovInventario> lista = new List<MovInventario>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("sp_ConsultarMovInventario", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros que aceptan NULL
                    cmd.Parameters.AddWithValue("FechaInicio", (object)Fechainicio ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("FechaFin", (object)Fechafin ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("TipoMovimiento", string.IsNullOrEmpty(TipoMovimiento) ? DBNull.Value : (object)TipoMovimiento);
                    cmd.Parameters.AddWithValue("NroDocumento", string.IsNullOrEmpty(NroDocumento) ? DBNull.Value : (object)NroDocumento);




                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(
                                    new MovInventario()
                                    {                        

                                        COD_CIA = Convert.ToString(dr["COD_CIA"].ToString()),
                                        COMPANIA_VENTA_3 = Convert.ToString(dr["COMPANIA_VENTA_3"].ToString()),
                                        ALMACEN_VENTA = Convert.ToString(dr["ALMACEN_VENTA"].ToString()),
                                        TIPO_MOVIMIENTO = Convert.ToString(dr["TIPO_MOVIMIENTO"].ToString()),
                                        TIPO_DOCUMENTO = Convert.ToString(dr["TIPO_DOCUMENTO"].ToString()),
                                        NRO_DOCUMENTO = Convert.ToString(dr["NRO_DOCUMENTO"].ToString()),
                                        COD_ITEM_2 = Convert.ToString(dr["COD_ITEM_2"].ToString()),
                                        PROVEEDOR = Convert.ToString(dr["PROVEEDOR"].ToString()),
                                        ALMACEN_DESTINO = Convert.ToString(dr["ALMACEN_DESTINO"].ToString()),
                                        CANTIDAD = Convert.ToString(dr["CANTIDAD"].ToString()),
                                        DOC_REF_1 = Convert.ToString(dr["DOC_REF_1"].ToString()),
                                        DOC_REF_2 = Convert.ToString(dr["DOC_REF_2"].ToString()),
                                        DOC_REF_3 = Convert.ToString(dr["DOC_REF_3"].ToString()),
                                        DOC_REF_4 = Convert.ToString(dr["DOC_REF_4"].ToString()),
                                        DOC_REF_5 = Convert.ToString(dr["DOC_REF_5"].ToString()),
                                        FECHA_TRANSACCION = Convert.ToDateTime(dr["FECHA_TRANSACCION"].ToString())



                                    });
                            }
                        }
                       
                }
            }
            catch
            {
                lista = new List<MovInventario>();

            }
            return lista;
        }

        public int InsertarInventario(MovInventario obj)
        {
            int idautogenarado = 0;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertarMovInventario", oconexion);               

                    cmd.Parameters.AddWithValue("COD_CIA", obj.COD_CIA);
                    cmd.Parameters.AddWithValue("COMPANIA_VENTA_3", obj.COMPANIA_VENTA_3);
                    cmd.Parameters.AddWithValue("ALMACEN_VENTA", obj.ALMACEN_VENTA);
                    cmd.Parameters.AddWithValue("TIPO_MOVIMIENTO", obj.TIPO_MOVIMIENTO);
                    cmd.Parameters.AddWithValue("TIPO_DOCUMENTO", obj.TIPO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("NRO_DOCUMENTO", obj.NRO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("COD_ITEM_2", obj.COD_ITEM_2);
                    cmd.Parameters.AddWithValue("PROVEEDOR", obj.PROVEEDOR);
                    cmd.Parameters.AddWithValue("ALMACEN_DESTINO", obj.ALMACEN_DESTINO);
                    cmd.Parameters.AddWithValue("CANTIDAD", obj.CANTIDAD);
                    cmd.Parameters.AddWithValue("DOC_REF_1", obj.DOC_REF_1);
                    cmd.Parameters.AddWithValue("DOC_REF_2", obj.DOC_REF_2);
                    cmd.Parameters.AddWithValue("DOC_REF_3", obj.DOC_REF_3);
                    cmd.Parameters.AddWithValue("DOC_REF_4", obj.DOC_REF_4);
                    cmd.Parameters.AddWithValue("DOC_REF_5", obj.DOC_REF_5);



                 
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idautogenarado = 1;
                }
            }
            catch (Exception ex)
            {
                idautogenarado = 0;


            }
            return idautogenarado;
        }

        public int EditarInventario(MovInventario obj)
        {
            int idautogenarado = 0;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarMovInventario", oconexion);

                    cmd.Parameters.AddWithValue("COD_CIA", obj.COD_CIA);
                    cmd.Parameters.AddWithValue("COMPANIA_VENTA_3", obj.COMPANIA_VENTA_3);
                    cmd.Parameters.AddWithValue("ALMACEN_VENTA", obj.ALMACEN_VENTA);
                    cmd.Parameters.AddWithValue("TIPO_MOVIMIENTO", obj.TIPO_MOVIMIENTO);
                    cmd.Parameters.AddWithValue("TIPO_DOCUMENTO", obj.TIPO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("NRO_DOCUMENTO", obj.NRO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("COD_ITEM_2", obj.COD_ITEM_2);
                    cmd.Parameters.AddWithValue("PROVEEDOR", obj.PROVEEDOR);
                    cmd.Parameters.AddWithValue("ALMACEN_DESTINO", obj.ALMACEN_DESTINO);
                    cmd.Parameters.AddWithValue("CANTIDAD", obj.CANTIDAD);
                    cmd.Parameters.AddWithValue("DOC_REF_1", obj.DOC_REF_1);
                    cmd.Parameters.AddWithValue("DOC_REF_2", obj.DOC_REF_2);
                    cmd.Parameters.AddWithValue("DOC_REF_3", obj.DOC_REF_3);
                    cmd.Parameters.AddWithValue("DOC_REF_4", obj.DOC_REF_4);
                    cmd.Parameters.AddWithValue("DOC_REF_5", obj.DOC_REF_5);




                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idautogenarado = 1;
                }
            }
            catch (Exception ex)
            {
                idautogenarado = 0;


            }
            return idautogenarado;
        }

        public int EliminarInventario(MovInventario obj)
        {
            int idautogenarado = 0;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("SP_Eliminar_MovInventario", oconexion);

                    cmd.Parameters.AddWithValue("COD_CIA", obj.COD_CIA);
                    cmd.Parameters.AddWithValue("COMPANIA_VENTA_3", obj.COMPANIA_VENTA_3);
                    cmd.Parameters.AddWithValue("ALMACEN_VENTA", obj.ALMACEN_VENTA);
                    cmd.Parameters.AddWithValue("TIPO_MOVIMIENTO", obj.TIPO_MOVIMIENTO);
                    cmd.Parameters.AddWithValue("TIPO_DOCUMENTO", obj.TIPO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("NRO_DOCUMENTO", obj.NRO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("COD_ITEM_2", obj.COD_ITEM_2);
                    



                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idautogenarado = 1;
                }
            }
            catch (Exception ex)
            {
                idautogenarado = 0;


            }
            return idautogenarado;
        }
    }
}

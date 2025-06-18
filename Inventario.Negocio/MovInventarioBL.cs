using Inventario.Datos;
using Inventario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Negocio
{
    public class MovInventarioBL
    {
        private MovInventarioDAL objCapaDato = new MovInventarioDAL();
        public List<MovInventario> ListaInventario(string Fechainicio, string Fechafin, string TipoMovimiento, string NroDocumento)
        {
            DateTime? fechaInicio = null;
            DateTime? fechaFin = null;

            if (DateTime.TryParse(Fechainicio, out DateTime fi))
                fechaInicio = fi;

            if (DateTime.TryParse(Fechafin, out DateTime ff))
                fechaFin = ff;

            return objCapaDato.ListarInventario(fechaInicio, fechaFin, TipoMovimiento, NroDocumento);
        }
        public int InsertarInventario(MovInventario obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.COD_CIA) || string.IsNullOrWhiteSpace(obj.COD_CIA))
            {
                Mensaje = "El campo COD_CIA no puede ser Vacio";
            }
            



            if (string.IsNullOrEmpty(Mensaje))
            {
                return objCapaDato.InsertarInventario(obj);
            }

            else
            {
                return 0;
            }

        }

        public int EditarInventario(MovInventario obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.COD_ITEM_2) || string.IsNullOrWhiteSpace(obj.COD_ITEM_2))
            {
                Mensaje = "El campo COD_ITEM_2 no puede ser Vacio";
            }




            if (string.IsNullOrEmpty(Mensaje))
            {
                return objCapaDato.EditarInventario(obj);
            }

            else
            {
                return 0;
            }

        }
        public int EliminarInventario(MovInventario obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.COD_ITEM_2) || string.IsNullOrWhiteSpace(obj.COD_ITEM_2))
            {
                Mensaje = "El campo COD_ITEM_2 no puede ser Vacio";
            }




            if (string.IsNullOrEmpty(Mensaje))
            {
                return objCapaDato.EliminarInventario(obj);
            }

            else
            {
                return 0;
            }

        }
    }
}

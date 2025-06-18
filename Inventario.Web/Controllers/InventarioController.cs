using Inventario.Entidades;
using Inventario.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Web.Controllers
{
   
    public class InventarioController : Controller
    {
        // GET: Inventario
        
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult ListaInventario(string Fechainicio, string Fechafin, string TipoMovimiento, string NroDocumento)
        {
            List<MovInventario> oLista = new List<MovInventario>();
            oLista = new MovInventarioBL().ListaInventario(Fechainicio, Fechafin, TipoMovimiento, NroDocumento);
            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult InsertarInventario(MovInventario objeto)
        {
            
            
            object resultado;
            string mensaje = string.Empty;
            resultado = new MovInventarioBL().InsertarInventario(objeto, out mensaje);
            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult EditarInventario(MovInventario objeto)
        {


            object resultado;
            string mensaje = string.Empty;
            resultado = new MovInventarioBL().EditarInventario(objeto, out mensaje);
            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult EliminarInventario(MovInventario objeto)
        {


            object resultado;
            string mensaje = string.Empty;
            resultado = new MovInventarioBL().EliminarInventario(objeto, out mensaje);
            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }
    }
}
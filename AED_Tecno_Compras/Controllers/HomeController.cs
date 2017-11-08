using AED_Tecno_Compras.Base_de_Datos;
using AED_Tecno_Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AED_Tecno_Compras.Controllers
{
    public class HomeController : Controller
    {
        PruebaEntities dataContext = new PruebaEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View("IndexPrincipal");
        }

        public JsonResult ObtenerProductosHome()
        {
            var consulta = (from item in dataContext.Producto
                            where item.Descuento > 0 && item.Descuento<100
                            select item)
                            .ToList();

            List<VistaProducto> listaProducto = new List<VistaProducto>();
            foreach (var item in consulta)
            {

                listaProducto.Add(new VistaProducto
                {
                    IdProducto = item.IdProducto,
                    Nombre = item.Nombre,
                    Descripcion = item.Descripcion,
                    UrlFoto = item.UrlFoto,
                    PrecioUnitario = item.PrecioUnitario,
                    CantidadEnInventario = item.CantidadEnInventario,
                    Descuento = item.Descuento,
                    FechaInicioDescuento = item.FechaInicioDescuento,
                    FechaFinDescuento = item.FechaFinDescuento,
                    IdCategoria = item.IdCategoria,
                    ValorConDescuento = (item.Descuento!=null) ? item.PrecioUnitario-((item.PrecioUnitario*item.Descuento)/100) : item.PrecioUnitario
                });

            }

            return Json(new { listaProducto = listaProducto }, JsonRequestBehavior.AllowGet);

        }
    }
}
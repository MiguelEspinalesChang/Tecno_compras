using AED_Tecno_Compras.Base_de_Datos;
using AED_Tecno_Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AED_Tecno_Compras.Controllers
{
    public class ProductosController : Controller
    {
        PruebaEntities dataContext = new PruebaEntities();
        // GET: Productos
        public ActionResult Index()
        {
            return View("");
        }

        [HttpGet]
        public ActionResult detalleProducto(string token)
        {


            var consulta = (from item in dataContext.Producto
                            where item.IdProducto == Convert.ToInt32(token)
                            select item).FirstOrDefault();


            if (consulta == null)
            {
                ViewBag.producto = false;
            }
            else
            {
                VistaProducto productoTemp = new VistaProducto();


                productoTemp.IdProducto = consulta.IdProducto;
                productoTemp.Nombre = consulta.Nombre;
                productoTemp.Descripcion = consulta.Descripcion;
                productoTemp.UrlFoto = consulta.UrlFoto;
                productoTemp.PrecioUnitario = consulta.PrecioUnitario;
                productoTemp.CantidadEnInventario = consulta.CantidadEnInventario;
                productoTemp.Descuento = consulta.Descuento;
                productoTemp.FechaInicioDescuento = consulta.FechaInicioDescuento;
                productoTemp.FechaFinDescuento = consulta.FechaFinDescuento;
                productoTemp.IdCategoria = consulta.IdCategoria;
                productoTemp.ValorConDescuento = (consulta.Descuento != null) ? consulta.PrecioUnitario - ((consulta.PrecioUnitario * consulta.Descuento) / 100) : consulta.PrecioUnitario;


                ViewBag.producto = productoTemp;
            }


            return View("detalle");
        }

        public JsonResult ObtenerProducto()
        {
            var consulta = (from item in dataContext.Producto
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
                    ValorConDescuento = (item.Descuento != null) ? item.PrecioUnitario - ((item.PrecioUnitario * item.Descuento) / 100) : item.PrecioUnitario
                });

            }



            return Json(new { listaProducto = listaProducto }, JsonRequestBehavior.AllowGet);
        }

    }
}
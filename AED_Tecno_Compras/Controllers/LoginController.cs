using AED_Tecno_Compras.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AED_Tecno_Compras.Controllers
{
    public class LoginController : Controller
    {
        PruebaEntities dataContext = new PruebaEntities();
       

        // GET: Login
        public ActionResult Index()
        {

            return View();
        }

        public JsonResult ObtenerUsuario(string userName, string passw)
        {
          var consulta = (from usuario in dataContext.Cliente
                         where usuario.NombreUsuario == "Gintoki" &&  usuario.pass == "12345"
                         select usuario)
                          .ToList();

            return Json(consulta, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult Ingresar(string userName, string passw)
        {
            


           return RedirectToAction("Index", "Home");
        }

      
    }
}
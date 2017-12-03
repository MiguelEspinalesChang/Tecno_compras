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

        public JsonResult Ingresar(string userName, string passw)
        {
            if (string.IsNullOrEmpty(userName))
                userName = userName.ToLower();

            var consulta = (from usuario in dataContext.Cliente
                            where usuario.NombreUsuario.ToLower() == userName && usuario.pass == passw
                            select usuario).FirstOrDefault();

            if(consulta != null)
            {
                return Json(new { user = userName, passw = passw }, JsonRequestBehavior.AllowGet);
            }
            else
                return Json(new { error = true }, JsonRequestBehavior.AllowGet);

        }


      
    }
}
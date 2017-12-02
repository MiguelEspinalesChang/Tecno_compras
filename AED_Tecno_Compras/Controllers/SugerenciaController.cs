using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace AED_Tecno_Compras.Controllers
{
    public class SugerenciaController : Controller
    {
        // GET: Sugerencia
        public ActionResult Index(string envio)
        {
            if (!string.IsNullOrEmpty(envio))
                ViewBag.sugerenciaEnviada = true;

            return View("");
        }

        [HttpPost]
        public ActionResult EnviarComentario(string name, string email, string message)
        {

            DateTime horaActual = DateTime.Now;
            var body = "<p>Correo enviado por: " + name + "</p><p>Mensaje: " + message + "</p><p></p></br><p>Hora: " + horaActual.ToString() + "</p>";
            var mensaje = new MailMessage();

            mensaje.To.Add(new MailAddress("espinales.angel.miguel@gmail.com"));    // El correo al que esta dirigido la sugerencia, la persona que recibe 
            mensaje.To.Add(new MailAddress("sakata.chang@gmail.com"));

            mensaje.From = new MailAddress("tecnocompras.ni@gmail.com");  // El correo que envia, el supuesto BOT

            mensaje.Subject = "Sugerencia de un cliente"; // el nombre para el correo

            mensaje.Body = string.Format(body, name, email, message);
            mensaje.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "tecnocompras.ni@gmail.com",  // El correo que envia, el supuesto BOT
                    Password = "tecno1234"  // contraseña del correo que esta enviado
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = int.Parse("587");
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = credential;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //await smtp.SendMailAsync(mensaje);
                smtp.Send(mensaje);

                return RedirectToAction("Index", new { envio = "enviado" });
            }



        }


    }
}
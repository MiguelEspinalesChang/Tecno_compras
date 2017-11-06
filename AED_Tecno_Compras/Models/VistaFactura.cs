using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AED_Tecno_Compras.Models
{
    public class VistaFactura
    {
        public int IdFactura { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public int IdCliente { get; set; }


    }
}
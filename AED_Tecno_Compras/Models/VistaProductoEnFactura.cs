using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AED_Tecno_Compras.Models
{
    public class VistaProductoEnFactura
    {
        public int ProductoEnFactura { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int CantidadProducto { get; set; }

    }
}
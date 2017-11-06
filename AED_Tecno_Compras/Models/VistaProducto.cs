using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AED_Tecno_Compras.Models
{
    public class VistaProducto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UlrFoto { get; set; }
        public float PrecioUnitario { get; set; }
        public int CantidadEnInventario { get; set; }
        public float Descuento { get; set; }
        public DateTime FechaInicioDescuento { get; set; }
        public DateTime FechaFinDescuento { get; set; }
        public int IdCategoria { get; set; }
    }
}
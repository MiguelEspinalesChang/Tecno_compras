//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AED_Tecno_Compras.Base_de_Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public Factura()
        {
            this.ProductoEnFactura = new HashSet<ProductoEnFactura>();
        }
    
        public int IdFactura { get; set; }
        public float Total { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public int IdCliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<ProductoEnFactura> ProductoEnFactura { get; set; }
    }
}

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
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.Factura = new HashSet<Factura>();
        }
    
        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string Direccion { get; set; }
        public string ModoPago { get; set; }
        public float Saldo { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Bloqueado { get; set; }
        public string pass { get; set; }
    
        public virtual ICollection<Factura> Factura { get; set; }
    }
}

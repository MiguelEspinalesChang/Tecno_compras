using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AED_Tecno_Compras.Models
{
    public class VistaClientes
    {

        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string Direccion { get; set; }
        public string ModoPago { get; set; }
        public float Saldo { get; set; }
        public string Correo { get; set; }
        public string Clabe { get; set; }
        public Boolean Bloqueado { get; set; }
      
        
    }
}
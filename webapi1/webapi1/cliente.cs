//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapi1
{
    using System;
    using System.Collections.Generic;
    
    public partial class cliente
    {
        public cliente()
        {
            this.pedidos = new HashSet<pedido>();
        }
    
        public int idCliente { get; set; }
        public string empresa { get; set; }
        public string nombre { get; set; }
        public string apePaterno { get; set; }
        public string apeMaterno { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public string rfc { get; set; }
        public string fechaNacimiento { get; set; }
        public decimal telefono { get; set; }
        public string calle { get; set; }
        public decimal numero { get; set; }
        public int idEstado { get; set; }
        public int cp { get; set; }
        public int idColonia { get; set; }
        public string calle1 { get; set; }
        public string calle2 { get; set; }
        public string municipio { get; set; }
        public string estatus { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public double saldo { get; set; }
        public string observaciones { get; set; }
    
        public virtual colonia colonia { get; set; }
        public virtual ICollection<pedido> pedidos { get; set; }
    }
}
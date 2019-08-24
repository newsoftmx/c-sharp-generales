using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoListas
{
    class entidades
    {
        public int id { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    
    public class Contacto {
   /// <summary>
   /// 
   /// </summary>
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string domicilio;

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
    }
}

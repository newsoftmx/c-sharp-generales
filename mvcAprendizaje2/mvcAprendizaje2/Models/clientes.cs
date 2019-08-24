using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvcAprendizaje2.Models
{
    //hacemos una clase para la tabla de la bd que usaremos
    public class clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string aprePaterno { get; set; }
        public string apeMaterno { get; set; }
        public int edad { get; set; }
    }
    //creamos una clase para indicarle la conexion a los datos, heredara el DBContext
    public class clientesDBContext : DbContext
    {
        //creamos un DBSET y le pasamos la entidad que trabajara, en este caso es clientes
        //si marca error por favor agregue la librería syste.data.entity
        public DbSet<clientes> clientes { get; set; }
        //de aqui me voy al web config
    }
}
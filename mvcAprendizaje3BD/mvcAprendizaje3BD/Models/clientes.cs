using System;
using System.Collections.Generic;
//esta libreria es para la validación html
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace mvcAprendizaje3BD.Models
{
    public class clientes
    {
            //hacemos una clase para la tabla de la bd que usaremos
        public int id { get; set; }
        //cuando se agrega la validación debemos de agregar using System.ComponentModel.DataAnnotations;
        [Required]
        public string nombre { get; set; }
        [Required]
        public string aprePaterno { get; set; }
        [Required]
        public string apeMaterno { get; set; }
        [Required]
        //[StringLength(2)]
        public int edad { get; set; }
        //las validaciones nos dara una falla, xq modifique mi clase clientes, pero la tabla
        //sigue con el mismo esquema, se soluciona dando clic en herramientas, administrador de 
        //paquetes de biblioteca, consola de administrador de paquetes de biblioteca, nuget package
        //enable-migrations -ContextTypeName mvcAprendizaje3BD.Models.clientesDBContext
        //se creara la carpeta migrations, se analizan las carpetas
        //ahora necesito otra migration Add-Migration AgregarValidadores
        //despues en la consola hacemos un update-database

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
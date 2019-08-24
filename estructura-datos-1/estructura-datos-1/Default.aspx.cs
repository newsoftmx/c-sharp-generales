using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace estructura_datos_1
{
    public partial class _Default : Page
    {
        struct ejemplo
        {
            public string nombre;
            public string carrera;
            public int edad;
            
            public string mostrarMensaje()
            {
                string mensaje;
                mensaje="El alumno " + this.nombre + 
                    " de la carrera " + this.carrera + 
                    " tiene la edad de " + this.edad + " :D";
                return mensaje;
            }
        }
        //DECLARO LA INSTANCIA DE LA ESTRUCTURA, DE FORMA GLOBAL
        ejemplo nuevoEjemplo = new ejemplo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgegarDatos_Click(object sender, EventArgs e)
        {
            //lblEstado.Text="Hola Gaby";
            nuevoEjemplo.nombre = txtNombre.Text;
            nuevoEjemplo.carrera = txtCarrera.Text;
            nuevoEjemplo.edad = int.Parse(txtEdad.Text);
            //lblEstado.Text = "El alumno " + nuevoEjemplo.nombre + " de la carrera " + nuevoEjemplo.carrera + " tiene la edad de " + nuevoEjemplo.edad + " :D";

            //invoco funcion de mensaje
            lblEstado.Text = nuevoEjemplo.mostrarMensaje();
        }
    }
}
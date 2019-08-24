using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace datos_personales
{
    public partial class datos_personales : System.Web.UI.Page
    {
        #region "variables"
        string[] dulipan = new string[6];
        string[] becerra = new string[6];
        string[] chatito = new string[6];
        int o, edad;
        #endregion
        #region "metodos"
        //el metodo se declara primero definiendo su comportamiento
        //publico, privado o protegido, seguido del tipo de dato/valor a regresar
        //después el nombre del método y por último los parametros, que se escriben
        //entre los parentesis
        public void guardarDatos()
        {
            dulipan[0] = txtNombre.Text;
            dulipan[1] = txtApePaterno.Text;
            dulipan[2] = txtApeMaterno.Text;
            dulipan[3] = txtEdad.Text;
            dulipan[4] = txtGenero.Text;
            dulipan[5] = txtEstadoCivil.Text;
        }
        public bool guardarDatosInformador()
        {
            dulipan[0] = txtNombre.Text;
            dulipan[1] = txtApePaterno.Text;
            dulipan[2] = txtApeMaterno.Text;
            dulipan[3] = txtEdad.Text;
            dulipan[4] = txtGenero.Text;
            dulipan[5] = txtEstadoCivil.Text;
            bool resultado = true;
            return resultado;
        }
        public string[] mensaje(string nombre, string apePaterno, string apeMaterno,
            int edad, string Genero, string estadoCivil)
        {
            becerra[0] = nombre;
            becerra[1] = apePaterno;
            becerra[2] = apeMaterno;
            becerra[3] = Convert.ToString(edad);
            becerra[4] = Genero;
            becerra[5] = estadoCivil;
            return becerra;
        }
        public void leerDatos()
        {
            lblPrueba.Text = "";
            for (o = 0; o < dulipan.Length; o++)
            {
                lblPrueba.Text = lblPrueba.Text + "posición ["
                    + o + "] = " + dulipan[o];
            }
        }
        public int procesarEdad(int a)
        {
            int edadMaestro = 35, edadEdgar = 19;
            a = a + edadEdgar - edadMaestro;
            return a;
        }
        public bool leriche(string nombre, string apePaterno, string apeMaterno,
            int edad, string genero, string estadoCivil)
        {
            dulipan[0] = nombre;
            dulipan[1] = apePaterno;
            dulipan[2] = apeMaterno;
            dulipan[3] = Convert.ToString(edad);
            dulipan[4] = genero;
            dulipan[5] = estadoCivil;
            return true;
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            lblPrueba.Text = "";
            dulipan[0] = txtNombre.Text;
            dulipan[1] = txtApePaterno.Text;
            dulipan[2] = txtApeMaterno.Text;
            dulipan[3] = txtEdad.Text;
            dulipan[4] = txtGenero.Text;
            dulipan[5] = txtEstadoCivil.Text;
            /*pregunta del millon, 
             * ¿cómo imprimo todos los datos del
             * arreglo para saber que si guardo
             */
            //lblPrueba.Text = dulipan[4];
            for(o=0; o < dulipan.Length; o++)
            {
                if (o == 3)
                {
                    int edad = int.Parse(dulipan[o]);
                    if (edad < 35)
                    {
                        lblPrueba.Text = "Eres un chavo";
                    }
                    else
                    {
                        lblPrueba.Text = "Eres un Chavo Ruco, preocupate";
                    }
                }
                
                /*lblPrueba.Text = lblPrueba.Text 
                    + "El valor de la posición ["
                    + o + "] = " + dulipan[o] + "<br/>";
                    */
                
            }
            
        }

        protected void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            //mandar llamar mi metodo que guarda los datos en el arreglooooooo
            guardarDatos();
        }

        protected void btnLeerDatos_Click(object sender, EventArgs e)
        {
            guardarDatos();
            leerDatos();
        }

        protected void btnGuardarDatosInformador_Click(object sender, EventArgs e)
        {
            if (guardarDatosInformador())
            {
                lblInformador.Text = "Felicidades, guardaste bien los datos";
            }
        }

        protected void btnGuardarDatosConMetodo_Click(object sender, EventArgs e)
        {
            //mandar llamar un método que guarde los datos en el arreglo
            //pero enviando parametros
            leriche(txtNombre.Text, txtApePaterno.Text, txtApeMaterno.Text,
                int.Parse(txtEdad.Text), txtGenero.Text, txtEstadoCivil.Text);
            leerDatos();
        }

        protected void btnGuardarArregloMensaje_Click(object sender, EventArgs e)
        {
            chatito = mensaje(txtNombre.Text, txtApePaterno.Text, txtApeMaterno.Text,
                int.Parse(txtEdad.Text), txtGenero.Text, txtEstadoCivil.Text);
            lblMensaje.Text = "Estimado subscriptor " + chatito[0] + " "
                + chatito[1] + " " + chatito[2] + ", actualmente usted tiene una"
                + "promocion, porque su edad es de " + chatito[3] + " y su genero "
                + chatito[4] + ", ademas su estado civil es: " + chatito[5]
                + " por lo cual, ha sido ganador de un RICO CAFE AMERICANO ";
        }

        protected void btnComapararEdad_Click(object sender, EventArgs e)
        {
            edad = int.Parse(txtEdad.Text);
            lblInformador.Text = Convert.ToString(procesarEdad(edad));
        }
    }
}
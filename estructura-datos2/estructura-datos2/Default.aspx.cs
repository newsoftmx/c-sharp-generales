using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace estructura_datos2
{
    public partial class Default : System.Web.UI.Page
    {
        //declaro mis variables globales

        metodos nuevosMetodos = new metodos();
        tda nuevoTDA = new tda();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSuma_Click(object sender, EventArgs e)
        {
            nuevoTDA.crearVector2D(int.Parse(txtNumero1.Text),
                int.Parse(txtNumero2.Text));
            lblResultadoSuma.Text = Convert.ToString(nuevoTDA.traerPX());
            //lblResultadoSuma.Text = Convert.ToString(nuevosMetodos.sumaEntero(int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text)));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //1. ir a la instancia de la tda
            //2. mandar el valor del puntox
            //3. leer el valor px y mostrarlo en lblPX
            nuevoTDA.leerPX(int.Parse(txtNumero1.Text));
            lblPX.Text = Convert.ToString(nuevoTDA.traerPX());
        }

        protected void btnVector3D_Click(object sender, EventArgs e)
        {
            nuevoTDA.crearVector3D(int.Parse(txtNumero1.Text),
                int.Parse(txtNumero2.Text), 
                int.Parse(txtNumero3.Text));
            lblPX.Text = Convert.ToString(nuevoTDA.traerPX());
            lblPY.Text = Convert.ToString(nuevoTDA.traerPY());
            lblPZ.Text = Convert.ToString(nuevoTDA.traerPz());
            //crear boton PY PZ y Vector 2D
            //crear vector3D en 0
        }
        /*TAREA 1
* REALIZAR LOS METODOS NECESARIOS PARA OBTENER LAS OPERACIONES
* DE SUMA, RESTA, MULTIPLICACION Y DIVISION, DE 2 NUMEROS 
* CON DECIMALES Y MOSTRAR SU RESULTADO EN EL WEB FORM
* LLAMADO DEFAULT.ASPX
* ADEMAS CREAR UN WEB FORM QUE REALICE EL CALCULO DEL AREA
* DE UN TRIANGULO EQUILATERO, CIRCULO Y CUADRADO Y MOSTRAR 
* LOS RESULTADOS EN EL WEB FORM RECIEN AGREGADO*/
    }
}
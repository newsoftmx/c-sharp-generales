using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace estruc_datos_dinamico
{
    public partial class tda_dinamico : System.Web.UI.Page
    {
    //recuerden comentar código, ME PUEDO ESPERAR LO QUE DESEEN
        ArrayList datoDinamico = new ArrayList();
        int cicloFor = 0, tamañoArreglo, posicion=1;
        #region "metodos"
        public void llenar()
        {
            tamañoArreglo = int.Parse(txtTamaño.Text);
            for (cicloFor = 0; cicloFor < tamañoArreglo; cicloFor++)
            {
                datoDinamico.Add(cicloFor + 3);
            }
            datoDinamico.Add(2);
        }
        public void mostrar()
        {
            lblDatoDinamico.Text = "";
            foreach (int cicloEach in datoDinamico)
            {
                lblDatoDinamico.Text = lblDatoDinamico.Text
                    + " posición [" + posicion + "] = "
                    + cicloEach + ", ";
                posicion++;
            }
            lblTamañoDinamico.Text = Convert.ToString(datoDinamico.Count);
        }
        #endregion


        protected void Button1_Click(object sender, EventArgs e)
        {
            llenar();
            datoDinamico.Remove(int.Parse(txtEliminar.Text));
            mostrar();
            lblTamañoDinamico.Text = Convert.ToString(datoDinamico.Count);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            llenar();
            datoDinamico.Clear();
            mostrar();
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            llenar();
            datoDinamico.Sort();
            mostrar();
        }

        protected void btnReverse_Click(object sender, EventArgs e)
        {
            llenar();
            datoDinamico.Reverse();
            mostrar();
        }

        protected void btnContains_Click(object sender, EventArgs e)
        {
            llenar();
            lblTamañoDinamico.Text= Convert.ToString( datoDinamico.Contains(int.Parse(txtEliminar.Text)));
            if (datoDinamico.Contains(int.Parse(txtEliminar.Text)))
            {
                lblTamañoDinamico.Text = "Bien Gaby";
            }
            else
            {
                lblTamañoDinamico.Text = "Nel";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnProbarDinamico_Click(object sender, EventArgs e)
        {
            
            llenar();
             //añade otro valor al arreglo dinámico, aumentando
            //su tamaño, de lo indicado en la caja mas un 
            //un valor mas
            mostrar();
        }
    }
}
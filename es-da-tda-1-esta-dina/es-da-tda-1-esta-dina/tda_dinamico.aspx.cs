using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//agrego para trabajar listas
using System.Collections;

namespace es_da_tda_1_esta_dina
{
    public partial class tda_dinamico : System.Web.UI.Page
    {
        ArrayList datoDinamico = new ArrayList();
        int cicloFor = 0, tamañoArreglo, posicion=1, valor;
        Random rnd = new Random();
        #region "metodos"
        public void llenar()
        {
            valor = rnd.Next(0, 100);
            tamañoArreglo = int.Parse(txtValorDinamico.Text);
            for (int i = 0; i < tamañoArreglo; i++)
            {
                datoDinamico.Add(i + "hola");
            }
        }
        public void mostrar()
        {
            lblDatoDinamico.Text = "";
            foreach (string cicloForr in datoDinamico)
            {
                lblDatoDinamico.Text = lblDatoDinamico.Text + "posicion {" + posicion + "}, " + cicloForr;
                posicion++;
            }
        }
        #endregion

        protected void btnCount_Click(object sender, EventArgs e)
        {
            lblDatoDinamico.Text = "";
            llenar();
            mostrar();
            lblTamaño.Text = Convert.ToString(datoDinamico.Count);
            lblCount.Text = Convert.ToString(datoDinamico.Count);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            lblDatoDinamico.Text = "";
            llenar();
            mostrar();
            datoDinamico.Clear();
            mostrar();
            lblClear.Text = Convert.ToString(datoDinamico.Count);
        }

        protected void btnGaby_Click(object sender, EventArgs e)
        {
            lblDatoDinamico.Text = btnGaby.Text;
            datoDinamico.Add(btnGaby.Text);
            mostrar();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            lblDatoDinamico.Text = "";
            llenar();
            mostrar();
            lblTamaño.Text = Convert.ToString(datoDinamico.Count);
            datoDinamico.Remove(int.Parse(txtContiene.Text));
            mostrar();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProbarDinamico_Click(object sender, EventArgs e)
        {
            lblDatoDinamico.Text = "";
            llenar();
            mostrar();
            lblTamaño.Text = Convert.ToString(datoDinamico.Count);
        }
    }
}
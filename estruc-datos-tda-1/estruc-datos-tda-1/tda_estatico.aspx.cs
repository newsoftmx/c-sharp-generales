using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace estruc_datos_tda_1
{
    public partial class tda_estatico : System.Web.UI.Page
    {
        #region "variables"
        estatico estatico1 = new estatico();
        int[] arregloRecibido = new int[5];
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLlenarArreglo_Click(object sender, EventArgs e)
        {
            estatico1.llenarArreglo();
        }

        protected void btnImprimirArreglo_Click(object sender, EventArgs e)
        {
            estatico1.llenarArreglo();
            arregloRecibido = estatico1.imprimirArreglo();
            lblImpresionArreglo.Text = "";
            for(int i=0; i < arregloRecibido.Length; i++)
            {
                lblImpresionArreglo.Text=lblImpresionArreglo.Text
                    + Convert.ToString(arregloRecibido[i] + ", ");
                txtP0.Text = Convert.ToString(arregloRecibido[i]);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace es_da_tda_1_esta_dina
{
    public partial class tda_estatico : System.Web.UI.Page
    {
        
        estatico nuevoEstatico = new estatico();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLlenarArreglo_Click(object sender, EventArgs e)
        {
            int a;
            //a=txtEsta
            nuevoEstatico.llenarArreglo();

        }

        protected void btnVaciarArreglo_Click(object sender, EventArgs e)
        {
            int[] arregloRecibido = new int[5];
            nuevoEstatico.llenarArreglo();
            arregloRecibido = nuevoEstatico.imprimirArreglo();
            for(int i=0; i < arregloRecibido.Length; i++)
            {
                lblValorArreglo.Text = Convert.ToString(arregloRecibido[i]) + " , ";
            }
            //lblValorArreglo.Text = Convert.ToString(arregloRecibido[1]);
        }
    }
}
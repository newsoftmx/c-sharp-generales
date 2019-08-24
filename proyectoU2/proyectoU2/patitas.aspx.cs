using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace proyectoU2
{
    public partial class patitas : System.Web.UI.Page
    {
        #region "variables"
        procesos ph = new procesos();
        string mascotaAdoptada="";
        double[] precios = new double[5];
        int posicionPrecio;
        #endregion
        #region "metodos"
        public void agregarAListaAdopcion(string mascotaAdoptada)
        {
            /*verifico que la variable mascotaAdoptada venga con
             * valores, es decir que tenga un valor*/
            if (mascotaAdoptada != "")
            {
                precios = ph.leerPreciosMascotas();
                if (mascotaAdoptada== "Maltes ($200)")
                {
                    posicionPrecio = 0;
                    lblMascotaAdoptada.Text = lblMascotaAdoptada.Text + "Maltes";
                    lblPrecioAdoptado.Text= lblPrecioAdoptado.Text + Convert.ToString( precios[posicionPrecio]) + "<br/>";
                    //invocar metodo guardar en arreglo
                    ph.guardarTipoMascota("Maltes");
                    guardarPrecioMascota();
                    //invocar metodo leer el arreglo 
                    //imprimir el valor de un arreglo

                }
                if (mascotaAdoptada == "Mestizos  ($250)")
                {
                    posicionPrecio = 1;
                    lblMascotaAdoptada.Text = lblMascotaAdoptada.Text + "Mestizos";
                    lblPrecioAdoptado.Text = lblPrecioAdoptado.Text + Convert.ToString(precios[posicionPrecio]) + "<br/>";
                }
                if (mascotaAdoptada == "Pastor Ingles ($300)")
                {
                    posicionPrecio = 2;
                    lblMascotaAdoptada.Text = lblMascotaAdoptada.Text + "Pastor Inglés";
                    lblPrecioAdoptado.Text = lblPrecioAdoptado.Text + Convert.ToString(precios[posicionPrecio]) + "<br/>";
                }
                if (mascotaAdoptada == "Chihuahua ($350)")
                {
                    posicionPrecio = 3;
                    lblMascotaAdoptada.Text = lblMascotaAdoptada.Text + "Chihuahua";
                    lblPrecioAdoptado.Text = lblPrecioAdoptado.Text + Convert.ToString(precios[posicionPrecio]) + "<br/>";
                }
                if (mascotaAdoptada == "Pitbull ($400)")
                {
                    posicionPrecio = 4;
                    lblMascotaAdoptada.Text = lblMascotaAdoptada.Text + "Pitbull";
                    lblPrecioAdoptado.Text = lblPrecioAdoptado.Text + Convert.ToString(precios[posicionPrecio]) + "<br/>";
                }
            }
            else
            {
                lblEstatusOperacion.Text = "Cuidado, se presento una falla";
                //lblEstatusOperacion.BackColor= rojo;
            }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMaltes_Click(object sender, EventArgs e)
        {
            agregarAListaAdopcion(mascotaAdoptada=btnMaltes.Text);
        }

        protected void btnMestizos_Click(object sender, EventArgs e)
        {
            agregarAListaAdopcion(mascotaAdoptada = btnMestizos.Text);
        }

        protected void btnPastorIngles_Click(object sender, EventArgs e)
        {
            agregarAListaAdopcion(mascotaAdoptada = btnPastorIngles.Text);
        }

        protected void btnChihuahua_Click(object sender, EventArgs e)
        {
            agregarAListaAdopcion(mascotaAdoptada = btnChihuahua.Text);
        }

        protected void btnPitBull_Click(object sender, EventArgs e)
        {
            agregarAListaAdopcion(mascotaAdoptada = btnPitBull.Text);
        }
    }
}
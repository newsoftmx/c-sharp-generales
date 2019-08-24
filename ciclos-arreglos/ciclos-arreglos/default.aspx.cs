using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ciclos_arreglos
{
    public partial class _default : System.Web.UI.Page
    {//zona para variables globales
        #region "variablesGlobales"
        int ciclo, limite, opcion, vuelta=1;
        string opcionString;
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWhile_Click(object sender, EventArgs e)
        {
            limite = int.Parse(txtWhile.Text);
            while (ciclo < limite)
            {
                txtWhile.Text = Convert.ToString(ciclo);
                lblWhile.Text = "El ciclo llego al valor: " +
                    Convert.ToString(ciclo) + " Vueltas realizadas = " +
                    vuelta;
                ciclo++;
                vuelta++;
            }
        }

        protected void btnSwitch_Click(object sender, EventArgs e)
        {
            opcionString = txtSwitch.Text;
            switch (opcionString)
            {
                case "Andres":
                    {
                        lblSwitch.Text = "Escribio un 1";
                        lblSwitch.Text += " <br><b><h1> Riete jajaja";
                        break;//the end
                    }
                case "América Campeón":
                    {
                        lblSwitch.Text = "Escribio un 2";
                        break;
                    }
                default:
                    {
                        lblSwitch.Text = "O tu no puedes asegurar tu vida";
                        break;
                    }
            }
        }

        protected void btnCicloFor_Click(object sender, EventArgs e)
        {
            //bajar a la varible limite mi valro del textbox
            limite = int.Parse(txtCicloFor.Text);
            for (ciclo = 0; ciclo < limite; ciclo++)
            {
                txtCicloFor.Text = Convert.ToString(ciclo);
                lblCicloFor.Text = "El ciclo llego al valor: " +
                    Convert.ToString(ciclo) + "Vueltas realizadas = " +
                    Convert.ToString(vuelta);
                vuelta++;
            }
        }
    }
}
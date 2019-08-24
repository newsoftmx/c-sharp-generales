using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Programa_3_Examen
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnVerificadorGanancia_Click(object sender, EventArgs e)
        {
            double Sueldo, Porcentaje, Ganancia, Ganancia0;
            string Nombre;
            Nombre =txtNombre.Text;
            Sueldo = double.Parse(txtSueldo.Text);
            Porcentaje = double.Parse(txtPorcentaje.Text);
            Ganancia = (Porcentaje / 100) * Sueldo;
            Ganancia0 = (Porcentaje / 100) * Sueldo;
            lblGanancia.Text = Convert.ToString(Ganancia);
            lblGanancia.Text = Convert.ToString(Ganancia0);
            Nombre =txtNombre0.Text;
            
            if (Sueldo <= 0)
            {
                lblObservaSueldo.Text = " Error";
            }
            if(Sueldo>=0)
            {
                lblObservaSueldo.Text = "Correcto";
            }
            if (Porcentaje<=0)
            {
                lblObservaPorcentaje.Text = "Error";
            }
            if (Porcentaje >= 5 && Porcentaje <= 10)
            {
                lblObservaPorcentaje.Text = "Perfecto";
            }
            if (Porcentaje>=11 && Porcentaje<=20)
            {
                lblObservaPorcentaje.Text = "Excelente";
            }



        }
    }
}
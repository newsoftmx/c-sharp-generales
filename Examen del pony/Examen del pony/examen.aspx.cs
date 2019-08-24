using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_del_pony
{
    public partial class examen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        
      #region "VARIABLES GLOBALES"
            int i ;
       #endregion
        }

        
        public string tablaAmortizacion()
        {
            string Nombre, ApellidoPaterno, ApellidoMaterno;
            Nombre = txtNombre.Text ;
            ApellidoPaterno = txtApellidoMaaterno.Text;
            ApellidoMaterno = txtApellidoMaaterno.Text;
        

            string tabla = "<table><tr><th>Plazo</th><th>Inicio</th><th>Interes</th>" +
                "<th>Amortizacion</th><th>pago</th><th>final feliz</h></tr>";
            double plazo = double.Parse(txtPlazo.Text) * 12;
            double interes = double.Parse(txtInteres.Text);
            interes = interes / 100;
            double inicio = double.Parse(txtMonto.Text);
            double amor, end, cuota;
            double iC = inicio * interes;
            cuota = (inicio * interes) / (1 - Math.Pow((1 + interes), -plazo));
            amor = cuota - iC;
            end = inicio - amor;
            for (int i = 1; i <= plazo; i++)
            {
                iC = inicio * interes;
               
                amor = cuota - iC;
                end = inicio - amor;
                tabla += "<tr><td>" + i + "</td><td>" + inicio.ToString("N2") + "</td><td>" + iC.ToString("N2") + "</td><td>" + amor.ToString("N2") + "</td><td>" + cuota.ToString("N2") + "</td><td>" + end.ToString("N2") + "</td></tr>";
                inicio = end;
            }

            {
                tabla += "</table>";
                return tabla;
            }
                


            }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            lblTablaAmortizacion.Text = tablaAmortizacion();
        }

        
        

        
    }
    }


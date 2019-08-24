using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2p
{
    public partial class _2parcial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre, apellidop, apellidom;
            nombre = Convert.ToString(txtnombre);
            apellidop = Convert.ToString(txtapellidopa);
            apellidom = Convert.ToString(txtapellidoma);

            float monto, plazo, interes;
            monto = int.Parse(txtmontosolicitado.Text);
            plazo = int.Parse(txtplazo.Text);
            interes = int.Parse(txtinteres.Text);




        }
    }
}
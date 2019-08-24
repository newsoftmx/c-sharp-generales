using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//libreria para arraylist
using System.Collections;

namespace estructura_datos_2
{
    public partial class tda_dinamico : System.Web.UI.Page
    {
        ArrayList datoDinamico = new ArrayList();
        int cicloFor=0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProbarDinamico_Click(object sender, EventArgs e)
        {
            datoDinamico.Add(int.Parse(txtValorDinamico.Text));
            for (int i = 0; i < datoDinamico.Count; i++)
            {
                this.datoDinamico[i] = i + 3;
            }
            for (cicloFor=0; cicloFor<=datoDinamico.Count; cicloFor++)
            {
                lblDatoDinamico.Text = datoDinamico[cicloFor];
            }
        }
    }
}
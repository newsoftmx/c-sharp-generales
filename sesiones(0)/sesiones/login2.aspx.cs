using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sesiones
{
    public partial class login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["usuarioBD"]==null)
            {
                Response.AddHeader("REFRESH", "0;URL=login.aspx");

            }
            else
            {
                Response.Redirect("servicios.aspx");
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class bienvenido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Usuario;
            if (ViewState["txtUsuario"] != null)
            {
                Usuario = (int)ViewState["txtUsuario"];
                txtUsuario.Text = Convert.ToString(Usuario);
                Response.Write("Su número de cliente es " + Request.Form["txtUsuario"].ToString());
            }
            else
            {
                Response.Write("Erro validacion ");
            }
        }
    }
}
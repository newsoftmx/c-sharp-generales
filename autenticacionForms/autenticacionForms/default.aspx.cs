using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace autenticacionForms
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lkbCerrarSesion_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.RedirectToLoginPage();
        }

        protected void lkbProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("productos.aspx");
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
        }
      
    }
}
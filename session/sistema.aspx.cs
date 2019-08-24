using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    #region "vaiables"
    string claveHash;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        if (txtUsuario.Text != "")
        {
            claveHash = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtUsuario.Text, "SHA1");
            Session["Usuario"] = txtUsuario.Text;
            Session["Usuario2"] = claveHash;
            Response.Redirect("principal.aspx");

        }
        else
        {
            Response.Write("Favor de capturar un nombre de usuario");
        }
    }
}
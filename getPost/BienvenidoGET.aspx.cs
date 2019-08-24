using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BienvenidoGET : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        lblUsuario.Text = Request.QueryString["txtUsuario"].ToString();
        lblPassword.Text = Request.QueryString["txtPassword"].ToString();
        Response.Write("Su nombre es: " + Request.QueryString["txtUsuario"].ToString() + "<br>");
        Response.Write("Su password es: " + Request.QueryString["txtPassword"].ToString() + "<br>");
        
    }
    protected void btnPasarGET_Click(object sender, EventArgs e)
    {
        string usuarioVariable;
        usuarioVariable = Request.QueryString["txtUsuario"].ToString();
        Response.Redirect("pruebaGET.aspx"+usuarioVariable);
    }
}
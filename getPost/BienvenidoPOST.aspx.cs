using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bienvenido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblUsuario.Text = Request.Form["txtUsuarioPost"].ToString();
        lblPassword.Text = Request.Form["txtPasswordPost"].ToString();
        Response.Write("Su nombre es: " + Request.Form["txtUsuarioPost"].ToString() +"<br>");
        Response.Write("Su password es: " + Request.Form["txtPasswordPost"].ToString() + "<br>");
    }
}
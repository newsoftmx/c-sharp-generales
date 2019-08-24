using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class variablesGET : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Su nombre es: " + Request.QueryString["txtUsuario"].ToString() + "<br>");
        Response.Write("Su password es: " + Request.QueryString["txtPassword"].ToString() + "<br>");
    }
}
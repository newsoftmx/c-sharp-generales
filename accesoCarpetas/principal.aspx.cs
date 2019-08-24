using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class principal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region "variables"
        string usuario = Convert.ToString(Session["Usuario"]);
        #endregion


        /*
        if (Session["Usuario"]==null && Session["Usuario2"]==null )
        {
            lblSession.Text = "Sin variable de session, Será redireccionado";
            Response.AddHeader("REFRESH", "3;URL=Default.aspx");
        }
        else
        {
            lblSession.Text=Convert.ToString(Session["Usuario"]);
            
        }
        */
    }
    protected void btnEliminarSession_Click(object sender, EventArgs e)
    {
        //Session.Remove("Usuario");
        //Session.Clear();
        Session.Abandon();
        //Session.RemoveAll();
        Response.AddHeader("REFRESH", "0;URL=principal.aspx");
    }
    protected void Signout_Click(object sender, EventArgs e)
    {

    }
    protected void lbnSalir_Click(object sender, EventArgs e)
    {

    }
}
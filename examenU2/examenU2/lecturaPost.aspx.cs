using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examenU2
{
    public partial class lecturaPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario, password;
            //usuario = Request.Form["txtUsuario"].ToString();
            //password = Request.Form["txtPassword"].ToString();
            //lblUsuario.Text = usuario;
            //lblPassword.Text = password;
            //lblUsuario.Text = CType(Page.PreviousPage.Master.FindControl("Conten tPlaceHolder1").FindControl("txtTexto"), TextBox).Text.ToString();

            Response.Write(Request.Form["txtUsuario"].ToString());
            Response.Write(Request.Form["txtPassword"].ToString());
        }
    }
}
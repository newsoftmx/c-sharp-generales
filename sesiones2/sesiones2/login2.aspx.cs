using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sesiones2
{
    public partial class login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioBD"] == null)
            {
                Response.AddHeader("REFRESH", "0;URL=Login.aspx");
            }
            else
            {
                txtUsuario.Text = Session["usuarioBD"].ToString();
                ///Aqui va toda la logica que consulta en el servidor MySQL
                ///si el usuario que viene con la variable de session, exsite
                ///en mi BD, si es asi lo redirecciona a servicios, si no,
                ///lo regresa a default.aspx
                Response.Redirect("servicios.aspx");
            }
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
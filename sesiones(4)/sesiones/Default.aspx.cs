using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sesiones
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///esto no se usa
            /// if(Session["usuarioBD"]!="")
            ///{ }
            ///
            if(Session["usuarioBD"]==null)
            {
                lblErrorSesion.Visible = true;
                lblSession.Text = "Sin variable de session, Será redireccionado";
                Response.AddHeader("REFRESH", "3;URL=login.aspx");
            }
            else
            {
                ///Despues de haber impreso las variables con this.session
                ///ahora solo imprimimos las variables
                ///
                string usuario = Convert.ToString(Session["Usuario"]);
                lblSession.Text = usuario;
                ///ahora leo la variable de bd
                string usuarioBD = Convert.ToString(Session["usuarioBD"]);
                lblSesionBD.Text = Convert.ToString(Session["usuarioBD"]);
                //lblSesionBD.Text = usuarioBD;
            }
            
        }

        protected void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            //elimina la variable indicada, por lo cual permaneceaun dentro de la pagina
            //Session.Remove("Usuario");
            //elimina todas las variables y si recargas te saca del sistema
            //Session.RemoveAll();
            //elimina la sesion, pero no borra los cookies, por lo cual no es seguro
            //Session.Clear();
            //Dispara el evento de 
            //Session.Abandon();
            //Response.AddHeader("REFRESH", "0;URL=Default.aspx");
            //dispara el evento session_end con la cual 
            
            //Response.AddHeader("REFRESH", "1;URL=login.aspx");

            //Session.Clear();
            //Session.Abandon();
            //Response.AddHeader("REFRESH", "3;URL=principal.aspx");
        }

        protected void btnOtraWEB_Click(object sender, EventArgs e)
        {
            Response.Redirect("login2.aspx");
        }
    }
}
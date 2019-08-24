using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//agregar esta librería
using System.Web.Security;

namespace carpetas
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //http://www.programandoamedianoche.com/2009/10/autenticacion-por-formularios-en-asp-net/
            string usuario, password;
            usuario = txtUsuario.Text;
            password = txtPassword.Text;
            if (FormsAuthentication.Authenticate
                (usuario, password))
            {
                //con la siguiente instruccion le indicamos que se vaya a la pagina establecida como default
                FormsAuthentication.RedirectFromLoginPage
                    (usuario, true);
                //FormsAuthentication.RedirectFromLoginPage
                    //(usuario, chkAutenticacion.Checked);
                //Response.Redirect("");
            }
            else
            {
                lblProceso.Text = "Datos incorrectos, por favor escribe un correo y password validos";
            }
        }
    }
}
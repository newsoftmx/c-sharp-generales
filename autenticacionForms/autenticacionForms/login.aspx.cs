using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace autenticacionForms
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, password;
            try
            {
                usuario = txtUsuario.Text;
                password = txtPassword.Text;

                //verificamos que el usuario exista, esto se hace en base a la autenticacion
                //dada por formularios, donde se compara el usuario y el password, mismos
                //deben de coincidir con unas credenciales de usuario que se definen en la
                //configuración de la aplicacion, osea en el web.config
                if(System.Web.Security.FormsAuthentication
                    .Authenticate(usuario,password))
                {
                    //ahora lo mando a la pagina web  configurada por defaultpor default
                    //para esto se le manda los parametros de usuario o dato cualquiera 
                    //y un estado de true o false, o el checked de este caso, esto para 
                    //darle persistencia, que se gace mediante un archivo cookie y le 
                    //permite validarse, es un archivo de texto que se guarda en los 
                    //temporales con los datos del usuario
                    System.Web.Security.FormsAuthentication.RedirectFromLoginPage(usuario, chkRecordarDatos.Checked);
                    //con esto autorizamos que la cookie se guarde en el equipo permitiendo
                    //el acceso a el sitio web
                    System.Web.Security.FormsAuthentication.SetAuthCookie(usuario, true);
                    //Response.Redirect("default.aspx");
                }
                else
                {
                    lblMensajeError.Text = "Usuario o password incorrecto, solicite acceso en depto. de sistemas";
                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
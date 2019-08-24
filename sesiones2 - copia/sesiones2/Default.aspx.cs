using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sesiones2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///ahora verificamos que exista una variable de session
            ///si no existe, entonces deberá de redireccionarlo
            ///a la pagina de login.aspx
            ///
            if(Session["usuario"]==null)
            {
                //si no existe la variable de session
                Response.AddHeader("Refresh", "3;URL=login.aspx");
                ///esto por si alguien quiere loguearse desde otro lugar
            }
            else
            {
                if (Session["usuarioBD"] == null)
                {
                    ///aqui puedes indicar que realice un registro el la bd
                    ///como intento de acceso inseguro, anormal eo algo por estilo
                    ///despues de hacer un registro redireccion
                    ///
                    Response.AddHeader("REFRESH", "0;URL=Login.aspx");
                }
                else
                {
                    //hago uso de la variable
                    string usuario = Convert.ToString(Session["usuario"]);
                    lblUsuario.Text = usuario;
                    //tomo lectura de la otra variable de session usuarioBD
                    string usuarioBD = Convert.ToString(Session["usuarioBD"]);
                    lblUsuarioBD.Text = usuarioBD;
                }
                
            }









        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            ///elimino la variable indicada
            ///Session.Remove("usuarioBD");
            ///ahora remuevo todas las variables
            ///Session.RemoveAll();
            ///para salir correctamente y eliminar las sesiones
            ///uso la limpieza de las variables y el abandonamiento de las mismas
            ///el session.clear limpia el arreglo de variables de sesion
            Session.Clear();
            ///session.abandon. dispará el evento de session_end, borrando todos los
            ///datos de la session
            Session.Abandon();
            Response.AddHeader("REFRESH", "0;URL=login.aspx");
        }
    }
}
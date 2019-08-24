using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class verificarSiPost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(Request.Form["txtUsuario"]==null)
        {
            Response.Write("Hola, la variable no existe");

        }
        
    }
}
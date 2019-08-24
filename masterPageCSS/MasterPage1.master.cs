using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lkbCambiarPagina_Click(object sender, EventArgs e)
    {
        Session["masterpage"] = "MasterPage2.master";
        Response.Redirect(Request.Url.ToString());
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masterPageCSSClase
{
    public partial class MasterPage2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lkbCambioMasterPage_Click(object sender, EventArgs e)
        {
            Session["masterpage"] = "MasterPage1.master";
            Response.Redirect(Request.Url.ToString());
        }
    }
}
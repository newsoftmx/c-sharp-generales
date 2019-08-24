using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masterPageCSSClase
{
    public partial class _default : System.Web.UI.Page
    {
        void Page_PreInit(Object sender, EventArgs e)
        {
            if (Session["masterpage"] != null)
            {
                this.MasterPageFile = (String)Session["masterpage"];
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
    }
}
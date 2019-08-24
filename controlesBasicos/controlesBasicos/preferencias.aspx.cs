using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;

namespace controlesBasicos
{
    public partial class preferencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             //Calendar calendario= (Calendar).Page.PreviousPage.FindControl("calFechaViaje");
               //    Response.Write(Request.Form[calendario.SelectedDate.ToLongDateString()].ToString());
        }
    }
}
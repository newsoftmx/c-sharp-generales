using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet empleados = new DataSet();
        empleados.ReadXml(Server.MapPath("datosEmpleados.xml"));
        GridView1.DataSource = empleados.Tables[0].DefaultView;
        GridView1.DataBind();
    }
}
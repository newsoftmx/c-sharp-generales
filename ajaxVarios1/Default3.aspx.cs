using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    SqlConnection conexion = new SqlConnection("Data Source=vibecohack; Initial Catalog=ppw2; User ID=sa; Password=allispossible;");

    protected void btnConexion_Click(object sender, EventArgs e)
    {
        try
        {
            conexion.Open();
            conexion.Close();
            btnConexion.Text = "Conexion Establecida Mitcnik";
        }
        catch (Exception ex)
        {
            conexion.Close();
            btnConexion.Text = Convert.ToString(ex);
        }
        conexion.Open();

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Services;
public partial class Default4 : System.Web.UI.Page
{
     SqlConnection conexion = new SqlConnection("Data Source=vibecohack; Initial Catalog=ppw2; User ID=sa; Password=allispossible;");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnContinuar_Click(object sender, EventArgs e)
    {
        lblMensaje.Text = "Agradecemos su preferencia, ....";
    }
    protected void btnConfirmar2_Click(object sender, EventArgs e)
    {
        lblMensaje.Text = "Gracias ...";
    }
    private void btnConexion_Click(object sender, EventArgs e)
    {
        try
        {
            conexion.Open();
            conexion.Close();
            btnConexion.Text = "Dios, te escucha, te ha dado los poderes de Kevin Mitcnik";
        }
        catch (Exception ex)
        {
            conexion.Close();
            btnConexion.Text = Convert.ToString(ex);
        }
    }
}
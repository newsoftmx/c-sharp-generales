using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//agrego las siguiente librerias
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Services;
//permite trabajr script de ajax con servicios web
using System.Web.Script.Services;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    [ScriptMethod]
    public static List<string> traerDatos(string prefixText)
    {
        List<string> listaObtenida = new List<string>();
        try
        {
            SqlConnection conexion = new SqlConnection("Data Source=vibecohack; Initial Catalog=ppw2; User ID=sa; Password=allispossible;");
            conexion.Open();
            SqlCommand buscar = new SqlCommand("SELECT TOP (10) nombre FROM usuarios WHERE nombre LIKE + @nombre + '%'", conexion);
            buscar.Parameters.AddWithValue("@nombre", prefixText);
            SqlDataAdapter datos = new SqlDataAdapter(buscar);

            IDataReader lectura = buscar.ExecuteReader();
            while(lectura.Read())
            {
                listaObtenida.Add(lectura.GetString(0));
            }
            lectura.Close();
            return listaObtenida;
        }
        catch (Exception ex)
        {
            Console.Write(ex);
            return null;
        }

    }
}
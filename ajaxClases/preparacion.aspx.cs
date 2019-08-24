using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
//para trabajar los web service
using System.Web.Services;
//para trabajar scripts de ajax con web service
using System.Web.Script.Services;

public partial class preparacion : System.Web.UI.Page
{
    WSVCSP.servicioVCSoapClient consumirSP = new WSVCSP.servicioVCSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    [ScriptMethod]
    public static  List<string> traerDatos(string prefixText)
    {
        List<string> listaObtenida = new List<string>();
        SqlConnection conexion = new SqlConnection
 ("Data Source=vibecohack; Initial Catalog=programacionpw; User ID=sa; Password=victornash1982;");
        try
        {           
            conexion.Open();
            SqlCommand buscar = new SqlCommand
  ("SELECT TOP (10) nombre FROM deportista WHERE nombre LIKE + @nombre + '%'", conexion);
            buscar.Parameters.AddWithValue("@nombre", prefixText);
            SqlDataAdapter datos = new SqlDataAdapter(buscar);
            IDataReader lectura = buscar.ExecuteReader();
            while (lectura.Read())
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

    //con SP
    [WebMethod]
    [ScriptMethod]
    public static List<string> traerDatosSP(string prefixText)
    {
        List<string> listaObtenida = new List<string>();
        SqlConnection conexion = new SqlConnection("Data Source=vibecohack; Initial Catalog=programacionpw; User ID=sa; Password=victornash1982;");
        try
        {
            conexion.Open();
            SqlCommand buscar = new SqlCommand("deportistaNombres10", conexion);
            buscar.CommandType = CommandType.StoredProcedure;
            buscar.Parameters.AddWithValue("@nombre", prefixText);
            SqlDataAdapter datos = new SqlDataAdapter(buscar);

            IDataReader lectura = buscar.ExecuteReader();

            while (lectura.Read())
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
    public  List<string> traerDatosWS(string nombre)
    {
        string nombre2;
        List<string> datos= new List<string>();
        //datos=consumirSP.deportistaNombres10(nombre);
        return datos;
    }

    protected void txtBusquedaSP_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtBusquedaWS_TextChanged(object sender, EventArgs e)
    {

    }
}
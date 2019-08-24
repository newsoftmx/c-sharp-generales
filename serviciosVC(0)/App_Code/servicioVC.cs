using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de servicioVC
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class servicioVC : System.Web.Services.WebService
{
    #region "Variables";
    SqlConnection conexion = new SqlConnection("Data Source=vibecohack; Initial Catalog=programacionpw; User ID=sa; Password=victornash1982;");
    #endregion
    public servicioVC () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }
    [WebMethod]
    public bool deportistaGuardarSP(string nombre, string apePaterno, string apeMaterno, int edad, Boolean estatus, string nivel )
    {
        SqlCommand insertar = new SqlCommand("deportistaGuardar", conexion);
        insertar.CommandType=CommandType.StoredProcedure;
        insertar.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
        insertar.Parameters.Add("@apePaterno", SqlDbType.NVarChar).Value = apePaterno;
        insertar.Parameters.Add("@apeMaterno", SqlDbType.NVarChar).Value = apeMaterno;
        insertar.Parameters.Add("@edad", SqlDbType.Int).Value = edad;
        insertar.Parameters.Add("@estatus", SqlDbType.Bit).Value = estatus;
        insertar.Parameters.Add("@nivel", SqlDbType.NVarChar).Value = nivel;
        try 
	    {	        
		    conexion.Open();
            insertar.ExecuteNonQuery();
            conexion.Close();
            return true;
	    }
	    catch (Exception)
	    {
		    conexion.Close();
            return false;
	    }
    }
    [WebMethod]
    public bool deportistaActualizarSP(int id, string nombre, string apePaterno, string apeMaterno, int edad, Boolean estatus, string nivel)
    {
        SqlCommand insertar = new SqlCommand("deportistaActualizar", conexion);
        insertar.CommandType = CommandType.StoredProcedure;
        insertar.Parameters.Add("@id", SqlDbType.Int).Value = id;
        insertar.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
        insertar.Parameters.Add("@apePaterno", SqlDbType.NVarChar).Value = apePaterno;
        insertar.Parameters.Add("@apeMaterno", SqlDbType.NVarChar).Value = apeMaterno;
        insertar.Parameters.Add("@edad", SqlDbType.Int).Value = edad;
        insertar.Parameters.Add("@estatus", SqlDbType.Bit).Value = estatus;
        insertar.Parameters.Add("@nivel", SqlDbType.NVarChar).Value = nivel;
        try
        {
            conexion.Open();
            insertar.ExecuteNonQuery();
            conexion.Close();
            return true;
        }
        catch (Exception)
        {
            conexion.Close();
            return false;
        }
    }
    [WebMethod]
    public bool deportistaEliminarSP (int id)
    {
        SqlCommand eliminar = new SqlCommand("deportistaEliminar", conexion);
        eliminar.CommandType=CommandType.StoredProcedure;
        try
        {
            eliminar.Parameters.Add("@id", SqlDbType.Int).Value=id;
            conexion.Open();
            eliminar.ExecuteNonQuery();
            conexion.Close();
            return true;
        }
        catch (Exception)
        {
            conexion.Close();
            return false;
        }
    }
    [WebMethod]
    public DataSet deprtistaBuscarTodosSP()
    {
        SqlCommand buscar = new SqlCommand("deportistaBuscar",conexion);
        buscar.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter datos = new SqlDataAdapter();
        datos.SelectCommand = buscar;
        DataSet conjunto = new DataSet();
        try 
	    {
	        conexion.Open();
            datos.Fill(conjunto,"DatosGenerales");
            conexion.Close();
            return conjunto;
	    }
	    catch (Exception)
	    {
		    conexion.Close();
            return conjunto;
	    }
    }
    [WebMethod]
    public DataSet deportistaBuscarIDSP( int id)
    {
        SqlCommand buscarID = new SqlCommand("deportistaBuscarID", conexion);
        buscarID.CommandType= CommandType.StoredProcedure;
        SqlDataAdapter datos = new SqlDataAdapter();
        DataSet conjunto = new DataSet();
        try 
	    {	        
            buscarID.Parameters.Add("@ID", SqlDbType.Int).Value=id;
            conexion.Open();
            datos.SelectCommand = buscarID;
            datos.Fill(conjunto);
            conexion.Close();
    		return conjunto;
	    }
	    catch (Exception)
	    {
            conexion.Close();
		    return conjunto;
	    }
    }
}

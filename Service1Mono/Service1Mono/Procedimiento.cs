using System;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Web.Services;
using System.Data;
namespace Service1Mono
{
	public class Procedimiento
	{
		public Procedimiento ()
		{
			
		}
		MySqlConnection Conexion = new MySqlConnection("server=localhost; database=Alemania; User Id=root;");
		MySqlConnection CFE = new MySqlConnection("server=localhost; database=cfe; User Id=root;");
		MySqlConnection SAPAL = new MySqlConnection("server=localhost; database=sapal; User Id=root;");
		MySqlConnection TELMEX = new MySqlConnection("server=localhost; database=telmex; User Id=root;");
		
		[WebMethod]
    	public bool Insertar(string Nombre, string Paterno, string Materno, int Edad) 
		{
			MySqlCommand Insertar = new MySqlCommand("CALL Guardado('" + Nombre + "','" + Paterno + "','" + Materno + "', '" + Edad.ToString() + "')",Conexion);
			try {
				Conexion.Open();
				Insertar.ExecuteNonQuery();
				Conexion.Close();
				return true;
			}
			catch(Exception ex){
				Conexion.Close();
				return false;
			}
    	}
				[WebMethod]
    	public bool guardarCFE(int Nocontrato, string Referencia, double Cantidad, string Fecha) 
		{
			MySqlCommand InsertarCFE = new MySqlCommand("CALL guardado('" + Nocontrato + "','" + Referencia + "','" + Cantidad + "', '" + Fecha + "')",CFE);
			try {
				CFE.Open();
				InsertarCFE.ExecuteNonQuery();
				CFE.Close();
				return true;
			}
			catch(Exception ex){
				CFE.Close();
				return false;
			}
    	}
			[WebMethod]
    	public bool guardarSAPAL(int Nocontrato, string Referencia, double Cantidad, string Fecha) 
		{
			MySqlCommand InsertarSAPAL = new MySqlCommand("CALL guardado('" + Nocontrato + "','" + Referencia + "','" + Cantidad + "', '" + Fecha + "')",SAPAL);
			try {
				SAPAL.Open();
				InsertarSAPAL.ExecuteNonQuery();
					SAPAL.Close();
				return true;
			}
			catch(Exception ex){
				SAPAL.Close();
				return false;
			}
    	}
			[WebMethod]
    	public bool guardarTELMEX(int Nocontrato, string Referencia, double Cantidad, string Fecha) 
		{
			MySqlCommand InsertarTELMEX = new MySqlCommand("CALL guardado('" + Nocontrato + "','" + Referencia + "','" + Cantidad + "', '" + Fecha + "')",TELMEX);
			try {
				TELMEX.Open();
				InsertarTELMEX.ExecuteNonQuery();
				TELMEX.Close();
				return true;
			}
			catch(Exception ex){
				TELMEX.Close();
				return false;
			}
    	}
		
		[WebMethod]
    	public DataSet Buscar(int ID)
		{
			DataSet Conjunto=new DataSet();
			MySqlDataAdapter Buscar = new MySqlDataAdapter("CALL BUSQUEDA('" + ID + "')", Conexion);
			try
			{
				Conexion.Open();
				Buscar.Fill(Conjunto, "Datos");
				Conexion.Close();
				return Conjunto;
			}
			catch
			{
				Conexion.Close();
				return Conjunto;
			}
		}
		[WebMethod]
    	public DataSet Buscarcfe(int ID)
		{
			DataSet Conjunto=new DataSet();
			MySqlDataAdapter Buscar = new MySqlDataAdapter("CALL busqueda('" + ID + "')", CFE);
			try
			{
				CFE.Open();
				Buscar.Fill(Conjunto, "Datos");
				CFE.Close();
				return Conjunto;
			}
			catch
			{
				CFE.Close();
				return Conjunto;
			}
		}
		[WebMethod]
    	public DataSet Buscartelmex(int ID)
		{
			DataSet Conjunto=new DataSet();
			MySqlDataAdapter Buscar = new MySqlDataAdapter("CALL busqueda('" + ID + "')", TELMEX);
			try
			{
				TELMEX.Open();
				Buscar.Fill(Conjunto, "Datos");
				TELMEX.Close();
				return Conjunto;
			}
			catch
			{
				TELMEX.Close();
				return Conjunto;
			}
		}
		[WebMethod]
    	public DataSet Buscarsapal(int ID)
		{
			DataSet Conjunto=new DataSet();
			MySqlDataAdapter Buscar = new MySqlDataAdapter("CALL busqueda('" + ID + "')", SAPAL);
			try
			{
				SAPAL.Open();
				Buscar.Fill(Conjunto, "Datos");
				SAPAL.Close();
				return Conjunto;
			}
			catch
			{
				SAPAL.Close();
				return Conjunto;
			}
		}
	}
}


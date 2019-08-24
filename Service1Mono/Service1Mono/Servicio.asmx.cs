
using System;
using System.Web;
using System.Web.Services;
using System.Data;

namespace Service1Mono
{


	public class Servicio : System.Web.Services.WebService
	{
		
		[WebMethod]
    	public bool Insertar(string Nombre, string Paterno, string Materno, int Edad) 
		{
				Procedimiento clase = new Procedimiento();
				if(clase.Insertar(Nombre,Paterno,Materno,Edad)==true)
					return true;
				else
					return false;
		}
		
	[WebMethod]
    	public bool guardarCFE(int Nocontrato, string Referencia, double Cantidad, string Fecha) 
		{
				Procedimiento clase = new Procedimiento();
				if(clase.guardarCFE(Nocontrato,Referencia,Cantidad,Fecha)==true)
					return true;
				else
					return false;
		}	
		[WebMethod]
    	public bool guardarSAPAL(int Nocontrato, string Referencia, double Cantidad, string Fecha) 
		{
				Procedimiento clase = new Procedimiento();
				if(clase.guardarSAPAL(Nocontrato,Referencia,Cantidad,Fecha)==true)
					return true;
				else
					return false;
		}	
		[WebMethod]
    	public bool guardarTELMEX(int Nocontrato, string Referencia, double Cantidad, string Fecha) 
		{
				Procedimiento clase = new Procedimiento();
				if(clase.guardarTELMEX(Nocontrato,Referencia,Cantidad,Fecha)==true)
					return true;
				else
					return false;
		}	
		[WebMethod]
    	public DataSet Buscar(int Id)
		{
			DataSet Conjunto = new DataSet();
			Procedimiento Clase = new Procedimiento();
			Conjunto=Clase.Buscar(Id);
			return Conjunto;
		}
		[WebMethod]
    	public DataSet Buscarcfe(int Id)
		{
			DataSet Conjunto = new DataSet();
			Procedimiento Clase = new Procedimiento();
			Conjunto=Clase.Buscarcfe(Id);
			return Conjunto;
		}
		[WebMethod]
    	public DataSet Buscarsapal(int Id)
		{
			DataSet Conjunto = new DataSet();
			Procedimiento Clase = new Procedimiento();
			Conjunto=Clase.Buscarsapal(Id);
			return Conjunto;
		}
		[WebMethod]
    	public DataSet Buscartelmex(int Id)
		{
			DataSet Conjunto = new DataSet();
			Procedimiento Clase = new Procedimiento();
			Conjunto=Clase.Buscartelmex(Id);
			return Conjunto;
		}
	}
}


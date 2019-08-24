using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace wcf1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        #region "variables";
        SqlConnection cnn = new SqlConnection("Data Source=vibecohack; Initial Catalog=programacionpw; User ID=sa; Password=allispossible;");
        #endregion;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        /// <summary>
        /// CREAMOS LA FUNCIONALIDAD,  BOOLEANA PARA QUE ME REGRESE UN TRUE Y SABER
        /// SI SE GUARGO O NO, LOS PARAMETROS SON DEL NOMBRE DE LA TABLA, del entity ES LO QUE 
        /// RECIBIRA Y SE LLAMARÁ IGUAL O PUEDE SER DIFERENTE
        /// </summary>
        /// <param name="deportista"></param>
        /// <returns></returns>
        public bool guardarDeportista(deportista deportista)
        {
            ///AHORA HACEMOS USO DEL FRAMEWORK, que se llama con el nombre
            ///de la base de datos y la palabra entities
            ///
            try
            {
                programacionpwEntities db = new programacionpwEntities();
                //ahora invoco el proceso de agregar
                db.deportistas.Add(deportista);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }//terminada la funcionalidad, ahora la declaramos en la interface
        public DataSet seleccionarDeportistas()
        {
            //SqlDataAdapter da = new SqlDataAdapter("select * from deportistas",cnn);
            SqlDataAdapter da = new SqlDataAdapter("spBusDep", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public DataSet deportistaID( int id)
        {
            SqlCommand buscarid = new SqlCommand("spBusDepID", cnn);
            buscarid.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            buscarid.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            
            try
            {
                cnn.Open();
                da.SelectCommand = buscarid;
                da.Fill(ds);
                cnn.Close();
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        /*public DataSet seleccionarDeportistas(deportista deportistas)
        {
            try
            {
                programacionpwEntities db = new programacionpwEntities();
                db.deportistas.Select(deportistas);
                db.s
            }
            catch (Exception e)
            {
                return null;
            }
        }*/

        //esta clase es de tipo compuesta no la usamos, es la de prueba
        /*
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/
        ///para agregar una clase debemos de agregar los metadatos necesarios
        ///en este caso el datacontract, para esto nos vamos a la clase de la tabla
        ///localizada en el modelo
        ///
        

    }
}

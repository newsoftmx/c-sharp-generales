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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);





        /// <summary>
        /// como declare una funcionalidad, ahora declaro su interface, que es del
        /// mismo tipo de dato, y recibe la misma tabla que le llamare igual al 
        /// tipo de datos capturados o arreglo de datos
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        bool guardarDeportista(deportista deportista);
        //ahora creo mi data set que regresa todos los datos de la tabla
        [OperationContract]
        DataSet seleccionarDeportistas();
        [OperationContract]
        DataSet deportistaID(int id);


        ///COMO VAMOS A TENER UNA INTERFAZ, EN ESTA DEBERAN ESTAR DECLARADOS TODOS LOS
        ///FUNCIONES Y / O OBJETOS

       /* [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        */
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    /// <summary>
    /// ESTA ES LA CLASE DE PRUEBA, ES UNA CLASE COMPUESTA, NOS SIRVE SOLO DE PRUEBA, POR LO CUAL LA BORRAMOS
    /// </summary>
    /*[DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }*/
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Examen1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        string sumaResta(int columna1, int fila1, int columna2, int fila2);

        [OperationContract]
        string esCuadrada(int columna, int fila);

        [OperationContract]
        string obtenerDiagonal();

        [OperationContract]
        string esNulo();

        [OperationContract]
        string esFila();

        [OperationContract]
        string esColumna();

        [OperationContract]
        string transpuesta();

        [OperationContract]
        string Multi();

        [OperationContract]
        string simetrica();

        [OperationContract]
        string esDiagonal();

        [OperationContract]
        string esTriangularInferior();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
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
    }
}

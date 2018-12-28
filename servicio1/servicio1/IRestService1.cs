using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace servicio1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRestService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRestService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            //RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/{id}")]
        Persona JSONData(String id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            //RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "conexion/")]
        conexion ConexionData();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace servicio1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RestService1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RestService1.svc o RestService1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RestService1 : IRestService1
    {

        public Persona JSONData(String id)
        {
            conexion C2 = new conexion();
            return new Persona
            {
                nombre = "Antonio",
                edad = 25,
                CI = id,
            };
        }

        public conexion ConexionData()
        {
            conexion C1 = new conexion();
            return new conexion
            {
                mensaE = C1.mensaE
            };
        }

        public List<Persona> listarP(String id)
        {
            conexion C2 = new conexion();
            List<Persona> LP2 = C2.comandosMySql(id);
            return LP2;
        }

        public void POST(string zipCode, string price)
        {
            Console.WriteLine(price);
        }

    }
}

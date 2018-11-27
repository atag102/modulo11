using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APR2.Clases;
using APR2.Objetos;

namespace APR2.Controllers
{
    public class UsuariosController : ApiController
    {
        public List<persona> Get()
        {
            List<persona> listP=new List<persona>();
            int i= 0;
            conexion C = new conexion();
            List<Usuarios> listU = conexion.mostrar();
            ValicacionModel jsonObject = new ValicacionModel();
            while (i < 2)
            {
                jsonObject.P = new persona()
                {
                    nombre = listU[i].Nombre,
                    edad = listU[i].Edad,
                    Email = listU[i].Email,
                    mensaE = C.mensaE
                };
                listP.Insert(i, jsonObject.P);
                i++;
            }
            return listP;
        }
    }
}

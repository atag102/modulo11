using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace servicio1
{
    public class conexion
    {
        public String mensaE
        {
            get; set;
        }
        static MySqlConnection cn=new MySqlConnection() ;

        public conexion()
        {
            try
            {
                cn = new MySqlConnection("server=localhost; Uid=root; Password=C8720413; Database=usuarios; port=3306");//Permite realizar la conexion con la base de datos
                cn.Open();//Abrir la conexion
                this.mensaE = "Se conecto";
            }
            catch (Exception ex)
            {
                this.mensaE = "No se conecto";
            }
        }
    }
}
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
        int i = 0;
        List<Persona> LP = new List<Persona>();
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

        public List<Persona> comandosMySql(String ID)
        {
            MySqlCommand MC = new MySqlCommand(String.Format("SELECT * FROM usuarios.personas where idPersonas='{0}'",ID));
            MC.Connection = cn;
            MySqlDataReader MR = MC.ExecuteReader();
            if (MR.HasRows)
            {
                while (MR.Read())
                {
                    LP.Insert(i, 
                        new Persona{
                        nombre = MR.GetString(1),
                        edad = MR.GetInt32(2),
                        CI = MR.GetString(3)}
                        );
                    i++;
                }
            }
            return LP;
        }
    }
}
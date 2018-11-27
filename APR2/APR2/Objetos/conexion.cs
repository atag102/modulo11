using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace APR2.Objetos
{
    public class conexion
    {
        public String mensaE;
        static SqlConnection cn;
        public conexion()
        {
            try
            {
                cn = new SqlConnection("Server=tcp:serv789123.database.windows.net,1433;Initial Catalog=B2;Persist Security Info=False;User ID=atag102;Password=zxc123ASD;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");//Permite realizar la conexion con la base de datos
                cn.Open();//Abrir la conexion
                this.mensaE = "Se conecto";
            }
            catch (Exception ex)
            {
                this.mensaE = "No se conecto";
            }
        }

        public static List<Usuarios> mostrar()
        {
            int n = 0;
            List<Usuarios> listaU = new List<Usuarios>();
            SqlCommand cmd = new SqlCommand(String.Format("select * from Usuarios"), conexion.cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuarios U = new Usuarios();
                U.Id = dr.GetInt32(0);
                U.Nombre = dr.GetString(1);
                U.Edad = dr.GetString(2);
                U.Email = dr.GetString(3);
                listaU.Insert(n, U);
                n++;
            }
            return listaU;

        }
    }
}
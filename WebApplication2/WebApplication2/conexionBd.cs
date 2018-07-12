using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WebApplication2
{
    public class conexionBd
    {
        public void Conexion()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = "DataBase = Score; = localhost; user id = root; password = root";
            conn.Open();
            var adaptador = new MySqlDataAdapter("Select * From Puntaje", conn);
            DataSet data = new DataSet();
            adaptador.Fill(data);
            conn.Close();

        }
    }
}

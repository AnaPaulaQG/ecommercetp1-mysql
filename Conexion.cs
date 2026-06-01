using MySql.Data.MySqlClient;
using System.Configuration;

namespace ecommercetp1
{
    public class ConexionDB
    {
        public static MySqlConnection ObtenerConexion()
        {
            string server = ConfigurationManager.AppSettings["DbServer"];
            string port = ConfigurationManager.AppSettings["DbPort"];
            string database = ConfigurationManager.AppSettings["DbName"];
            string user = ConfigurationManager.AppSettings["DbUser"];
            string password = ConfigurationManager.AppSettings["DbPassword"];

            string cadena = $"Server={server};Port={port};Database={database};Uid={user};Pwd={password};Convert Zero Datetime=True";

            return new MySqlConnection(cadena);
        }
    }
}

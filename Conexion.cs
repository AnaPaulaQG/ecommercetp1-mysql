using MySql.Data.MySqlClient;

namespace ecommercetp1
{
    public class ConexionDB
    {
        private static string cadena = "Server=localhost;Database=ecommercetp1;Uid=root;Pwd=;";
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}

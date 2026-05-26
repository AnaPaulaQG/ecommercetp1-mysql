using MySql.Data.MySqlClient;

namespace ecommercetp1
{
    public class ConexionDB
    {
        private static string cadena = "Server=localhost;Database=ecommercetp1;Uid=root;Pwd=;Convert Zero Datetime=True";
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ecommercetp1
{
    public partial class FormResumen : Form
    {
        public FormResumen()
        {
            InitializeComponent();
            CalcularYMostrarResumen();
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {
            // Espacio libre
        }

        private void CalcularYMostrarResumen()
        {
            string query = @"
                SELECT 
                    (SELECT COUNT(*) FROM tiendas) AS Total_Comercios,
                    (SELECT COUNT(*) FROM ventas) AS Total_Ventas,
                    (SELECT COUNT(*) FROM ventas WHERE Estado_de_Pago = 'Aceptado') AS Ventas_Aprobadas,
                    IFNULL((SELECT SUM(Monto) FROM ventas WHERE Estado_de_Pago = 'Aceptado'), 0) AS Ingresos_Totales";

            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();

                    var adapter = new MySqlDataAdapter(query, conn);
                    var tabla = new DataTable();
                    adapter.Fill(tabla);
                    DGV_Resumen.DataSource = tabla;

                    if (tabla.Rows.Count > 0)
                    {
                        DataRow fila = tabla.Rows[0];
                        txt_TC.Text = fila["Total_Comercios"].ToString();
                        txt_TV.Text = fila["Total_Ventas"].ToString();
                        txt_VA.Text = fila["Ventas_Aprobadas"].ToString();
                        txt_IT.Text = fila["Ingresos_Totales"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el resumen: " + ex.Message);
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            CalcularYMostrarResumen();
            MessageBox.Show("¡Métricas y estadísticas actualizadas con éxito!");
        }

        private void DGV_Resumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vacío
        }
    }
}

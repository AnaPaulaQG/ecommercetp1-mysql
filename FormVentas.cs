using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ecommercetp1
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
            CargarVentasDesdeDB();
        }

        private void CargarVentasDesdeDB()
        {
            string query = "SELECT * FROM ventas";
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                var adapter = new MySqlDataAdapter(query, conn);
                var tabla = new DataTable();
                adapter.Fill(tabla);
                DGV_Ventas.DataSource = tabla;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO ventas (ID_Venta, ID_Tienda, Cliente, Producto, Monto, Medio_de_Pago, Estado_de_Pago, Fecha) 
                                 VALUES (@idVenta, @idTienda, @cliente, @producto, @monto, @mdp, @edp, @fecha)";

                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idVenta", int.Parse(txt_Venta.Text));
                        cmd.Parameters.AddWithValue("@idTienda", int.Parse(txt_Tienda.Text));
                        cmd.Parameters.AddWithValue("@cliente", txt_Cliente.Text);
                        cmd.Parameters.AddWithValue("@producto", txt_Producto.Text);
                        cmd.Parameters.AddWithValue("@monto", decimal.Parse(txt_Monto.Text));
                        cmd.Parameters.AddWithValue("@mdp", txt_MDP.Text);
                        cmd.Parameters.AddWithValue("@edp", txt_EDP.Text);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(txt_Fecha.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venta guardada con éxito.");
                CargarVentasDesdeDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (DGV_Ventas.CurrentRow == null) return;

            int id = int.Parse(DGV_Ventas.CurrentRow.Cells["ID_Venta"].Value.ToString());

            DialogResult respuesta = MessageBox.Show("¿Borrar venta?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                string query = "DELETE FROM ventas WHERE ID_Venta = @id";
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                CargarVentasDesdeDB();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"UPDATE ventas SET ID_Tienda = @idTienda, Cliente = @cliente, 
                                 Producto = @producto, Monto = @monto, Medio_de_Pago = @mdp, 
                                 Estado_de_Pago = @edp, Fecha = @fecha 
                                 WHERE ID_Venta = @idVenta";

                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idVenta", int.Parse(txt_Venta.Text));
                        cmd.Parameters.AddWithValue("@idTienda", int.Parse(txt_Tienda.Text));
                        cmd.Parameters.AddWithValue("@cliente", txt_Cliente.Text);
                        cmd.Parameters.AddWithValue("@producto", txt_Producto.Text);
                        cmd.Parameters.AddWithValue("@monto", decimal.Parse(txt_Monto.Text));
                        cmd.Parameters.AddWithValue("@mdp", txt_MDP.Text);
                        cmd.Parameters.AddWithValue("@edp", txt_EDP.Text);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(txt_Fecha.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venta modificada con éxito.");
                CargarVentasDesdeDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Ventas.CurrentRow != null && e.RowIndex >= 0)
            {
                txt_Venta.Text = DGV_Ventas.Rows[e.RowIndex].Cells["ID_Venta"].Value.ToString();
                txt_Tienda.Text = DGV_Ventas.Rows[e.RowIndex].Cells["ID_Tienda"].Value.ToString();
                txt_Cliente.Text = DGV_Ventas.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                txt_Producto.Text = DGV_Ventas.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                txt_Monto.Text = DGV_Ventas.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
                txt_MDP.Text = DGV_Ventas.Rows[e.RowIndex].Cells["Medio_de_Pago"].Value.ToString();
                txt_EDP.Text = DGV_Ventas.Rows[e.RowIndex].Cells["Estado_de_Pago"].Value.ToString();
                txt_Fecha.Text = DGV_Ventas.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ventas WHERE ID_Venta = @idVenta";
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idVenta", int.Parse(txt_Venta.Text));
                    var adapter = new MySqlDataAdapter(cmd);
                    var tabla = new DataTable();
                    adapter.Fill(tabla);
                    DGV_Ventas.DataSource = tabla;
                }
            }
        }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecommercetp1
{
    public partial class FormLogistica : Form
    {
        List<Envio> envios = new List<Envio>();
        public FormLogistica()
        {
            InitializeComponent();
            CargarEnviosDesdeDB();
        }

        private void FormLogistica_Click(object sender, EventArgs e)
        {
            FormLogistica f = new FormLogistica();
            f.MdiParent = this;
            f.Show();
        }

        private void logisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idEnvio;
            int idVenta;

            if (!int.TryParse(textBox1.Text, out idEnvio))
            {
                MessageBox.Show("ID Envío debe ser un número");
                return;
            }

            if (!int.TryParse(textBox5.Text, out idVenta))
            {
                MessageBox.Show("ID Venta debe ser un número");
                return;
            }

            Envio nuevo = new Envio
            {
                ID_Envio = idEnvio,
                ID_Venta = idVenta,
                Direccion = textBox4.Text,
                Empresa = textBox3.Text,
                EstadoEnvio = textBox2.Text
            };

            envios.Add(nuevo);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = envios;

            // ✅ NUEVO: INSERT en MySQL
            string query = @"INSERT INTO envios (ID_Envio, ID_Venta, Direccion, Empresa, EstadoEnvio) 
                     VALUES (@idEnvio, @idVenta, @direccion, @empresa, @estado)";

            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idEnvio", nuevo.ID_Envio);
                    cmd.Parameters.AddWithValue("@idVenta", nuevo.ID_Venta);
                    cmd.Parameters.AddWithValue("@direccion", nuevo.Direccion);
                    cmd.Parameters.AddWithValue("@empresa", nuevo.Empresa);
                    cmd.Parameters.AddWithValue("@estado", nuevo.EstadoEnvio);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Envío guardado con éxito.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }

        private void CargarEnviosDesdeDB()
        {
            string query = "SELECT * FROM envios";
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                var adapter = new MySqlDataAdapter(query, conn);
                var tabla = new DataTable();
                adapter.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Envio seleccionado = (Envio)dataGridView1.CurrentRow.DataBoundItem;
                envios.Remove(seleccionado);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = envios;
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idEnvio;
            int idVenta;

            // Validamos que no estén vacíos y sean números enteros
            if (!int.TryParse(textBox1.Text, out idEnvio))
            {
                MessageBox.Show("Por favor, ingresá el ID Envío numérico que querés modificar.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out idVenta))
            {
                MessageBox.Show("ID Venta debe ser un número válido.");
                return;
            }

            try
            {
                string query = @"UPDATE envios SET ID_Venta = @idVenta, Direccion = @direccion, 
                 Empresa = @empresa, EstadoEnvio = @estado 
                 WHERE ID_Envio = @idEnvio";

                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idEnvio", idEnvio);
                        cmd.Parameters.AddWithValue("@idVenta", idVenta);
                        cmd.Parameters.AddWithValue("@direccion", textBox4.Text);
                        cmd.Parameters.AddWithValue("@empresa", textBox3.Text);
                        cmd.Parameters.AddWithValue("@estado", textBox2.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Envío modificado con éxito.");
                CargarEnviosDesdeDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                // 🔍 Verificamos si el usuario escribió algo en el campo ID_Envio (textBox1)
                bool buscaPorId = !string.IsNullOrEmpty(textBox1.Text);

                // ==========================================
                // 1. FILTRADO EN LA LISTA LOCAL (envios)
                // ==========================================
                if (buscaPorId)
                {
                    if (int.TryParse(textBox1.Text, out int idBuscado))
                    {
                        var resultadoLocal = envios.Where(env => env.ID_Envio == idBuscado).ToList();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = resultadoLocal;
                    }
                }
                else
                {
                    string filtroEmpresa = textBox3.Text.ToLower();
                    var resultadoLocal = envios
                                         .Where(env => (env.Empresa ?? "").ToLower().Contains(filtroEmpresa))
                                         .ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = resultadoLocal;
                }

                // ==========================================
                // 2. CONSULTA EN MYSQL (phpMyAdmin)
                // ==========================================
                if (buscaPorId)
                {
                    // Busca coincidencia exacta por ID de Envío
                    query = "SELECT * FROM envios WHERE ID_Envio = @id";
                }
                else
                {
                    // Busca coincidencias parciales por el nombre de la Empresa transportista
                    query = "SELECT * FROM envios WHERE LOWER(Empresa) LIKE @filtro";
                }

                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (buscaPorId)
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + textBox3.Text.ToLower() + "%");
                        }

                        var adapter = new MySqlDataAdapter(cmd);
                        var tabla = new DataTable();
                        adapter.Fill(tabla);

                        // Muestra el resultado final extraído de la base de datos en tu grilla
                        dataGridView1.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el envío: " + ex.Message);
            }
        }
    }
}

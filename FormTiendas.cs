using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO; // <--- AGREGAR ESTO
using System.Linq;
using System.Windows.Forms;

namespace ecommercetp1
{
    public partial class FormTiendas : Form
    {
        public FormTiendas()
        {
            InitializeComponent();

            // botón Modificar
            Button btn_Modificar = new Button();
            btn_Modificar.Text = "Modificar";
            btn_Modificar.Location = new Point(672, 170);
            btn_Modificar.Size = new Size(75, 23);
            btn_Modificar.Click += btn_Modificar_Click;
            this.Controls.Add(btn_Modificar);

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.SelectedIndex = 0;

            // ✅ Cargar desde MySQL en vez de JSON
            CargarTiendasDesdeDB();
        }

        private void CargarTiendasDesdeDB()
        {
            string query = "SELECT * FROM tiendas";
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                var adapter = new MySqlDataAdapter(query, conn);
                var tabla = new DataTable();
                adapter.Fill(tabla);
                dgvTiendas.DataSource = tabla;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Código existente, no se toca
                Tienda nueva = new Tienda
                {
                    IdTienda = int.Parse(txtIdTienda.Text),
                    IdUsuarioAdm = int.Parse(cmbUsuario.Text),
                    Nombre = txtNombreTienda.Text,
                    Url = txtUrl.Text,
                    Estado = (cmbEstado.Text == "Activo")
                };
                RepositorioCentral.TodasLasTiendas.Add(nueva);
                ActualizarGrid();
                RepositorioCentral.GuardarDatos();

                // ✅ NUEVO: INSERT en MySQL
                string query = @"INSERT INTO tiendas (IdTienda, IdUsuarioAdm, Nombre, Url, Estado) 
                         VALUES (@id, @idAdm, @nombre, @url, @estado)";

                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", nueva.IdTienda);
                        cmd.Parameters.AddWithValue("@idAdm", nueva.IdUsuarioAdm);
                        cmd.Parameters.AddWithValue("@nombre", nueva.Nombre);
                        cmd.Parameters.AddWithValue("@url", nueva.Url);
                        cmd.Parameters.AddWithValue("@estado", nueva.Estado ? 1 : 0);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tienda guardada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ActualizarGrid()
        {
            dgvTiendas.DataSource = null;
            dgvTiendas.DataSource = RepositorioCentral.TodasLasTiendas;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvTiendas.CurrentRow != null && dgvTiendas.CurrentRow.DataBoundItem != null)
            {
                Tienda seleccionada = (Tienda)dgvTiendas.CurrentRow.DataBoundItem;
                string nombreTienda = seleccionada.Nombre ?? "esta tienda";

                DialogResult respuesta = MessageBox.Show("¿Borrar " + nombreTienda + "?", "Confirmar", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    RepositorioCentral.TodasLasTiendas.Remove(seleccionada);
                    ActualizarGrid();
                    // También guardamos después de eliminar para actualizar el archivo
                    RepositorioCentral.GuardarDatos();
                }
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                // 🔍 Averiguamos si el usuario escribió algo en el campo ID
                bool buscaPorId = !string.IsNullOrEmpty(txtIdTienda.Text);

                // ==========================================
                // 1. FILTRADO EN MEMORIA (RepositorioCentral)
                // ==========================================
                if (buscaPorId)
                {
                    if (int.TryParse(txtIdTienda.Text, out int idBuscado))
                    {
                        var resultadoMemoria = RepositorioCentral.TodasLasTiendas
                                              .Where(t => t.IdTienda == idBuscado)
                                              .ToList();
                        dgvTiendas.DataSource = null;
                        dgvTiendas.DataSource = resultadoMemoria;
                    }
                }
                else
                {
                    string filtroNombre = txtNombreTienda.Text.ToLower();
                    var resultadoMemoria = RepositorioCentral.TodasLasTiendas
                                          .Where(t => (t.Nombre ?? "").ToLower().Contains(filtroNombre))
                                          .ToList();
                    dgvTiendas.DataSource = null;
                    dgvTiendas.DataSource = resultadoMemoria;
                }


                // ==========================================
                // 2. CONSULTA EN MYSQL (phpMyAdmin)
                // ==========================================
                if (buscaPorId)
                {
                    // Si hay ID, la consulta busca por el campo exacto IdTienda
                    query = "SELECT * FROM tiendas WHERE IdTienda = @id";
                }
                else
                {
                    // Si el ID está vacío, busca por aproximación en el Nombre
                    query = "SELECT * FROM tiendas WHERE LOWER(Nombre) LIKE @filtro";
                }

                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (buscaPorId)
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(txtIdTienda.Text));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + txtNombreTienda.Text.ToLower() + "%");
                        }

                        var adapter = new MySqlDataAdapter(cmd);
                        var tabla = new DataTable();
                        adapter.Fill(tabla);

                        // Esta línea predomina y dibuja los datos reales que trajo MySQL
                        dgvTiendas.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dgvTiendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTiendas.CurrentRow != null && e.RowIndex >= 0)
            {
                var estadoValor = dgvTiendas.Rows[e.RowIndex].Cells["Estado"].Value;
                

                txtIdTienda.Text = dgvTiendas.Rows[e.RowIndex].Cells["IdTienda"].Value.ToString();
                cmbUsuario.Text = dgvTiendas.Rows[e.RowIndex].Cells["IdUsuarioAdm"].Value.ToString();
                txtNombreTienda.Text = dgvTiendas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtUrl.Text = dgvTiendas.Rows[e.RowIndex].Cells["Url"].Value.ToString();
                cmbEstado.Text = (estadoValor.ToString() == "1" || estadoValor.ToString().ToLower() == "true") ? "Activo" : "Inactivo";
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                string estadoActual = cmbEstado.Text; // ← va primero

                string query = @"UPDATE tiendas SET IdUsuarioAdm = @idAdm, Nombre = @nombre, 
                 Url = @url, Estado = @estado 
                 WHERE IdTienda = @id";

                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtIdTienda.Text));
                        cmd.Parameters.AddWithValue("@idAdm", int.Parse(cmbUsuario.Text));
                        cmd.Parameters.AddWithValue("@nombre", txtNombreTienda.Text);
                        cmd.Parameters.AddWithValue("@url", txtUrl.Text);
                        cmd.Parameters.AddWithValue("@estado", cmbEstado.Text == "Activo" ? 1 : 0);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tienda modificada con éxito.");
                CargarTiendasDesdeDB();
                cmbEstado.Text = estadoActual; // ← restaura el estado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
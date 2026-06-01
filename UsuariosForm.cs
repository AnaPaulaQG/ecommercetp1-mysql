using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ecommercetp1
{
    public partial class UsuariosForm : Form
    {
        int idSeleccionado = -1;

        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            cbTiendas.SelectedIndex = -1;
            idSeleccionado = -1;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvUsuarios.CurrentRow;

                idSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtEmail.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtContraseña.Text = dgvUsuarios.Rows[e.RowIndex].Cells["contrasena"].Value.ToString();
                cbTiendas.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Tienda"].Value.ToString();
            }
        }

        public void ModificarDatos()
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Por favor, selecciona un registro de la tabla primero.");
                return;
            }
            using (MySqlConnection conn = ConexionDB.ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE usuarios SET Nombre = @nom, Tienda = @tie, contrasena = @pass, Email = @mail WHERE ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@tie", cbTiendas.Text);
                        cmd.Parameters.AddWithValue("@pass", txtContraseña.Text);
                        cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@id", idSeleccionado);

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Registro actualizado con éxito.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
            }
        }

        public void MostrarDatos()
        {
            using (MySqlConnection conn = ConexionDB.ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM `usuarios`";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable tabla = new DataTable();

                    adapter.Fill(tabla);

                    dgvUsuarios.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(cbTiendas.Text) ||
            string.IsNullOrWhiteSpace(txtContraseña.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            using (MySqlConnection conn = ConexionDB.ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO usuarios (Nombre, Tienda, contrasena, Email) VALUES (@Nombre, @Tienda, @contrasena, @Email)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Tienda", cbTiendas.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtContraseña.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Usuario guardado correctamente");

                        LimpiarCampos();
                        MostrarDatos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado >= 0)
            {
                ModificarDatos();
                LimpiarCampos();
                MostrarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Por favor, selecciona un registro de la tabla para eliminar.");
                return;
            }

            using (MySqlConnection conn = ConexionDB.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM usuarios WHERE ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idSeleccionado);
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.");

                            idSeleccionado = -1;
                            LimpiarCampos();
                            MostrarDatos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Actualizar_SQL_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
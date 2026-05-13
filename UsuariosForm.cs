using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ecommercetp1


{
    public partial class UsuariosForm : Form
    {
        int filaSeleccionada = -1;
        // SqlConnection con = new SqlConnection("TU_CONEXION");

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
            filaSeleccionada = -1;
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtEmail.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtContraseña.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbTiendas.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns.Add("Email", "Email");
            dgvUsuarios.Columns.Add("Password", "Contraseña");
            dgvUsuarios.Columns.Add("Tienda", "Tienda");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Add(
                txtNombre.Text,
                txtEmail.Text,
                txtContraseña.Text,
                cbTiendas.Text
            );

            // ✅ NUEVO: INSERT en MySQL
            string query = @"INSERT INTO usuarios (Nombre, Email, Contrasena, Tienda) 
                     VALUES (@nombre, @email, @contrasena, @tienda)";

            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txtContraseña.Text);
                    cmd.Parameters.AddWithValue("@tienda", cbTiendas.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuario guardado correctamente.");
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                dgvUsuarios.Rows[filaSeleccionada].Cells[0].Value = txtNombre.Text;
                dgvUsuarios.Rows[filaSeleccionada].Cells[1].Value = txtEmail.Text;
                dgvUsuarios.Rows[filaSeleccionada].Cells[2].Value = txtContraseña.Text;
                dgvUsuarios.Rows[filaSeleccionada].Cells[3].Value = cbTiendas.Text;

                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                dgvUsuarios.Rows.RemoveAt(filaSeleccionada);
                LimpiarCampos();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Actualizar_SQL_Click(object sender, EventArgs e)
        {
            // ya no se usa
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Conexion_Click(object sender, EventArgs e)
        {
            // ya no se usa
        }
    }
}

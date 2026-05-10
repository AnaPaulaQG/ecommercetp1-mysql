using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ecommercetp1
{
    public partial class UsuariosForm : Form
    {
        int filaSeleccionada = -1;

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
    }
}

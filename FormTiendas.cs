using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO; // <--- AGREGAR ESTO
using Newtonsoft.Json;

namespace ecommercetp1
{
    public partial class FormTiendas : Form
    {
        public FormTiendas()
        {
            InitializeComponent();

            // 1. Cargamos los datos del archivo JSON apenas arranca el programa
            RepositorioCentral.CargarDatos();

            // 2. Configuramos el ComboBox de Estado
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.SelectedIndex = 0;

            // 3. Vinculamos la lista al Grid
            dgvTiendas.DataSource = RepositorioCentral.TodasLasTiendas;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos la tienda
                Tienda nueva = new Tienda
                {
                    IdTienda = int.Parse(txtIdTienda.Text),
                    IdUsuarioAdm = int.Parse(cmbUsuario.Text),
                    Nombre = txtNombreTienda.Text,
                    Url = txtUrl.Text,
                    Estado = (cmbEstado.Text == "Activo")
                };

                // Agregamos a la lista global
                RepositorioCentral.TodasLasTiendas.Add(nueva);

                // Refrescamos visualmente la tabla
                ActualizarGrid();

                // GUARDAMOS EN EL ARCHIVO JSON (Persistencia)
                RepositorioCentral.GuardarDatos();

                MessageBox.Show("Tienda guardada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Verifica que los IDs sean números. " + ex.Message);
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
            string filtro = txtNombreTienda.Text.ToLower();

            var resultado = RepositorioCentral.TodasLasTiendas
                            .Where(t => (t.Nombre ?? "").ToLower().Contains(filtro))
                            .ToList();

            dgvTiendas.DataSource = null;
            dgvTiendas.DataSource = resultado;
        }

        private void dgvTiendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTiendas.CurrentRow != null && dgvTiendas.CurrentRow.DataBoundItem != null)
            {
                Tienda t = (Tienda)dgvTiendas.CurrentRow.DataBoundItem;
                txtIdTienda.Text = t.IdTienda.ToString();
                cmbUsuario.Text = t.IdUsuarioAdm.ToString();
                txtNombreTienda.Text = t.Nombre ?? "";
                txtUrl.Text = t.Url ?? "";
                cmbEstado.Text = t.Estado ? "Activo" : "Inactivo";
            }
        }
    }
}
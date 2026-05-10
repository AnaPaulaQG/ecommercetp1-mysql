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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
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
    }
}

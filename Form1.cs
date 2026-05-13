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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuariosMI_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is UsuariosForm)
                {
                    hijo.Activate();
                    return;
                }
            }

            UsuariosForm form = new UsuariosForm();
            form.MdiParent = this;
            form.Show();
        }

        private void logisticaMI_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormLogistica)
                {
                    hijo.Activate();
                    return;
                }
            }

            FormLogistica form = new FormLogistica();
            form.MdiParent = this;
            form.Show();
        }

        private void tiendasMI_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormTiendas)
                {
                    hijo.Activate();
                    return;
                }
            }

            FormTiendas form = new FormTiendas();
            form.MdiParent = this;
            form.Show();
        }

        private void resumenMI_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormResumen)
                {
                    hijo.Activate();
                    return;
                }
            }

            FormResumen form = new FormResumen();
            form.MdiParent = this;
            form.Show();
        }
    }
}

namespace ecommercetp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            comercioMI = new ToolStripMenuItem();
            tiendasMI = new ToolStripMenuItem();
            usuariosMI = new ToolStripMenuItem();
            ventasMI = new ToolStripMenuItem();
            logisticaMI = new ToolStripMenuItem();
            resumenMI = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { comercioMI, tiendasMI, usuariosMI, ventasMI, logisticaMI, resumenMI });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // comercioMI
            // 
            comercioMI.Name = "comercioMI";
            comercioMI.Size = new Size(76, 20);
            comercioMI.Text = "Comercios";
            // 
            // tiendasMI
            // 
            tiendasMI.Name = "tiendasMI";
            tiendasMI.Size = new Size(59, 20);
            tiendasMI.Text = "Tiendas";
            tiendasMI.Click += tiendasMI_Click;
            // 
            // usuariosMI
            // 
            usuariosMI.Name = "usuariosMI";
            usuariosMI.Size = new Size(106, 20);
            usuariosMI.Text = "Usuarios Admin.";
            usuariosMI.Click += usuariosMI_Click;
            // 
            // ventasMI
            // 
            ventasMI.Name = "ventasMI";
            ventasMI.Size = new Size(53, 20);
            ventasMI.Text = "Ventas";
            // 
            // logisticaMI
            // 
            logisticaMI.Name = "logisticaMI";
            logisticaMI.Size = new Size(66, 20);
            logisticaMI.Text = "Logistica";
            logisticaMI.Click += logisticaMI_Click;
            // 
            // resumenMI
            // 
            resumenMI.Name = "resumenMI";
            resumenMI.Size = new Size(68, 20);
            resumenMI.Text = "Resumen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem comercioMI;
        private ToolStripMenuItem tiendasMI;
        private ToolStripMenuItem usuariosMI;
        private ToolStripMenuItem ventasMI;
        private ToolStripMenuItem logisticaMI;
        private ToolStripMenuItem resumenMI;
    }
}

namespace ecommercetp1
{
    partial class FormResumen
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

        private void InitializeComponent()
        {
            this.lbl_TC = new System.Windows.Forms.Label();
            this.lbl_TV = new System.Windows.Forms.Label();
            this.lbl_VA = new System.Windows.Forms.Label();
            this.lbl_IT = new System.Windows.Forms.Label();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.txt_TV = new System.Windows.Forms.TextBox();
            this.txt_VA = new System.Windows.Forms.TextBox();
            this.txt_IT = new System.Windows.Forms.TextBox();
            this.DGV_Resumen = new System.Windows.Forms.DataGridView();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Resumen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Location = new System.Drawing.Point(7, 27);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(95, 15);
            this.lbl_TC.Text = "Total_Comercios";
            // 
            // lbl_TV
            // 
            this.lbl_TV.AutoSize = true;
            this.lbl_TV.Location = new System.Drawing.Point(113, 27);
            this.lbl_TV.Name = "lbl_TV";
            this.lbl_TV.Size = new System.Drawing.Size(72, 15);
            this.lbl_TV.Text = "Total_Ventas";
            // 
            // lbl_VA
            // 
            this.lbl_VA.AutoSize = true;
            this.lbl_VA.Location = new System.Drawing.Point(219, 27);
            this.lbl_VA.Name = "lbl_VA";
            this.lbl_VA.Size = new System.Drawing.Size(103, 15);
            this.lbl_VA.Text = "Ventas_Aprobadas";
            // 
            // lbl_IT
            // 
            this.lbl_IT.AutoSize = true;
            this.lbl_IT.Location = new System.Drawing.Point(325, 27);
            this.lbl_IT.Name = "lbl_IT";
            this.lbl_IT.Size = new System.Drawing.Size(93, 15);
            this.lbl_IT.Text = "Ingresos_Totales";
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(7, 47);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(100, 23);
            // 
            // txt_TV
            // 
            this.txt_TV.Location = new System.Drawing.Point(113, 47);
            this.txt_TV.Name = "txt_TV";
            this.txt_TV.Size = new System.Drawing.Size(100, 23);
            // 
            // txt_VA
            // 
            this.txt_VA.Location = new System.Drawing.Point(219, 47);
            this.txt_VA.Name = "txt_VA";
            this.txt_VA.Size = new System.Drawing.Size(100, 23);
            // 
            // txt_IT
            // 
            this.txt_IT.Location = new System.Drawing.Point(325, 47);
            this.txt_IT.Name = "txt_IT";
            this.txt_IT.Size = new System.Drawing.Size(100, 23);
            // 
            // DGV_Resumen
            // 
            this.DGV_Resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Resumen.Location = new System.Drawing.Point(7, 76);
            this.DGV_Resumen.Name = "DGV_Resumen";
            this.DGV_Resumen.Size = new System.Drawing.Size(508, 150);
            this.DGV_Resumen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Resumen_CellContentClick);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(539, 76);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // FormResumen
            // 
            this.ClientSize = new System.Drawing.Size(805, 324);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.DGV_Resumen);
            this.Controls.Add(this.txt_IT);
            this.Controls.Add(this.txt_VA);
            this.Controls.Add(this.txt_TV);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.lbl_IT);
            this.Controls.Add(this.lbl_VA);
            this.Controls.Add(this.lbl_TV);
            this.Controls.Add(this.lbl_TC);
            this.Name = "FormResumen";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Resumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label lbl_TV;
        private System.Windows.Forms.Label lbl_VA;
        private System.Windows.Forms.Label lbl_IT;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.TextBox txt_TV;
        private System.Windows.Forms.TextBox txt_VA;
        private System.Windows.Forms.DataGridView DGV_Resumen;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.TextBox txt_IT;
    }
}
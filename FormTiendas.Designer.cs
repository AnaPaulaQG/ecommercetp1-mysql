namespace ecommercetp1
{
    partial class FormTiendas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIdTienda = new TextBox();
            txtNombreTienda = new TextBox();
            txtUrl = new TextBox();
            btn_Agregar = new Button();
            btn_Eliminar = new Button();
            btn_Buscar = new Button();
            dgvTiendas = new DataGridView();
            cmbUsuario = new ComboBox();
            cmbEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTiendas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "ID_Tienda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 31);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "ID_Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 31);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre Tienda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 31);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "URL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 31);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Estado";
            // 
            // txtIdTienda
            // 
            txtIdTienda.Location = new Point(12, 49);
            txtIdTienda.Name = "txtIdTienda";
            txtIdTienda.Size = new Size(100, 23);
            txtIdTienda.TabIndex = 5;
            // 
            // txtNombreTienda
            // 
            txtNombreTienda.Location = new Point(264, 49);
            txtNombreTienda.Name = "txtNombreTienda";
            txtNombreTienda.Size = new Size(100, 23);
            txtNombreTienda.TabIndex = 7;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(390, 49);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(100, 23);
            txtUrl.TabIndex = 8;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(672, 78);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 28);
            btn_Agregar.TabIndex = 15;
            btn_Agregar.Text = "&Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(672, 112);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(75, 23);
            btn_Eliminar.TabIndex = 16;
            btn_Eliminar.Text = "&Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(672, 141);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 17;
            btn_Buscar.Text = "&Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // dgvTiendas
            // 
            dgvTiendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTiendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiendas.Location = new Point(12, 78);
            dgvTiendas.Name = "dgvTiendas";
            dgvTiendas.Size = new Size(604, 150);
            dgvTiendas.TabIndex = 18;
            dgvTiendas.CellClick += dgvTiendas_CellClick;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(118, 49);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(121, 23);
            cmbUsuario.TabIndex = 19;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(496, 49);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbEstado);
            Controls.Add(cmbUsuario);
            Controls.Add(dgvTiendas);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Agregar);
            Controls.Add(txtUrl);
            Controls.Add(txtNombreTienda);
            Controls.Add(txtIdTienda);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTiendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdTienda;
        private TextBox txtNombreTienda;
        private TextBox txtUrl;
        private Button btn_Agregar;
        private Button btn_Eliminar;
        private Button btn_Buscar;
        private DataGridView dgvTiendas;
        private ComboBox cmbUsuario;
        private ComboBox cmbEstado;
    }
}

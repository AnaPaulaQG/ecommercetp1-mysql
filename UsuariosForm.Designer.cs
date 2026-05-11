namespace ecommercetp1
{
    partial class UsuariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblEmail = new Label();
            lblContraseña = new Label();
            lblTienda = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            cbTiendas = new ComboBox();
            btnLimpiar = new Button();
            dgvUsuarios = new DataGridView();
            Actualizar_SQL = new Button();
            Conexion = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(12, 109);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // lblTienda
            // 
            lblTienda.AutoSize = true;
            lblTienda.Location = new Point(12, 138);
            lblTienda.Name = "lblTienda";
            lblTienda.Size = new Size(43, 15);
            lblTienda.TabIndex = 4;
            lblTienda.Text = "Tienda";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(85, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(85, 106);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(209, 47);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(209, 80);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(209, 109);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // cbTiendas
            // 
            cbTiendas.Location = new Point(85, 138);
            cbTiendas.Name = "cbTiendas";
            cbTiendas.Size = new Size(100, 23);
            cbTiendas.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(209, 138);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 194);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.Size = new Size(376, 150);
            dgvUsuarios.TabIndex = 16;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // Actualizar_SQL
            // 
            Actualizar_SQL.Location = new Point(290, 8);
            Actualizar_SQL.Name = "Actualizar_SQL";
            Actualizar_SQL.Size = new Size(75, 23);
            Actualizar_SQL.TabIndex = 17;
            Actualizar_SQL.Text = "&Actualizar";
            Actualizar_SQL.UseVisualStyleBackColor = true;
            Actualizar_SQL.Click += Actualizar_SQL_Click;
            // 
            // Conexion
            // 
            Conexion.Location = new Point(209, 8);
            Conexion.Name = "Conexion";
            Conexion.Size = new Size(75, 23);
            Conexion.TabIndex = 18;
            Conexion.Text = "&Conectar";
            Conexion.UseVisualStyleBackColor = true;
            Conexion.Click += Conexion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 19;
            label1.Text = "SQL";
            label1.Click += label1_Click;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 367);
            Controls.Add(label1);
            Controls.Add(Conexion);
            Controls.Add(Actualizar_SQL);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnLimpiar);
            Controls.Add(cbTiendas);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(lblTienda);
            Controls.Add(lblContraseña);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Name = "UsuariosForm";
            Text = "UsuariosForm";
            Load += UsuariosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private Label lblEmail;
        private Label lblContraseña;
        private Label lblTienda;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private ComboBox cbTiendas;
        private Button btnLimpiar;
        private DataGridView dgvUsuarios;
        private Button Actualizar_SQL;
        private Button Conexion;
        private Label label1;
    }
}
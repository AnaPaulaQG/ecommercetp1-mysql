namespace ecommercetp1
{
    partial class FormComercios
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
            lbl_IDC = new Label();
            lbl_NC = new Label();
            lbl_Rubro = new Label();
            lbl_Email = new Label();
            lbl_Telefono = new Label();
            lbl_Plan = new Label();
            lbl_Fecha = new Label();
            txt_IDC = new TextBox();
            txt_NC = new TextBox();
            txt_Rubro = new TextBox();
            txt_Email = new TextBox();
            txt_Telefono = new TextBox();
            txt_Plan = new TextBox();
            txt_Fecha = new TextBox();
            DGV_Comercios = new DataGridView();
            btn_Agregar = new Button();
            btn_Eliminar = new Button();
            btn_Modificar = new Button();
            btn_Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Comercios).BeginInit();
            SuspendLayout();
            // 
            // lbl_IDC
            // 
            lbl_IDC.AutoSize = true;
            lbl_IDC.Location = new Point(23, 19);
            lbl_IDC.Name = "lbl_IDC";
            lbl_IDC.Size = new Size(80, 15);
            lbl_IDC.TabIndex = 0;
            lbl_IDC.Text = "ID_Comercios";
            // 
            // lbl_NC
            // 
            lbl_NC.AutoSize = true;
            lbl_NC.Location = new Point(23, 48);
            lbl_NC.Name = "lbl_NC";
            lbl_NC.Size = new Size(108, 15);
            lbl_NC.TabIndex = 1;
            lbl_NC.Text = "Nombre_Comercio";
            // 
            // lbl_Rubro
            // 
            lbl_Rubro.AutoSize = true;
            lbl_Rubro.Location = new Point(23, 77);
            lbl_Rubro.Name = "lbl_Rubro";
            lbl_Rubro.Size = new Size(39, 15);
            lbl_Rubro.TabIndex = 2;
            lbl_Rubro.Text = "Rubro";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(23, 106);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(36, 15);
            lbl_Email.TabIndex = 3;
            lbl_Email.Text = "Email";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(23, 136);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(53, 15);
            lbl_Telefono.TabIndex = 4;
            lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Plan
            // 
            lbl_Plan.AutoSize = true;
            lbl_Plan.Location = new Point(23, 165);
            lbl_Plan.Name = "lbl_Plan";
            lbl_Plan.Size = new Size(30, 15);
            lbl_Plan.TabIndex = 5;
            lbl_Plan.Text = "Plan";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new Point(23, 194);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(38, 15);
            lbl_Fecha.TabIndex = 6;
            lbl_Fecha.Text = "Fecha";
            // 
            // txt_IDC
            // 
            txt_IDC.Location = new Point(137, 11);
            txt_IDC.Name = "txt_IDC";
            txt_IDC.Size = new Size(100, 23);
            txt_IDC.TabIndex = 7;
            // 
            // txt_NC
            // 
            txt_NC.Location = new Point(137, 40);
            txt_NC.Name = "txt_NC";
            txt_NC.Size = new Size(100, 23);
            txt_NC.TabIndex = 8;
            // 
            // txt_Rubro
            // 
            txt_Rubro.Location = new Point(137, 69);
            txt_Rubro.Name = "txt_Rubro";
            txt_Rubro.Size = new Size(100, 23);
            txt_Rubro.TabIndex = 9;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(137, 98);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(100, 23);
            txt_Email.TabIndex = 10;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(137, 128);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(100, 23);
            txt_Telefono.TabIndex = 11;
            // 
            // txt_Plan
            // 
            txt_Plan.Location = new Point(137, 157);
            txt_Plan.Name = "txt_Plan";
            txt_Plan.Size = new Size(100, 23);
            txt_Plan.TabIndex = 12;
            // 
            // txt_Fecha
            // 
            txt_Fecha.Location = new Point(137, 186);
            txt_Fecha.Name = "txt_Fecha";
            txt_Fecha.Size = new Size(100, 23);
            txt_Fecha.TabIndex = 13;
            // 
            // DGV_Comercios
            // 
            DGV_Comercios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Comercios.Location = new Point(259, 11);
            DGV_Comercios.Name = "DGV_Comercios";
            DGV_Comercios.Size = new Size(572, 198);
            DGV_Comercios.TabIndex = 14;
            DGV_Comercios.CellClick += DGV_Comercios_CellClick;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(837, 39);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 23);
            btn_Agregar.TabIndex = 15;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(837, 68);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(75, 23);
            btn_Eliminar.TabIndex = 16;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Location = new Point(837, 97);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(75, 23);
            btn_Modificar.TabIndex = 17;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(837, 126);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 18;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // FormComercios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Modificar);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Agregar);
            Controls.Add(DGV_Comercios);
            Controls.Add(txt_Fecha);
            Controls.Add(txt_Plan);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Email);
            Controls.Add(txt_Rubro);
            Controls.Add(txt_NC);
            Controls.Add(txt_IDC);
            Controls.Add(lbl_Fecha);
            Controls.Add(lbl_Plan);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Rubro);
            Controls.Add(lbl_NC);
            Controls.Add(lbl_IDC);
            Name = "FormComercios";
            Text = "FormComercios";
            ((System.ComponentModel.ISupportInitialize)DGV_Comercios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_IDC;
        private Label lbl_NC;
        private Label lbl_Rubro;
        private Label lbl_Email;
        private Label lbl_Telefono;
        private Label lbl_Plan;
        private Label lbl_Fecha;
        private TextBox txt_IDC;
        private TextBox txt_NC;
        private TextBox txt_Rubro;
        private TextBox txt_Email;
        private TextBox txt_Telefono;
        private TextBox txt_Plan;
        private TextBox txt_Fecha;
        private DataGridView DGV_Comercios;
        private Button btn_Agregar;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Button btn_Buscar;
    }
}
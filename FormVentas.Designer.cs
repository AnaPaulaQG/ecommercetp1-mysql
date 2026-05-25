namespace ecommercetp1
{
    partial class FormVentas
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
            lbl_IDVenta = new Label();
            lbl_IDTienda = new Label();
            lbl_Cliente = new Label();
            lbl_Producto = new Label();
            lbl_Monto = new Label();
            lbl_MedioDePago = new Label();
            lbl_EstadoDePago = new Label();
            lbl_Fecha = new Label();
            txt_Venta = new TextBox();
            txt_Tienda = new TextBox();
            txt_Cliente = new TextBox();
            txt_Producto = new TextBox();
            txt_Monto = new TextBox();
            txt_MDP = new TextBox();
            txt_EDP = new TextBox();
            txt_Fecha = new TextBox();
            DGV_Ventas = new DataGridView();
            btn_agregar = new Button();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Ventas).BeginInit();
            SuspendLayout();
            // 
            // lbl_IDVenta
            // 
            lbl_IDVenta.AutoSize = true;
            lbl_IDVenta.Location = new Point(13, 12);
            lbl_IDVenta.Name = "lbl_IDVenta";
            lbl_IDVenta.Size = new Size(52, 15);
            lbl_IDVenta.TabIndex = 0;
            lbl_IDVenta.Text = "ID_Venta";
            // 
            // lbl_IDTienda
            // 
            lbl_IDTienda.AutoSize = true;
            lbl_IDTienda.Location = new Point(13, 46);
            lbl_IDTienda.Name = "lbl_IDTienda";
            lbl_IDTienda.Size = new Size(59, 15);
            lbl_IDTienda.TabIndex = 1;
            lbl_IDTienda.Text = "ID_Tienda";
            // 
            // lbl_Cliente
            // 
            lbl_Cliente.AutoSize = true;
            lbl_Cliente.Location = new Point(13, 75);
            lbl_Cliente.Name = "lbl_Cliente";
            lbl_Cliente.Size = new Size(44, 15);
            lbl_Cliente.TabIndex = 2;
            lbl_Cliente.Text = "Cliente";
            // 
            // lbl_Producto
            // 
            lbl_Producto.AutoSize = true;
            lbl_Producto.Location = new Point(13, 104);
            lbl_Producto.Name = "lbl_Producto";
            lbl_Producto.Size = new Size(56, 15);
            lbl_Producto.TabIndex = 3;
            lbl_Producto.Text = "Producto";
            // 
            // lbl_Monto
            // 
            lbl_Monto.AutoSize = true;
            lbl_Monto.Location = new Point(13, 133);
            lbl_Monto.Name = "lbl_Monto";
            lbl_Monto.Size = new Size(43, 15);
            lbl_Monto.TabIndex = 4;
            lbl_Monto.Text = "Monto";
            // 
            // lbl_MedioDePago
            // 
            lbl_MedioDePago.AutoSize = true;
            lbl_MedioDePago.Location = new Point(13, 162);
            lbl_MedioDePago.Name = "lbl_MedioDePago";
            lbl_MedioDePago.Size = new Size(91, 15);
            lbl_MedioDePago.TabIndex = 5;
            lbl_MedioDePago.Text = "Medio_de_Pago";
            // 
            // lbl_EstadoDePago
            // 
            lbl_EstadoDePago.AutoSize = true;
            lbl_EstadoDePago.Location = new Point(13, 191);
            lbl_EstadoDePago.Name = "lbl_EstadoDePago";
            lbl_EstadoDePago.Size = new Size(92, 15);
            lbl_EstadoDePago.TabIndex = 6;
            lbl_EstadoDePago.Text = "Estado_de_Pago";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new Point(13, 224);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(38, 15);
            lbl_Fecha.TabIndex = 7;
            lbl_Fecha.Text = "Fecha";
            // 
            // txt_Venta
            // 
            txt_Venta.Location = new Point(110, 9);
            txt_Venta.Name = "txt_Venta";
            txt_Venta.Size = new Size(100, 23);
            txt_Venta.TabIndex = 8;
            // 
            // txt_Tienda
            // 
            txt_Tienda.Location = new Point(110, 38);
            txt_Tienda.Name = "txt_Tienda";
            txt_Tienda.Size = new Size(100, 23);
            txt_Tienda.TabIndex = 9;
            // 
            // txt_Cliente
            // 
            txt_Cliente.Location = new Point(110, 67);
            txt_Cliente.Name = "txt_Cliente";
            txt_Cliente.Size = new Size(100, 23);
            txt_Cliente.TabIndex = 10;
            // 
            // txt_Producto
            // 
            txt_Producto.Location = new Point(110, 96);
            txt_Producto.Name = "txt_Producto";
            txt_Producto.Size = new Size(100, 23);
            txt_Producto.TabIndex = 11;
            // 
            // txt_Monto
            // 
            txt_Monto.Location = new Point(110, 125);
            txt_Monto.Name = "txt_Monto";
            txt_Monto.Size = new Size(100, 23);
            txt_Monto.TabIndex = 12;
            // 
            // txt_MDP
            // 
            txt_MDP.Location = new Point(110, 154);
            txt_MDP.Name = "txt_MDP";
            txt_MDP.Size = new Size(100, 23);
            txt_MDP.TabIndex = 13;
            // 
            // txt_EDP
            // 
            txt_EDP.Location = new Point(110, 183);
            txt_EDP.Name = "txt_EDP";
            txt_EDP.Size = new Size(100, 23);
            txt_EDP.TabIndex = 14;
            // 
            // txt_Fecha
            // 
            txt_Fecha.Location = new Point(110, 216);
            txt_Fecha.Name = "txt_Fecha";
            txt_Fecha.Size = new Size(100, 23);
            txt_Fecha.TabIndex = 15;
            // 
            // DGV_Ventas
            // 
            DGV_Ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Ventas.Location = new Point(225, 9);
            DGV_Ventas.Name = "DGV_Ventas";
            DGV_Ventas.Size = new Size(850, 230);
            DGV_Ventas.TabIndex = 16;
            DGV_Ventas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(13, 266);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 17;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(94, 266);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 18;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(175, 266);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 19;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(256, 266);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 20;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 450);
            Controls.Add(btn_buscar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_agregar);
            Controls.Add(DGV_Ventas);
            Controls.Add(txt_Fecha);
            Controls.Add(txt_EDP);
            Controls.Add(txt_MDP);
            Controls.Add(txt_Monto);
            Controls.Add(txt_Producto);
            Controls.Add(txt_Cliente);
            Controls.Add(txt_Tienda);
            Controls.Add(txt_Venta);
            Controls.Add(lbl_Fecha);
            Controls.Add(lbl_EstadoDePago);
            Controls.Add(lbl_MedioDePago);
            Controls.Add(lbl_Monto);
            Controls.Add(lbl_Producto);
            Controls.Add(lbl_Cliente);
            Controls.Add(lbl_IDTienda);
            Controls.Add(lbl_IDVenta);
            Name = "FormVentas";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)DGV_Ventas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_IDVenta;
        private Label lbl_IDTienda;
        private Label lbl_Cliente;
        private Label lbl_Producto;
        private Label lbl_Monto;
        private Label lbl_MedioDePago;
        private Label lbl_EstadoDePago;
        private Label lbl_Fecha;
        private TextBox txt_Venta;
        private TextBox txt_Tienda;
        private TextBox txt_Cliente;
        private TextBox txt_Producto;
        private TextBox txt_Monto;
        private TextBox txt_MDP;
        private TextBox txt_EDP;
        private TextBox txt_Fecha;
        private DataGridView DGV_Ventas;
        private Button btn_agregar;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_buscar;
    }
}
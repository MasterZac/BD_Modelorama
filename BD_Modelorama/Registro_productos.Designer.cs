namespace BD_Modelorama
{
    partial class Registro_productos
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
            this.components = new System.ComponentModel.Container();
            this.labelFecha = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.LabelNombreEmpleado = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.CmbBuscarProductos = new System.Windows.Forms.ComboBox();
            this.TxtBuscarProductosC = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtEstatus = new System.Windows.Forms.TextBox();
            this.BtnLimp = new System.Windows.Forms.Button();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Dgv2 = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtBuscarRegistros = new System.Windows.Forms.TextBox();
            this.CmbRegistros = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrecioVenta = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.Black;
            this.labelFecha.Location = new System.Drawing.Point(3, 170);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(41, 13);
            this.labelFecha.TabIndex = 42;
            this.labelFecha.Text = "label6";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(3, 131);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(111, 18);
            this.linkLabel3.TabIndex = 41;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Fecha / Hora:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(3, 30);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(128, 16);
            this.linkLabel2.TabIndex = 40;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Empleado activo:";
            // 
            // LabelNombreEmpleado
            // 
            this.LabelNombreEmpleado.AutoSize = true;
            this.LabelNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreEmpleado.ForeColor = System.Drawing.Color.Black;
            this.LabelNombreEmpleado.Location = new System.Drawing.Point(3, 59);
            this.LabelNombreEmpleado.Name = "LabelNombreEmpleado";
            this.LabelNombreEmpleado.Size = new System.Drawing.Size(41, 13);
            this.LabelNombreEmpleado.TabIndex = 39;
            this.LabelNombreEmpleado.Text = "label7";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.labelFecha);
            this.panel1.Controls.Add(this.LabelNombreEmpleado);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 546);
            this.panel1.TabIndex = 43;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(6, 226);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(158, 39);
            this.BtnMenu.TabIndex = 62;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Productos comprados";
            // 
            // DgvListadoProductos
            // 
            this.DgvListadoProductos.AllowUserToAddRows = false;
            this.DgvListadoProductos.AllowUserToDeleteRows = false;
            this.DgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoProductos.Location = new System.Drawing.Point(220, 59);
            this.DgvListadoProductos.Name = "DgvListadoProductos";
            this.DgvListadoProductos.ReadOnly = true;
            this.DgvListadoProductos.Size = new System.Drawing.Size(623, 119);
            this.DgvListadoProductos.TabIndex = 49;
            this.DgvListadoProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoProductos_CellClick);
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(724, 237);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(120, 33);
            this.Btneliminar.TabIndex = 50;
            this.Btneliminar.Text = "Habilitar / Deshabilitar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(626, 237);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 33);
            this.BtnEditar.TabIndex = 51;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(528, 32);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 27);
            this.BtnLimpiar.TabIndex = 52;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // CmbBuscarProductos
            // 
            this.CmbBuscarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBuscarProductos.FormattingEnabled = true;
            this.CmbBuscarProductos.Items.AddRange(new object[] {
            "Codigo_compra ",
            "Codigo_producto",
            "Nombre",
            "Cantidad ",
            "Precio_compra"});
            this.CmbBuscarProductos.Location = new System.Drawing.Point(222, 30);
            this.CmbBuscarProductos.Name = "CmbBuscarProductos";
            this.CmbBuscarProductos.Size = new System.Drawing.Size(121, 23);
            this.CmbBuscarProductos.TabIndex = 53;
            this.CmbBuscarProductos.Text = "Consultar por:";
            // 
            // TxtBuscarProductosC
            // 
            this.TxtBuscarProductosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarProductosC.Location = new System.Drawing.Point(360, 32);
            this.TxtBuscarProductosC.Name = "TxtBuscarProductosC";
            this.TxtBuscarProductosC.Size = new System.Drawing.Size(129, 21);
            this.TxtBuscarProductosC.TabIndex = 54;
            this.TxtBuscarProductosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarProductosC_KeyPress);
            this.TxtBuscarProductosC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscarProductosC_KeyUp);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(221, 244);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(108, 20);
            this.TxtCodigo.TabIndex = 55;
            this.TxtCodigo.Text = "Codigo";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(221, 288);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(108, 20);
            this.TxtNombre.TabIndex = 56;
            this.TxtNombre.Text = "Nombre";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(347, 244);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.ReadOnly = true;
            this.TxtPrecio.Size = new System.Drawing.Size(108, 20);
            this.TxtPrecio.TabIndex = 57;
            this.TxtPrecio.Text = "Precio";
            // 
            // TxtEstatus
            // 
            this.TxtEstatus.Location = new System.Drawing.Point(476, 288);
            this.TxtEstatus.Name = "TxtEstatus";
            this.TxtEstatus.ReadOnly = true;
            this.TxtEstatus.Size = new System.Drawing.Size(108, 20);
            this.TxtEstatus.TabIndex = 59;
            this.TxtEstatus.Text = "Estatus";
            // 
            // BtnLimp
            // 
            this.BtnLimp.Location = new System.Drawing.Point(768, 288);
            this.BtnLimp.Name = "BtnLimp";
            this.BtnLimp.Size = new System.Drawing.Size(75, 33);
            this.BtnLimp.TabIndex = 60;
            this.BtnLimp.Text = "Limpiar";
            this.BtnLimp.UseVisualStyleBackColor = true;
            this.BtnLimp.Click += new System.EventHandler(this.BtnLimp_Click);
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(347, 288);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.ReadOnly = true;
            this.TxtStock.Size = new System.Drawing.Size(108, 20);
            this.TxtStock.TabIndex = 61;
            this.TxtStock.Text = "Stock";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(217, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 20);
            this.linkLabel1.TabIndex = 62;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Detalle producto";
            // 
            // Dgv2
            // 
            this.Dgv2.AllowUserToAddRows = false;
            this.Dgv2.AllowUserToDeleteRows = false;
            this.Dgv2.AllowUserToResizeColumns = false;
            this.Dgv2.AllowUserToResizeRows = false;
            this.Dgv2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv2.Location = new System.Drawing.Point(220, 395);
            this.Dgv2.Name = "Dgv2";
            this.Dgv2.ReadOnly = true;
            this.Dgv2.Size = new System.Drawing.Size(624, 137);
            this.Dgv2.TabIndex = 63;
            this.Dgv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(626, 288);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(108, 33);
            this.BtnAgregar.TabIndex = 64;
            this.BtnAgregar.Text = "Registrar productos";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtBuscarRegistros
            // 
            this.TxtBuscarRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarRegistros.Location = new System.Drawing.Point(360, 368);
            this.TxtBuscarRegistros.Name = "TxtBuscarRegistros";
            this.TxtBuscarRegistros.Size = new System.Drawing.Size(129, 21);
            this.TxtBuscarRegistros.TabIndex = 67;
            this.TxtBuscarRegistros.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscarRegistros_KeyUp);
            // 
            // CmbRegistros
            // 
            this.CmbRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRegistros.FormattingEnabled = true;
            this.CmbRegistros.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Precio",
            "Precio_venta",
            "Stock",
            "Estatus"});
            this.CmbRegistros.Location = new System.Drawing.Point(222, 366);
            this.CmbRegistros.Name = "CmbRegistros";
            this.CmbRegistros.Size = new System.Drawing.Size(121, 23);
            this.CmbRegistros.TabIndex = 66;
            this.CmbRegistros.Text = "Consultar por:";
            // 
            // BtnLimpiar2
            // 
            this.BtnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar2.Location = new System.Drawing.Point(528, 368);
            this.BtnLimpiar2.Name = "BtnLimpiar2";
            this.BtnLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar2.TabIndex = 65;
            this.BtnLimpiar2.Text = "Limpiar";
            this.BtnLimpiar2.UseVisualStyleBackColor = true;
            this.BtnLimpiar2.Click += new System.EventHandler(this.BtnLimpiar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(473, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Ingresa precio venta";
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Location = new System.Drawing.Point(477, 245);
            this.TxtPrecioVenta.Mask = "99999999";
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioVenta.TabIndex = 69;
            this.TxtPrecioVenta.ValidatingType = typeof(int);
            // 
            // Registro_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 546);
            this.ControlBox = false;
            this.Controls.Add(this.TxtPrecioVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscarRegistros);
            this.Controls.Add(this.CmbRegistros);
            this.Controls.Add(this.BtnLimpiar2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.Dgv2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.BtnLimp);
            this.Controls.Add(this.TxtEstatus);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtBuscarProductosC);
            this.Controls.Add(this.CmbBuscarProductos);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.DgvListadoProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Registro_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros_productos";
            this.Load += new System.EventHandler(this.Registro_productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label LabelNombreEmpleado;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvListadoProductos;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ComboBox CmbBuscarProductos;
        private System.Windows.Forms.TextBox TxtBuscarProductosC;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtEstatus;
        private System.Windows.Forms.Button BtnLimp;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView Dgv2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtBuscarRegistros;
        private System.Windows.Forms.ComboBox CmbRegistros;
        private System.Windows.Forms.Button BtnLimpiar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtPrecioVenta;
    }
}
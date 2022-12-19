namespace BD_Modelorama
{
    partial class Compras
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TxtCodigoCompra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLimpiarP = new System.Windows.Forms.Button();
            this.BtnConsultarProveedor = new System.Windows.Forms.Button();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Codigo_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.TxtTotalCompra = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnTerminarCompra = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.TxtPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.ForeColor = System.Drawing.Color.Black;
            this.labelFecha.Location = new System.Drawing.Point(663, 11);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(35, 13);
            this.labelFecha.TabIndex = 38;
            this.labelFecha.Text = "label6";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(569, 9);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(88, 16);
            this.linkLabel3.TabIndex = 37;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Fecha / Hora:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(345, 11);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 16);
            this.linkLabel2.TabIndex = 36;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Empleado activo:";
            // 
            // LabelNombreEmpleado
            // 
            this.LabelNombreEmpleado.AutoSize = true;
            this.LabelNombreEmpleado.ForeColor = System.Drawing.Color.Black;
            this.LabelNombreEmpleado.Location = new System.Drawing.Point(463, 13);
            this.LabelNombreEmpleado.Name = "LabelNombreEmpleado";
            this.LabelNombreEmpleado.Size = new System.Drawing.Size(35, 13);
            this.LabelNombreEmpleado.TabIndex = 35;
            this.LabelNombreEmpleado.Text = "label7";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(101, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 16);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Codigo compra:";
            // 
            // TxtCodigoCompra
            // 
            this.TxtCodigoCompra.Location = new System.Drawing.Point(210, 8);
            this.TxtCodigoCompra.MaxLength = 10;
            this.TxtCodigoCompra.Name = "TxtCodigoCompra";
            this.TxtCodigoCompra.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoCompra.TabIndex = 40;
            this.TxtCodigoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoCompra_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLimpiarP);
            this.groupBox1.Controls.Add(this.BtnConsultarProveedor);
            this.groupBox1.Controls.Add(this.TxtNombreProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 85);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle proveedor";
            // 
            // BtnLimpiarP
            // 
            this.BtnLimpiarP.Location = new System.Drawing.Point(459, 36);
            this.BtnLimpiarP.Name = "BtnLimpiarP";
            this.BtnLimpiarP.Size = new System.Drawing.Size(75, 36);
            this.BtnLimpiarP.TabIndex = 43;
            this.BtnLimpiarP.Text = "Limpiar";
            this.BtnLimpiarP.UseVisualStyleBackColor = true;
            // 
            // BtnConsultarProveedor
            // 
            this.BtnConsultarProveedor.Location = new System.Drawing.Point(3, 52);
            this.BtnConsultarProveedor.Name = "BtnConsultarProveedor";
            this.BtnConsultarProveedor.Size = new System.Drawing.Size(75, 27);
            this.BtnConsultarProveedor.TabIndex = 42;
            this.BtnConsultarProveedor.Text = "Consultar";
            this.BtnConsultarProveedor.UseVisualStyleBackColor = true;
            this.BtnConsultarProveedor.Click += new System.EventHandler(this.BtnConsultarProveedor_Click);
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.Location = new System.Drawing.Point(294, 21);
            this.TxtNombreProveedor.Multiline = true;
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.ReadOnly = true;
            this.TxtNombreProveedor.Size = new System.Drawing.Size(134, 51);
            this.TxtNombreProveedor.TabIndex = 44;
            this.TxtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(121, 21);
            this.TxtID.MaxLength = 10;
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 22);
            this.TxtID.TabIndex = 42;
            this.TxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtPrecioCompra);
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtNombreProducto);
            this.groupBox2.Controls.Add(this.TxtCodigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 149);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Productos";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(228, 102);
            this.TxtCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(120, 22);
            this.TxtCantidad.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Ingrese la cantidad que comprara:";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(287, 39);
            this.TxtNombreProducto.Multiline = true;
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(141, 36);
            this.TxtNombreProducto.TabIndex = 43;
            this.TxtNombreProducto.TextChanged += new System.EventHandler(this.TxtNombreProducto_TextChanged);
            this.TxtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreProducto_KeyPress);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(75, 37);
            this.TxtCodigo.MaxLength = 10;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 22);
            this.TxtCodigo.TabIndex = 43;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio compra $:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo";
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToResizeColumns = false;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_compra,
            this.Codigo_producto,
            this.Nombre,
            this.Precio_compra,
            this.Cantidad,
            this.Monto});
            this.Dgv.Location = new System.Drawing.Point(29, 324);
            this.Dgv.Name = "Dgv";
            this.Dgv.Size = new System.Drawing.Size(669, 134);
            this.Dgv.TabIndex = 43;
            // 
            // Codigo_compra
            // 
            this.Codigo_compra.HeaderText = "Codigo de Compra";
            this.Codigo_compra.Name = "Codigo_compra";
            // 
            // Codigo_producto
            // 
            this.Codigo_producto.HeaderText = "Codigo de producto";
            this.Codigo_producto.Name = "Codigo_producto";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio_compra
            // 
            this.Precio_compra.HeaderText = "Precio de compra";
            this.Precio_compra.Name = "Precio_compra";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(29, 305);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(128, 16);
            this.linkLabel4.TabIndex = 44;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "DETALLE COMPRA";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.Location = new System.Drawing.Point(26, 489);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(125, 16);
            this.linkLabel5.TabIndex = 45;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "TOTAL COMPRA $:";
            // 
            // TxtTotalCompra
            // 
            this.TxtTotalCompra.Location = new System.Drawing.Point(150, 488);
            this.TxtTotalCompra.Name = "TxtTotalCompra";
            this.TxtTotalCompra.ReadOnly = true;
            this.TxtTotalCompra.Size = new System.Drawing.Size(105, 20);
            this.TxtTotalCompra.TabIndex = 46;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(722, 244);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 49);
            this.BtnAgregar.TabIndex = 47;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(722, 339);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 35);
            this.BtnEditar.TabIndex = 48;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(722, 380);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 36);
            this.BtnEliminar.TabIndex = 49;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(722, 422);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 36);
            this.BtnCancelar.TabIndex = 50;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnTerminarCompra
            // 
            this.BtnTerminarCompra.Location = new System.Drawing.Point(585, 479);
            this.BtnTerminarCompra.Name = "BtnTerminarCompra";
            this.BtnTerminarCompra.Size = new System.Drawing.Size(131, 34);
            this.BtnTerminarCompra.TabIndex = 51;
            this.BtnTerminarCompra.Text = "Terminar Compra";
            this.BtnTerminarCompra.UseVisualStyleBackColor = true;
            this.BtnTerminarCompra.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 8);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(71, 20);
            this.btnMenu.TabIndex = 52;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Location = new System.Drawing.Point(567, 37);
            this.TxtPrecioCompra.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(102, 22);
            this.TxtPrecioCompra.TabIndex = 53;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 530);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.BtnTerminarCompra);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtTotalCompra);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtCodigoCompra);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.LabelNombreEmpleado);
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label LabelNombreEmpleado;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox TxtCodigoCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConsultarProveedor;
        private System.Windows.Forms.Button BtnLimpiarP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.TextBox TxtTotalCompra;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnTerminarCompra;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.NumericUpDown TxtPrecioCompra;
    }
}
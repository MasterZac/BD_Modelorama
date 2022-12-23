namespace BD_Modelorama
{
    partial class Historial_ventas_y_productos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.LabelNombreEmpleado = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.DgvAparece = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxVentas = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar2 = new System.Windows.Forms.Button();
            this.TxtBuscarAparece = new System.Windows.Forms.TextBox();
            this.comboBoxAparece = new System.Windows.Forms.ComboBox();
            this.BtnLimpiarAparece = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAparece)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(180, 452);
            this.panel1.TabIndex = 46;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(0, 173);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(158, 39);
            this.BtnMenu.TabIndex = 62;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(12, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(128, 16);
            this.linkLabel2.TabIndex = 40;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Empleado activo:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.Black;
            this.labelFecha.Location = new System.Drawing.Point(12, 114);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(41, 13);
            this.labelFecha.TabIndex = 42;
            this.labelFecha.Text = "label6";
            // 
            // LabelNombreEmpleado
            // 
            this.LabelNombreEmpleado.AutoSize = true;
            this.LabelNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreEmpleado.ForeColor = System.Drawing.Color.Black;
            this.LabelNombreEmpleado.Location = new System.Drawing.Point(12, 38);
            this.LabelNombreEmpleado.Name = "LabelNombreEmpleado";
            this.LabelNombreEmpleado.Size = new System.Drawing.Size(41, 13);
            this.LabelNombreEmpleado.TabIndex = 39;
            this.LabelNombreEmpleado.Text = "label7";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(12, 75);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(111, 18);
            this.linkLabel3.TabIndex = 41;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Fecha / Hora:";
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.AllowUserToDeleteRows = false;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Location = new System.Drawing.Point(210, 74);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.ReadOnly = true;
            this.DgvVentas.Size = new System.Drawing.Size(524, 138);
            this.DgvVentas.TabIndex = 47;
            // 
            // DgvAparece
            // 
            this.DgvAparece.AllowUserToAddRows = false;
            this.DgvAparece.AllowUserToDeleteRows = false;
            this.DgvAparece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAparece.Location = new System.Drawing.Point(210, 302);
            this.DgvAparece.Name = "DgvAparece";
            this.DgvAparece.ReadOnly = true;
            this.DgvAparece.Size = new System.Drawing.Size(524, 138);
            this.DgvAparece.TabIndex = 48;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(427, 47);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(129, 21);
            this.TxtBuscar.TabIndex = 154;
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // comboBoxVentas
            // 
            this.comboBoxVentas.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVentas.ForeColor = System.Drawing.Color.Teal;
            this.comboBoxVentas.FormattingEnabled = true;
            this.comboBoxVentas.Items.AddRange(new object[] {
            "Codigo_venta",
            "Curp_empleado",
            "Dni_cliente",
            "Monto_final"});
            this.comboBoxVentas.Location = new System.Drawing.Point(289, 45);
            this.comboBoxVentas.Name = "comboBoxVentas";
            this.comboBoxVentas.Size = new System.Drawing.Size(121, 23);
            this.comboBoxVentas.TabIndex = 153;
            this.comboBoxVentas.Text = "Consultar por:";
            // 
            // BtnLimpiar2
            // 
            this.BtnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar2.Location = new System.Drawing.Point(595, 47);
            this.BtnLimpiar2.Name = "BtnLimpiar2";
            this.BtnLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar2.TabIndex = 152;
            this.BtnLimpiar2.Text = "Limpiar";
            this.BtnLimpiar2.UseVisualStyleBackColor = true;
            this.BtnLimpiar2.Click += new System.EventHandler(this.BtnLimpiar2_Click);
            // 
            // TxtBuscarAparece
            // 
            this.TxtBuscarAparece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarAparece.Location = new System.Drawing.Point(440, 275);
            this.TxtBuscarAparece.Name = "TxtBuscarAparece";
            this.TxtBuscarAparece.Size = new System.Drawing.Size(129, 21);
            this.TxtBuscarAparece.TabIndex = 157;
            this.TxtBuscarAparece.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscarAparece_KeyUp);
            // 
            // comboBoxAparece
            // 
            this.comboBoxAparece.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxAparece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAparece.ForeColor = System.Drawing.Color.Teal;
            this.comboBoxAparece.FormattingEnabled = true;
            this.comboBoxAparece.Items.AddRange(new object[] {
            "Codigo_venta",
            "Codigo_producto",
            "Nombre",
            "Cantidad",
            "Precio",
            "Monto"});
            this.comboBoxAparece.Location = new System.Drawing.Point(302, 273);
            this.comboBoxAparece.Name = "comboBoxAparece";
            this.comboBoxAparece.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAparece.TabIndex = 156;
            this.comboBoxAparece.Text = "Consultar por:";
            // 
            // BtnLimpiarAparece
            // 
            this.BtnLimpiarAparece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarAparece.Location = new System.Drawing.Point(608, 275);
            this.BtnLimpiarAparece.Name = "BtnLimpiarAparece";
            this.BtnLimpiarAparece.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiarAparece.TabIndex = 155;
            this.BtnLimpiarAparece.Text = "Limpiar";
            this.BtnLimpiarAparece.UseVisualStyleBackColor = true;
            this.BtnLimpiarAparece.Click += new System.EventHandler(this.BtnLimpiarAparece_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(254, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 16);
            this.linkLabel1.TabIndex = 158;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "VENTAS REALIZADAS";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(258, 241);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(312, 16);
            this.linkLabel4.TabIndex = 159;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "PRODUCTOS AGREGADOS A LAS VENTAS";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Historial_ventas_y_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 452);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TxtBuscarAparece);
            this.Controls.Add(this.comboBoxAparece);
            this.Controls.Add(this.BtnLimpiarAparece);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.comboBoxVentas);
            this.Controls.Add(this.BtnLimpiar2);
            this.Controls.Add(this.DgvAparece);
            this.Controls.Add(this.DgvVentas);
            this.Controls.Add(this.panel1);
            this.Name = "Historial_ventas_y_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial_ventas_productos";
            this.Load += new System.EventHandler(this.Historial_ventas_y_productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAparece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label LabelNombreEmpleado;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.DataGridView DgvAparece;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox comboBoxVentas;
        private System.Windows.Forms.Button BtnLimpiar2;
        private System.Windows.Forms.TextBox TxtBuscarAparece;
        private System.Windows.Forms.ComboBox comboBoxAparece;
        private System.Windows.Forms.Button BtnLimpiarAparece;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Timer timer;
    }
}
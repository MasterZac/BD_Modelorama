namespace BD_Modelorama
{
    partial class Cortes_de_caja
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxcorte = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar2 = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(180, 285);
            this.panel1.TabIndex = 47;
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
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(416, 48);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(129, 21);
            this.TxtBuscar.TabIndex = 158;
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // comboBoxcorte
            // 
            this.comboBoxcorte.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxcorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxcorte.ForeColor = System.Drawing.Color.Teal;
            this.comboBoxcorte.FormattingEnabled = true;
            this.comboBoxcorte.Items.AddRange(new object[] {
            "ID",
            "Curp_empleado ",
            "Ventas",
            "Total_ventas"});
            this.comboBoxcorte.Location = new System.Drawing.Point(278, 46);
            this.comboBoxcorte.Name = "comboBoxcorte";
            this.comboBoxcorte.Size = new System.Drawing.Size(121, 23);
            this.comboBoxcorte.TabIndex = 157;
            this.comboBoxcorte.Text = "Consultar por:";
            // 
            // BtnLimpiar2
            // 
            this.BtnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar2.Location = new System.Drawing.Point(584, 48);
            this.BtnLimpiar2.Name = "BtnLimpiar2";
            this.BtnLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar2.TabIndex = 156;
            this.BtnLimpiar2.Text = "Limpiar";
            this.BtnLimpiar2.UseVisualStyleBackColor = true;
            this.BtnLimpiar2.Click += new System.EventHandler(this.BtnLimpiar2_Click);
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(199, 75);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.Size = new System.Drawing.Size(524, 138);
            this.Dgv.TabIndex = 155;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Cortes_de_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 285);
            this.ControlBox = false;
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.comboBoxcorte);
            this.Controls.Add(this.BtnLimpiar2);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.panel1);
            this.Name = "Cortes_de_caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cortes_de_caja";
            this.Load += new System.EventHandler(this.Cortes_de_caja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
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
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox comboBoxcorte;
        private System.Windows.Forms.Button BtnLimpiar2;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Timer timer;
    }
}
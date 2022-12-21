namespace BD_Modelorama
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PROVEEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADEENTRADASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelNombreEmpleado = new System.Windows.Forms.Label();
            this.LabelPuesto = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.rEGISTRARVENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASREALIZADASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cORTESDECAJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.labelFecha);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 67);
            this.panel1.TabIndex = 0;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(186, 54);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(35, 13);
            this.labelFecha.TabIndex = 27;
            this.labelFecha.Text = "label2";
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(480, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(72, 40);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(402, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(72, 40);
            this.BtnRegresar.TabIndex = 2;
            this.BtnRegresar.Text = "Inicar sesion";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelorama";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EMPLEADOSToolStripMenuItem,
            this.CLIENTESToolStripMenuItem,
            this.PROVEEDORToolStripMenuItem,
            this.PRODUCTOSToolStripMenuItem,
            this.VENTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 67);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EMPLEADOSToolStripMenuItem
            // 
            this.EMPLEADOSToolStripMenuItem.Name = "EMPLEADOSToolStripMenuItem";
            this.EMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.EMPLEADOSToolStripMenuItem.Text = "EMPLEADOS";
            this.EMPLEADOSToolStripMenuItem.Click += new System.EventHandler(this.EMPLEADOSToolStripMenuItem_Click);
            // 
            // CLIENTESToolStripMenuItem
            // 
            this.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem";
            this.CLIENTESToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.CLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.CLIENTESToolStripMenuItem.Click += new System.EventHandler(this.CLIENTESToolStripMenuItem_Click);
            // 
            // PROVEEDORToolStripMenuItem
            // 
            this.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem";
            this.PROVEEDORToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR";
            this.PROVEEDORToolStripMenuItem.Click += new System.EventHandler(this.PROVEEDORToolStripMenuItem_Click);
            // 
            // PRODUCTOSToolStripMenuItem
            // 
            this.PRODUCTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRASToolStripMenuItem,
            this.registroDeProductosToolStripMenuItem,
            this.lISTADEENTRADASToolStripMenuItem});
            this.PRODUCTOSToolStripMenuItem.Name = "PRODUCTOSToolStripMenuItem";
            this.PRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.PRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.cOMPRASToolStripMenuItem.Text = "COMPRAR PRODUCTOS";
            this.cOMPRASToolStripMenuItem.Click += new System.EventHandler(this.cOMPRASToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.registroDeProductosToolStripMenuItem.Text = "REGISTRO PRODUCTOS";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // lISTADEENTRADASToolStripMenuItem
            // 
            this.lISTADEENTRADASToolStripMenuItem.Name = "lISTADEENTRADASToolStripMenuItem";
            this.lISTADEENTRADASToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.lISTADEENTRADASToolStripMenuItem.Text = "LISTA DE ENTRADAS";
            this.lISTADEENTRADASToolStripMenuItem.Click += new System.EventHandler(this.lISTADEENTRADASToolStripMenuItem_Click);
            // 
            // VENTASToolStripMenuItem
            // 
            this.VENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRARVENTAToolStripMenuItem,
            this.vENTASREALIZADASToolStripMenuItem,
            this.cORTESDECAJAToolStripMenuItem});
            this.VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem";
            this.VENTASToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.VENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // LabelNombreEmpleado
            // 
            this.LabelNombreEmpleado.AutoSize = true;
            this.LabelNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreEmpleado.Location = new System.Drawing.Point(115, 234);
            this.LabelNombreEmpleado.Name = "LabelNombreEmpleado";
            this.LabelNombreEmpleado.Size = new System.Drawing.Size(119, 16);
            this.LabelNombreEmpleado.TabIndex = 5;
            this.LabelNombreEmpleado.Text = "NombreEmpleado";
            // 
            // LabelPuesto
            // 
            this.LabelPuesto.AutoSize = true;
            this.LabelPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPuesto.Location = new System.Drawing.Point(332, 234);
            this.LabelPuesto.Name = "LabelPuesto";
            this.LabelPuesto.Size = new System.Drawing.Size(44, 16);
            this.LabelPuesto.TabIndex = 7;
            this.LabelPuesto.Text = "label4";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(-3, 231);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 16);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Empleado activo:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(274, 234);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 16);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Puesto:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // rEGISTRARVENTAToolStripMenuItem
            // 
            this.rEGISTRARVENTAToolStripMenuItem.Name = "rEGISTRARVENTAToolStripMenuItem";
            this.rEGISTRARVENTAToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.rEGISTRARVENTAToolStripMenuItem.Text = "REGISTRAR VENTA";
            // 
            // vENTASREALIZADASToolStripMenuItem
            // 
            this.vENTASREALIZADASToolStripMenuItem.Name = "vENTASREALIZADASToolStripMenuItem";
            this.vENTASREALIZADASToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.vENTASREALIZADASToolStripMenuItem.Text = "HISTORIAL VENTAS Y PRODUCTOS";
            // 
            // cORTESDECAJAToolStripMenuItem
            // 
            this.cORTESDECAJAToolStripMenuItem.Name = "cORTESDECAJAToolStripMenuItem";
            this.cORTESDECAJAToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.cORTESDECAJAToolStripMenuItem.Text = "CORTES DE CAJA";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 256);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.LabelPuesto);
            this.Controls.Add(this.LabelNombreEmpleado);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PROVEEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VENTASToolStripMenuItem;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LabelNombreEmpleado;
        private System.Windows.Forms.Label LabelPuesto;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem lISTADEENTRADASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARVENTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASREALIZADASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cORTESDECAJAToolStripMenuItem;
    }
}


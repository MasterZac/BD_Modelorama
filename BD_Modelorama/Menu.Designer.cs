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
            this.rEGISTRODEEMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PROVEEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADEENTRADASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRARVENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASREALIZADASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cORTESDECAJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelNombreEmpleado = new System.Windows.Forms.Label();
            this.LabelPuesto = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabLOG = new System.Windows.Forms.TabControl();
            this.LOG = new System.Windows.Forms.TabPage();
            this.DgvLOG = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxLOG = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar2 = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.labelcurp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabLOG.SuspendLayout();
            this.LOG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLOG)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(597, 67);
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
            this.BtnRegresar.Text = "Inicio de sesión";
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
            this.menuStrip1.Size = new System.Drawing.Size(597, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EMPLEADOSToolStripMenuItem
            // 
            this.EMPLEADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRODEEMPLEADOSToolStripMenuItem,
            this.lOGToolStripMenuItem});
            this.EMPLEADOSToolStripMenuItem.Name = "EMPLEADOSToolStripMenuItem";
            this.EMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.EMPLEADOSToolStripMenuItem.Text = "EMPLEADOS";
            this.EMPLEADOSToolStripMenuItem.Click += new System.EventHandler(this.EMPLEADOSToolStripMenuItem_Click);
            // 
            // rEGISTRODEEMPLEADOSToolStripMenuItem
            // 
            this.rEGISTRODEEMPLEADOSToolStripMenuItem.Name = "rEGISTRODEEMPLEADOSToolStripMenuItem";
            this.rEGISTRODEEMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.rEGISTRODEEMPLEADOSToolStripMenuItem.Text = "REGISTRO DE EMPLEADOS";
            this.rEGISTRODEEMPLEADOSToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRODEEMPLEADOSToolStripMenuItem_Click);
            // 
            // lOGToolStripMenuItem
            // 
            this.lOGToolStripMenuItem.Name = "lOGToolStripMenuItem";
            this.lOGToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.lOGToolStripMenuItem.Text = "LOG";
            this.lOGToolStripMenuItem.Click += new System.EventHandler(this.lOGToolStripMenuItem_Click);
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
            // rEGISTRARVENTAToolStripMenuItem
            // 
            this.rEGISTRARVENTAToolStripMenuItem.Name = "rEGISTRARVENTAToolStripMenuItem";
            this.rEGISTRARVENTAToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.rEGISTRARVENTAToolStripMenuItem.Text = "REGISTRAR VENTA";
            this.rEGISTRARVENTAToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRARVENTAToolStripMenuItem_Click);
            // 
            // vENTASREALIZADASToolStripMenuItem
            // 
            this.vENTASREALIZADASToolStripMenuItem.Name = "vENTASREALIZADASToolStripMenuItem";
            this.vENTASREALIZADASToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.vENTASREALIZADASToolStripMenuItem.Text = "HISTORIAL VENTAS Y PRODUCTOS";
            this.vENTASREALIZADASToolStripMenuItem.Click += new System.EventHandler(this.vENTASREALIZADASToolStripMenuItem_Click);
            // 
            // cORTESDECAJAToolStripMenuItem
            // 
            this.cORTESDECAJAToolStripMenuItem.Name = "cORTESDECAJAToolStripMenuItem";
            this.cORTESDECAJAToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.cORTESDECAJAToolStripMenuItem.Text = "CORTES DE CAJA";
            this.cORTESDECAJAToolStripMenuItem.Click += new System.EventHandler(this.cORTESDECAJAToolStripMenuItem_Click);
            // 
            // LabelNombreEmpleado
            // 
            this.LabelNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelNombreEmpleado.AutoSize = true;
            this.LabelNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreEmpleado.Location = new System.Drawing.Point(293, 311);
            this.LabelNombreEmpleado.Name = "LabelNombreEmpleado";
            this.LabelNombreEmpleado.Size = new System.Drawing.Size(119, 16);
            this.LabelNombreEmpleado.TabIndex = 5;
            this.LabelNombreEmpleado.Text = "NombreEmpleado";
            // 
            // LabelPuesto
            // 
            this.LabelPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPuesto.AutoSize = true;
            this.LabelPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPuesto.Location = new System.Drawing.Point(510, 311);
            this.LabelPuesto.Name = "LabelPuesto";
            this.LabelPuesto.Size = new System.Drawing.Size(44, 16);
            this.LabelPuesto.TabIndex = 7;
            this.LabelPuesto.Text = "label4";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(175, 308);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 16);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Empleado activo:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(452, 311);
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
            // tabLOG
            // 
            this.tabLOG.Controls.Add(this.LOG);
            this.tabLOG.Location = new System.Drawing.Point(40, 113);
            this.tabLOG.Name = "tabLOG";
            this.tabLOG.SelectedIndex = 0;
            this.tabLOG.Size = new System.Drawing.Size(494, 181);
            this.tabLOG.TabIndex = 27;
            this.tabLOG.Visible = false;
            // 
            // LOG
            // 
            this.LOG.Controls.Add(this.TxtBuscar);
            this.LOG.Controls.Add(this.comboBoxLOG);
            this.LOG.Controls.Add(this.BtnLimpiar2);
            this.LOG.Controls.Add(this.DgvLOG);
            this.LOG.Location = new System.Drawing.Point(4, 22);
            this.LOG.Name = "LOG";
            this.LOG.Padding = new System.Windows.Forms.Padding(3);
            this.LOG.Size = new System.Drawing.Size(486, 155);
            this.LOG.TabIndex = 0;
            this.LOG.Text = "LOG";
            this.LOG.UseVisualStyleBackColor = true;
            // 
            // DgvLOG
            // 
            this.DgvLOG.AllowUserToAddRows = false;
            this.DgvLOG.AllowUserToDeleteRows = false;
            this.DgvLOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLOG.Location = new System.Drawing.Point(6, 46);
            this.DgvLOG.Name = "DgvLOG";
            this.DgvLOG.ReadOnly = true;
            this.DgvLOG.Size = new System.Drawing.Size(464, 103);
            this.DgvLOG.TabIndex = 0;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(194, 19);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(129, 21);
            this.TxtBuscar.TabIndex = 151;
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // comboBoxLOG
            // 
            this.comboBoxLOG.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxLOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLOG.ForeColor = System.Drawing.Color.Teal;
            this.comboBoxLOG.FormattingEnabled = true;
            this.comboBoxLOG.Items.AddRange(new object[] {
            "ID",
            "Curp_empleado"});
            this.comboBoxLOG.Location = new System.Drawing.Point(56, 17);
            this.comboBoxLOG.Name = "comboBoxLOG";
            this.comboBoxLOG.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLOG.TabIndex = 150;
            this.comboBoxLOG.Text = "Consultar por:";
            // 
            // BtnLimpiar2
            // 
            this.BtnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar2.Location = new System.Drawing.Point(362, 19);
            this.BtnLimpiar2.Name = "BtnLimpiar2";
            this.BtnLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar2.TabIndex = 149;
            this.BtnLimpiar2.Text = "Limpiar";
            this.BtnLimpiar2.UseVisualStyleBackColor = true;
            this.BtnLimpiar2.Click += new System.EventHandler(this.BtnLimpiar2_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(12, 308);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(48, 16);
            this.linkLabel3.TabIndex = 29;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "CURP:";
            // 
            // labelcurp
            // 
            this.labelcurp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelcurp.AutoSize = true;
            this.labelcurp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcurp.Location = new System.Drawing.Point(70, 308);
            this.labelcurp.Name = "labelcurp";
            this.labelcurp.Size = new System.Drawing.Size(44, 16);
            this.labelcurp.TabIndex = 28;
            this.labelcurp.Text = "label4";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 333);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.labelcurp);
            this.Controls.Add(this.tabLOG);
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
            this.tabLOG.ResumeLayout(false);
            this.LOG.ResumeLayout(false);
            this.LOG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLOG)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem rEGISTRODEEMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGToolStripMenuItem;
        private System.Windows.Forms.TabControl tabLOG;
        private System.Windows.Forms.TabPage LOG;
        private System.Windows.Forms.DataGridView DgvLOG;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox comboBoxLOG;
        private System.Windows.Forms.Button BtnLimpiar2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label labelcurp;
    }
}


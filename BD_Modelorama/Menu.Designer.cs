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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.BtnRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 67);
            this.panel1.TabIndex = 0;
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
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(479, 12);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(72, 33);
            this.BtnRegresar.TabIndex = 2;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(582, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPLEADOSToolStripMenuItem,
            this.cLIENTESToolStripMenuItem,
            this.pROVEEDORToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem,
            this.vENTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 67);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eMPLEADOSToolStripMenuItem
            // 
            this.eMPLEADOSToolStripMenuItem.Name = "eMPLEADOSToolStripMenuItem";
            this.eMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.eMPLEADOSToolStripMenuItem.Text = "EMPLEADOS";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // pROVEEDORToolStripMenuItem
            // 
            this.pROVEEDORToolStripMenuItem.Name = "pROVEEDORToolStripMenuItem";
            this.pROVEEDORToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pROVEEDORToolStripMenuItem.Text = "PROVEEDOR";
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRASToolStripMenuItem,
            this.registroDeProductosToolStripMenuItem});
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cOMPRASToolStripMenuItem.Text = "COMPRAS";
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.registroDeProductosToolStripMenuItem.Text = "REGISTRO PRODUCTOS";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
    }
}


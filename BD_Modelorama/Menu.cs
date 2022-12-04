using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Modelorama
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados x = new Empleados();
            this.Hide();
            x.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BD_Modelorama
{
    public partial class Menu : Form
    {

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rd;

        public string NombreTrabajador;
        public string Rol;

        public Menu()
        {
            InitializeComponent();
        }

        public void Conectar()
        {
            cnn.ConnectionString = "Server = localhost; Database = bd_modelorama; user = root; password = root";
            cnn.Open();
        }

        public void Desconectar()
        {
            cnn.Close();
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados x = new Empleados();
            x.empleado = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ConsultaPuestoEmpleado()
        {
            try
            {
                Conectar();
                string query = "Select Puesto From empleado Where Nombre = ('" + LabelNombreEmpleado.Text + "'); ";
                cmd = new MySqlCommand(query, cnn);
                cmd.CommandType = CommandType.Text;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    LabelPuesto.Text = rd[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = string.Format("{0}", NombreTrabajador);
            ConsultaPuestoEmpleado();
            if (LabelPuesto.Text == "Vendedor")
            {
                EMPLEADOSToolStripMenuItem.Enabled = false;
                CLIENTESToolStripMenuItem.Enabled = false;
                PROVEEDORToolStripMenuItem.Enabled = false;
                PRODUCTOSToolStripMenuItem.Enabled = false;

            }
            
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            LOGIN x = new LOGIN();
            this.Hide();
            x.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }

        private void CLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes x = new Clientes();
            x.nombre = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        private void PROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor x = new Proveedor();
            x.nombre = LabelNombreEmpleado.Text;
            x.Show();
            this.Hide();
            
        }
    }
}

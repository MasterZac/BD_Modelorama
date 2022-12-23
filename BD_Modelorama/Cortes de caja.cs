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
    public partial class Cortes_de_caja : Form
    {
        public Cortes_de_caja()
        {
            InitializeComponent();
        }

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da;
        DataTable table;
        MySqlDataReader rd;

        public string empleado;

        public void Conectar()
        {
            cnn.ConnectionString = "Server = localhost; Database = bd_modelorama; user = root; password = root";
            cnn.Open();
        }

        public void Desconectar()
        {
            cnn.Close();
        }

        public void CargarCorte()
        {
            try
            {
                Conectar();
                string consultar = "Select * From corte";
                cmd = new MySqlCommand(consultar, cnn);
                cmd.CommandType = CommandType.Text;
                table = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(table);
                Dgv.DataSource = table;

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

        public void ConsultarCorte()
        {
            try
            {
                Conectar();
                string Consultar = "Select * From corte Where (" + comboBoxcorte.Text + ") Like ('" + TxtBuscar.Text + "%')";
                cmd = new MySqlCommand(Consultar, cnn);
                cmd.CommandType = CommandType.Text;
                table = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(table);
                Dgv.DataSource = table;

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

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.NombreTrabajador = LabelNombreEmpleado.Text;
            this.Hide();
            form.Show();
        }

        private void Cortes_de_caja_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = empleado;
            CargarCorte();
        }

        private void BtnLimpiar2_Click(object sender, EventArgs e)
        {
            TxtBuscar.Clear();
            CargarCorte();
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ConsultarCorte();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }
    }
}

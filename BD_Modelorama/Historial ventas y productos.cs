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
    public partial class Historial_ventas_y_productos : Form
    {
        public Historial_ventas_y_productos()
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


        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.NombreTrabajador = LabelNombreEmpleado.Text;
            this.Hide();
            form.Show();
        }

        public void CargarVentas()
        {
            try
            {
                Conectar();
                string consultar = "Select * From venta";
                cmd = new MySqlCommand(consultar, cnn);
                cmd.CommandType = CommandType.Text;

                table = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(table);
                DgvVentas.DataSource = table;
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

        public void CargarAparece()
        {
            try
            {
                Conectar();
                string consultar = "Select * From aparece";
                cmd = new MySqlCommand(consultar, cnn);
                cmd.CommandType = CommandType.Text;

                table = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(table);
                DgvAparece.DataSource = table;
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

        public void ConsultarVentas()
        {
            try
            {
                Conectar();
                string Consultar = "Select * From venta Where (" + comboBoxVentas.Text + ") Like ('" + TxtBuscar.Text + "%')";
                cmd = new MySqlCommand(Consultar, cnn);
                cmd.CommandType = CommandType.Text;
                table = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(table);
                DgvVentas.DataSource = table;

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

        public void ConsultarAparece()
        {
            try
            {
                Conectar();
                string Consultar = "Select * From aparece Where (" + comboBoxAparece.Text + ") Like ('" + TxtBuscarAparece.Text + "%')";
                cmd = new MySqlCommand(Consultar, cnn);
                cmd.CommandType = CommandType.Text;
                table = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(table);
                DgvAparece.DataSource = table;

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

        private void Historial_ventas_y_productos_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = empleado;
            CargarVentas();
            CargarAparece();
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBoxVentas.SelectedIndex < 0)
            {
                MessageBox.Show("Elige por que quiere consultar");
            }
            else
            {
                ConsultarVentas();
            }
        }

        private void TxtBuscarAparece_KeyUp(object sender, KeyEventArgs e)
        {
            ConsultarAparece();
        }

        private void BtnLimpiar2_Click(object sender, EventArgs e)
        {
            TxtBuscar.Clear();
            CargarVentas();
        }

        private void BtnLimpiarAparece_Click(object sender, EventArgs e)
        {
            TxtBuscarAparece.Clear();
            CargarVentas();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }
    }
}

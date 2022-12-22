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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da;
        MySqlDataReader rd;
        DataTable table;

        public string nombreEmpleado;

        public void Conectar()
        {
            cnn.ConnectionString = "Server = localhost; Database = bd_modelorama; user = root; password = root";
            cnn.Open();
        }

        public void Desconectar()
        {
            cnn.Close();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = nombreEmpleado;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }

        private void BtnConsultarC_Click(object sender, EventArgs e)
        {
            if (Txtdni.Text == "")
            {
                MessageBox.Show("Ingresa el dni del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("ConsultaCliente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter dni = new MySqlParameter("_dni", MySqlDbType.VarChar, 15);
                dni.Value = Txtdni.Text;
                cmd.Parameters.Add(dni);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    TxtNombre.Text = rd[1].ToString();
                }
                else
                {
                    MessageBox.Show("No hay registros de ese cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnConsultarP_Click(object sender, EventArgs e)
        {

        }
    }
}

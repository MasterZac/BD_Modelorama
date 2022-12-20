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
    public partial class Registro_productos : Form
    {
        public Registro_productos()
        {
            InitializeComponent();
        }

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rd;
        MySqlDataAdapter da;
        DataTable table;

        public void Conectar()
        {
            cnn.ConnectionString = "Server = localhost; Database = bd_modelorama; user = root; password = root";
            cnn.Open();
        }

        public void Desconectar()
        {
            cnn.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }


        public string Nombre_empleado;
        private void Registro_productos_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = Nombre_empleado;
            cargarProductosComprados();
        }

        public void cargarProductosComprados()
        {
            try
            {
                Conectar();
                string consultar = "Select * From tiene";
                cmd = new MySqlCommand(consultar, cnn);
                cmd.CommandType = CommandType.Text;

                table = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(table);
                DgvListadoProductos.DataSource = table;
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
            Menu x = new Menu();
            x.NombreTrabajador = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }
    }
}

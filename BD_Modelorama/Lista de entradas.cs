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
    public partial class Lista_de_entradas : Form
    {
        public Lista_de_entradas()
        {
            InitializeComponent();
        }

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da;
        DataTable table;
        public string nombreempleado;

        public void Conectar()
        {
            cnn.ConnectionString = "Server = localhost; Database = bd_modelorama; user = root; password = root";
            cnn.Open();
        }

        public void Desconectar()
        {
            cnn.Close();
        }
        private void Lista_de_entradas_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = nombreempleado;
            CargarListaEntradas();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }

        public void CargarListaEntradas()
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("ListaEntradas", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new MySqlDataAdapter(cmd);
                table = new DataTable();
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

        public void ConsultarEntradas()
        {
            try
            {
                Conectar();
                string Consultar = "Select compras.*, tiene.Codigo_producto, tiene.Nombre, tiene.Cantidad, tiene.Precio_compra, tiene.Monto_compra From compras, tiene " +
                    "Where compras.Codigo = tiene.Codigo_compra and (" + CmbEntradas.Text + ") Like ('" + TxtBuscarEntradas.Text + "%')";
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
            Menu x = new Menu();
            x.NombreTrabajador = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        private void TxtBuscarEntradas_KeyUp(object sender, KeyEventArgs e)
        {
            if (CmbEntradas.SelectedIndex < 0)
            {
                MessageBox.Show("Eliga por que quiere consultar", "Mensjae", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                ConsultarEntradas();
            }
        }
    }
}

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
            ConsultarDni();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }
        
        public void ConsultarDni()
        {
            try
            {
                Conectar();
                string consultar = "Select Curp From empleado Where Nombre = ('" + LabelNombreEmpleado.Text + "')";
                cmd = new MySqlCommand(consultar, cnn);
                cmd.CommandType = CommandType.Text;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    labelEmpleado.Text = rd[0].ToString();
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
            if (TxtCodigo.Text == "")
            {
                MessageBox.Show("Ingresa el codigo del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("ConsultaProducto", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter codigo = new MySqlParameter("ConsultaProductos", cnn);
                codigo.Value = TxtCodigo.Text;
                cmd.Parameters.Add(codigo);

                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    string estatus = rd[5].ToString();
                    if (estatus == "Activo")
                    {
                        TxtNombreP.Text = rd[1].ToString();
                        TxtPrecioVenta.Text = rd[3].ToString();
                        TxtStock.Text = rd[4].ToString();
                    }
                    else if (estatus == "Inactivo")
                    {
                        MessageBox.Show("El producto no se encuentra activo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro registros de ese producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnLimpiarP_Click(object sender, EventArgs e)
        {
            TxtCodigo.Clear();
            TxtNombreP.Clear();
            TxtPrecioVenta.Clear();
            TxtStock.Clear();
            TxtCodigo.Focus();
        }

        private void BtnLimpiarC_Click(object sender, EventArgs e)
        {
            Txtdni.Clear(); TxtNombre.Clear(); Txtdni.Focus();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.NombreTrabajador = LabelNombreEmpleado.Text;
            this.Hide();
            form.Show();
        }
    }
}

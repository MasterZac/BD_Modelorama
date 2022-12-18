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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rd;

        public void Conectar()
        {
            cnn.ConnectionString = "Server = localhost; Database = bd_modelorama; user = root; password = root";
            cnn.Open();
        }

        public void Desconectar()
        {
            cnn.Close();
        }

        public string nombreEmpleado;

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = nombreEmpleado;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.NombreTrabajador = LabelNombreEmpleado.Text;
            this.Hide();
            form.Show();
        }

        private void BtnConsultarProveedor_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Ingresa el id del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("ConsultaProveedor", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter id = new MySqlParameter("_id", MySqlDbType.VarChar, 15);
                id.Value = TxtID.Text;
                cmd.Parameters.Add(id);

                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    TxtNombreProveedor.Text = rd[1].ToString();
                }
                else
                {
                    MessageBox.Show("Proveedor no existente");
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


        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no permitido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        public bool ProductoAgregado()
        {

            bool respuesta = false;
            string Codigo_p = TxtCodigo.Text;
            if (Dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in Dgv.Rows)
                {
                    if (fila.Cells["Codigo_producto"].Value.ToString() == Convert.ToString(Codigo_p))
                    {
                        respuesta = true;
                        break;
                    }
                }
            }
            return respuesta;

        }

        private void calcularTotal()
        {
            double total = 0;
            try
            {
                if (Dgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in Dgv.Rows)
                    {
                        total += Convert.ToDouble(row.Cells["Monto"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TxtTotalCompra.Text = total.ToString("0.00");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Debe consultar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (TxtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (TxtCantidad.Value < 1)
            {
                MessageBox.Show("Ingrese la cantidad a comprar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ProductoAgregado())
            {
                MessageBox.Show("Producto ya agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int cantidad= Convert.ToInt32(TxtCantidad.Value);
            double precioCompra = Convert.ToDouble(TxtPrecioCompra.Text);
            double Monto_compra = cantidad * precioCompra; 
            Dgv.Rows.Add(TxtCodigoCompra.Text.ToUpper(), 
                TxtCodigo.Text.ToUpper(),TxtNombreProducto.Text, 
                TxtPrecioCompra.Text,TxtCantidad.Value, 
                Monto_compra.ToString());
            MessageBox.Show("Produco Agregado a la compra");
            BtnConsultarProveedor.Enabled = false;
            calcularTotal();
            TxtCodigo.Clear();
            TxtNombreProducto.Clear();
            TxtPrecioCompra.Clear();
            TxtCantidad.Value= 0;
        }
    }
}

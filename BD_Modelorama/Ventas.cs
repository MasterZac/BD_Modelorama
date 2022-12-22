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
                cmd = new MySqlCommand("ConsultaProductos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter codigo = new MySqlParameter("_codigo", cnn);
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

            TxtTotal.Text = total.ToString("0.00");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodigoVenta.Text == "")
            {
                MessageBox.Show("Ingresa el codigo de compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Txtdni.Text == "")
            {
                MessageBox.Show("Falta consultar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TxtCodigo.Text == "")
            {
                MessageBox.Show("Falta consultar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TxtCantidad.Value == 0)
            {
                MessageBox.Show("Ingresa la cantidad a llevar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int stock = Convert.ToInt32(TxtStock.Text);
            if (TxtCantidad.Value > stock)
            {
                MessageBox.Show("No hay productos suficientes para la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ProductoAgregado())
            {
                MessageBox.Show("El producto ya fue agregado a la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int cantidad = Convert.ToInt32(TxtCantidad.Text);
            double precio = Convert.ToDouble(TxtPrecioVenta.Text);
            double Monto = cantidad * precio;
            Dgv.Rows.Add(TxtCodigoVenta.Text.ToUpper(), TxtCodigo.Text.ToUpper(), TxtNombreP.Text, TxtCantidad.Value, TxtPrecioVenta.Text, Monto.ToString());
            calcularTotal();
            MessageBox.Show("Producto agregado a la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnConsultarC.Enabled = false;
            TxtCodigo.Clear();
            TxtNombreP.Clear();
            TxtPrecioVenta.Clear();
            stocktemp = Convert.ToInt32(TxtStock.Text);
            TxtStock.Clear();
            TxtCantidad.Value = 0;
        }

        int stocktemp;
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Dgv.Rows.Count < 1)
            {
                MessageBox.Show("No hay producto agregados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Dgv.SelectedRows.Count > 0)
            {
                TxtCodigo.Text = Dgv.SelectedCells[1].Value.ToString();
                TxtNombreP.Text = Dgv.SelectedCells[2].Value.ToString();
                TxtPrecioVenta.Text = Dgv.SelectedCells[4].Value.ToString();
                TxtStock.Text = stocktemp.ToString();
                TxtCantidad.Value = Convert.ToInt32(Dgv.SelectedCells[3].Value.ToString());

                foreach (DataGridViewRow remover in Dgv.Rows)
                {
                    Dgv.Rows.Remove(remover);
                }

            }
            else
            {
                MessageBox.Show("Selecciona un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Dgv.Rows.Count < 1)
            {
                MessageBox.Show("No hay producto agregados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow remover in Dgv.Rows)
                {
                    Dgv.Rows.Remove(remover);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void Limpiar()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            Txtdni.Clear();
            TxtNombreP.Clear();
            TxtStock.Clear();
            TxtPrecioVenta.Clear();
            TxtCantidad.Value = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (Dgv.Rows.Count > 0)
            {
                Dgv.Rows.Clear();
            }

            Limpiar();
            BtnConsultarC.Enabled = true;
            MessageBox.Show("Venta cancelada");
        }
    }
}

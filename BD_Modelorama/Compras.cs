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
                TxtPrecioCompra.Value, TxtCantidad.Value, 
                Monto_compra.ToString());
            MessageBox.Show("Produco Agregado a la compra");
            BtnConsultarProveedor.Enabled = false;
            calcularTotal();
            TxtCodigo.Clear();
            TxtNombreProducto.Clear();
            TxtPrecioCompra.Value = 0;
            TxtCantidad.Value= 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Dgv.Rows.Count == 0)
            {
                MessageBox.Show("No ha ingresado producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool aux = false;
            try
            {
                Conectar();
                cmd = new MySqlCommand("AddCompra", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter codigo = new MySqlParameter("codigo", MySqlDbType.VarChar, 10);
                codigo.Value = TxtCodigoCompra.Text.ToUpper();
                cmd.Parameters.Add(codigo);

                MySqlParameter id_proveedor = new MySqlParameter("id_proveedor", MySqlDbType.VarChar, 15);
                id_proveedor.Value = TxtID.Text.ToUpper();
                cmd.Parameters.Add(id_proveedor);

                MySqlParameter fecha = new MySqlParameter("fecha", MySqlDbType.DateTime);
                fecha.Value = Convert.ToDateTime(DateTime.Now.ToString("G"));
                cmd.Parameters.Add(fecha);

                MySqlParameter monto = new MySqlParameter("monto", MySqlDbType.Double);
                monto.Value = TxtTotalCompra.Text;
                cmd.Parameters.Add(monto);
                cmd.ExecuteNonQuery();
                aux = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }

            if (aux == true)
            {
                try
                {
                    Conectar();
                    cmd = new MySqlCommand("AddTiene", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (DataGridViewRow row in Dgv.Rows)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("_codigo_compra", MySqlDbType.VarChar, 10).Value = Convert.ToString(row.Cells["Codigo_compra"].Value);
                        cmd.Parameters.Add("_codigo_producto", MySqlDbType.VarChar, 15).Value = Convert.ToString(row.Cells["Codigo_producto"].Value);
                        cmd.Parameters.Add("_nombre", MySqlDbType.VarChar, 50).Value = Convert.ToString(row.Cells["Nombre"].Value);
                        cmd.Parameters.Add("_precio_compra", MySqlDbType.Double).Value = Convert.ToString(row.Cells["Precio_compra"].Value);
                        cmd.Parameters.Add("_cantidad", MySqlDbType.Int32).Value = Convert.ToString(row.Cells["Cantidad"].Value);
                        cmd.Parameters.Add("_monto_compra", MySqlDbType.Double).Value = Convert.ToString(row.Cells["Monto"].Value);
                        cmd.ExecuteNonQuery();
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

            Dgv.Rows.Clear();
            Limpiar();
            MessageBox.Show("Compra exitosa");
            BtnConsultarProveedor.Enabled = true;
            calcularTotal();
        }

        public void Limpiar()
        {
            TxtCodigoCompra.Clear();
            TxtID.Clear();
            TxtNombreProveedor.Clear();
            TxtCodigo.Clear();
            TxtNombreProducto.Clear();
            TxtPrecioCompra.Value = 0;
            TxtCantidad.Value = 0;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Dgv.Rows.Count < 1)
            {
                MessageBox.Show("No hay productos agregados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Dgv.SelectedRows.Count > 0)
            {
                TxtCodigo.Text = Dgv.SelectedCells[1].Value.ToString();
                TxtNombreProducto.Text = Dgv.SelectedCells[2].Value.ToString();
                TxtPrecioCompra.Text = Dgv.SelectedCells[3].Value.ToString();
                TxtCantidad.Value = Convert.ToInt32(Dgv.SelectedCells[4].Value.ToString());

                foreach (DataGridViewRow remover in Dgv.SelectedRows)
                {
                    Dgv.Rows.Remove(remover);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Dgv.Rows.Count < 1)
            {
                MessageBox.Show("No hay productos agregados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow remover in Dgv.SelectedRows)
                {
                    Dgv.Rows.Remove(remover);
                }
            }
            else
            {
                MessageBox.Show("Eliga un producto");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (Dgv.Rows.Count > 0)
            {
                Dgv.Rows.Clear();
            }

            TxtCodigo.Clear();
            TxtNombreProducto.Clear();
            TxtCodigoCompra.Clear();
            TxtCantidad.Value = 0;
            TxtID.Clear();
            TxtNombreProveedor.Clear();
            BtnConsultarProveedor.Enabled = true;
        }

        private void TxtCodigoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no permitido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no permitido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}

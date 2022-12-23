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
        public static int ventas;
        public static double total_ventas;
        bool aux = false;

        public void reiniciar()
        {
            if (aux == true)
            {
                ventas = 0;
                total_ventas = 0;
                aux = false;
            }
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
                    labelCurpEm.Text = rd[0].ToString();
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
                    string estatus = rd[4].ToString();
                    if (estatus == "Activo")
                    {
                        TxtNombre.Text = rd[1].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente deshabilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
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

            if (TxtCodigo.Text == "" || TxtNombreP.Text == "" || TxtPrecioVenta.Text == "" || TxtStock.Text == "")
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
                TxtCantidad.Value = Convert.ToInt32(Dgv.SelectedCells[3].Value.ToString());
                CalcularStock();

                foreach (DataGridViewRow remover in Dgv.Rows)
                {
                    Dgv.Rows.Remove(remover);
                }
                TxtCantidad.Focus();
                calcularTotal();

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
                calcularTotal();
            }
            else
            {
                MessageBox.Show("Selecciona un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void Limpiar()
        {
            TxtCodigoVenta.Clear();
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
            calcularTotal();
            MessageBox.Show("Venta cancelada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reiniciar();

            if (Dgv.Rows.Count == 0)
            {
                MessageBox.Show("No se han agregado productos a la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("AddVenta", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter codigoventa = new MySqlParameter("_codigo", MySqlDbType.VarChar, 15);
                codigoventa.Value = TxtCodigoVenta.Text.ToUpper();
                cmd.Parameters.Add(codigoventa);

                MySqlParameter fecha = new MySqlParameter("_fecha", MySqlDbType.DateTime);
                fecha.Value = Convert.ToDateTime(DateTime.Now.ToString("G"));
                cmd.Parameters.Add(fecha);

                MySqlParameter curp = new MySqlParameter("_curp", MySqlDbType.VarChar, 15);
                curp.Value = labelCurpEm.Text.ToUpper();
                cmd.Parameters.Add(curp);

                MySqlParameter dni = new MySqlParameter("_dni", MySqlDbType.VarChar, 15);
                dni.Value = Txtdni.Text.ToUpper();
                cmd.Parameters.Add(dni);

                MySqlParameter monto = new MySqlParameter("_monto", MySqlDbType.Double);
                monto.Value = TxtTotal.Text;
                cmd.Parameters.Add(monto);
                cmd.ExecuteNonQuery();
                ventas++;
                total_ventas += Convert.ToDouble(TxtTotal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("AddAparece", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow enviar in Dgv.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("_codigo_venta", MySqlDbType.VarChar, 15).Value = Convert.ToString(enviar.Cells["Codigo_venta"].Value);
                    cmd.Parameters.Add("_codigo_producto", MySqlDbType.VarChar, 15).Value = Convert.ToString(enviar.Cells["Codigo_producto"].Value);
                    cmd.Parameters.Add("_nombre", MySqlDbType.VarChar, 100).Value = Convert.ToString(enviar.Cells["Nombre"].Value);
                    cmd.Parameters.Add("_cantidad", MySqlDbType.Int32).Value = Convert.ToInt32(enviar.Cells["Cantidad"].Value);
                    cmd.Parameters.Add("_precio", MySqlDbType.Double).Value = Convert.ToDouble(enviar.Cells["Precio"].Value);
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

            Dgv.Rows.Clear();
            Limpiar();
            MessageBox.Show("Se ha realizado correctamente la venta");
            BtnConsultarC.Enabled = true;
            calcularTotal();

        }

        public void CalcularStock()
        {
            try
            {
                Conectar();
                string consulta = "Select Stock From productos Where Codigo = ('" + TxtCodigo.Text + "')";
                cmd = new MySqlCommand(consulta, cnn);
                cmd.CommandType = CommandType.Text;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    TxtStock.Text = rd[0].ToString();
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

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            if (Dgv.Rows.Count > 0)
            {
                MessageBox.Show("Para hacer corte de caja primero termina la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tabControl1.Visible == false)
            {
                reiniciar();
                tabControl1.Visible = true;
                TxtFecha_corte.Text = Convert.ToString(DateTime.Now.ToString("G"));
                LabelVentas.Text = ventas.ToString();
                labelTotal.Text = total_ventas.ToString();
            }
            else
            {
                tabControl1.Visible = false;
            }
        }

        private void BtnTerminarCorte_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;

            if (TxtID_corte.Text == "")
            {
                MessageBox.Show("Ingresa el id del corte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("AddCorte", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ID = new MySqlParameter("_id", MySqlDbType.VarChar, 10);
                ID.Value = TxtID_corte.Text;
                cmd.Parameters.Add(ID);

                MySqlParameter curp = new MySqlParameter("_curp", MySqlDbType.VarChar, 15);
                curp.Value = labelCurpEm.Text.ToUpper();
                cmd.Parameters.Add(curp);
                
                MySqlParameter fecha = new MySqlParameter("_fecha", MySqlDbType.DateTime);
                fecha.Value = Convert.ToDateTime(TxtFecha_corte.Text);
                cmd.Parameters.Add(fecha);

                MySqlParameter ventas = new MySqlParameter("_ventas", MySqlDbType.Int32);
                ventas.Value = LabelVentas.Text;
                cmd.Parameters.Add(ventas);

                MySqlParameter Total = new MySqlParameter("_total", MySqlDbType.Double);
                Total.Value = labelTotal.Text;
                cmd.Parameters.Add(Total);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Corte exitoso");
                aux = true;
                TxtID_corte.Clear();
                
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

        private void BtnNoCorte_Click(object sender, EventArgs e)
        {
            if (tabControl1.Visible == true)
            {
                tabControl1.Visible = false;
                MessageBox.Show("Corte de caja cancelado");
            }
        }

        private void TxtID_corte_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void TxtID_corte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros, sin espacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}

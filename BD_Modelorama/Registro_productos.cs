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
            CargarRegistro();
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

        public void CargarRegistro()
        {
            try
            {
                Conectar();
                string consultar = "Select * From productos";
                cmd = new MySqlCommand(consultar, cnn);
                cmd.CommandType = CommandType.Text;

                da = new MySqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                Dgv2.DataSource = table;

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

        public void ConsultarProductosComprados()
        {
            try
            {
                Conectar();
                string Consultar = "Select * From tiene Where (" + CmbBuscarProductos.Text + ") Like ('" + TxtBuscarProductosC.Text + "%')";
                cmd = new MySqlCommand(Consultar, cnn);
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

        public void ConsultarRegistro()
        {
            try
            {
                Conectar();
                string Consultar = "Select * From productos Where (" + CmbRegistros.Text + ") Like ('" + TxtBuscarRegistros.Text + "%')";
                cmd = new MySqlCommand(Consultar, cnn);
                cmd.CommandType = CommandType.Text;
                table = new DataTable();
                da = new MySqlDataAdapter(cmd);
                da.Fill(table);
                Dgv2.DataSource = table;

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

        public bool ValidarExistencia()
        {
            bool aux = false;
            string codigo = TxtCodigo.Text;
            if (Dgv2.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in Dgv2.Rows)
                {
                    if (fila.Cells[0].Value.ToString() == Convert.ToString(codigo))
                    {
                        aux = true;
                        break;
                    }
                }
            }
            return aux;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.NombreTrabajador = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBuscarProductosC.Clear();
            cargarProductosComprados();
        }

        public void Limpiar()
        {
            TxtCodigo.Text = "Codigo";
            TxtNombre.Text = "Nombre";
            TxtPrecio.Text = "Precio";
            TxtPrecioVenta.Text = "Precio Venta";
            TxtStock.Text = "Stock";
            TxtEstatus.Text = "Estatus";
        }

        private void BtnLimp_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DgvListadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListadoProductos.SelectedRows.Count > 0)
            {
                TxtCodigo.Text = DgvListadoProductos.SelectedCells[1].Value.ToString();
                TxtNombre.Text = DgvListadoProductos.SelectedCells[2].Value.ToString();
                TxtPrecio.Text = DgvListadoProductos.SelectedCells[4].Value.ToString();
                TxtStock.Text = DgvListadoProductos.SelectedCells[3].Value.ToString();
                DgvListadoProductos.ClearSelection();
            }
        }

        private void BtnLimpiar2_Click(object sender, EventArgs e)
        {
            TxtBuscarRegistros.Clear();
            CargarRegistro();
        }

        private void TxtBuscarProductosC_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public bool Campos()
        {
            bool aux = false;
            if (TxtCodigo.Text == "Codigo" || TxtNombre.Text == "Nombre" || TxtPrecio.Text == "Precio" || TxtStock.Text == "Stock")
            {
                aux = true;
            }
            return aux;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Campos())
            {
                MessageBox.Show("No se ha elegido nigun producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TxtPrecioVenta.Text == "")
            {
                MessageBox.Show("No se ha establecido el precio de venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ValidarExistencia())
            {
                MessageBox.Show("Producto ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("AddProductos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter codigo = new MySqlParameter("pcodigo", MySqlDbType.VarChar, 15);
                codigo.Value = TxtCodigo.Text;
                cmd.Parameters.Add(codigo);

                MySqlParameter nombre = new MySqlParameter("pnombre", MySqlDbType.VarChar, 50);
                nombre.Value = TxtNombre.Text;
                cmd.Parameters.Add(nombre);

                MySqlParameter precio = new MySqlParameter("pprecio", MySqlDbType.Double);
                precio.Value = TxtPrecio.Text;
                cmd.Parameters.Add(precio);

                MySqlParameter precio_venta = new MySqlParameter("pprecio_venta", MySqlDbType.Double);
                precio_venta.Value = TxtPrecioVenta.Text;
                cmd.Parameters.Add(precio_venta);

                MySqlParameter stock = new MySqlParameter("pstock", MySqlDbType.Int32);
                stock.Value = TxtStock.Text;
                cmd.Parameters.Add(stock);

                cmd.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("Registro exitoso");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
            CargarRegistro();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv2.SelectedRows.Count > 0)
            {
                TxtCodigo.Text = Dgv2.SelectedCells[0].Value.ToString();
                TxtNombre.Text = Dgv2.SelectedCells[1].Value.ToString();
                TxtPrecio.Text = Dgv2.SelectedCells[2].Value.ToString();
                TxtPrecioVenta.Text = Dgv2.SelectedCells[3].Value.ToString();
                TxtStock.Text = Dgv2.SelectedCells[4].Value.ToString();
                TxtEstatus.Text = Dgv2.SelectedCells[5].Value.ToString();
                Dgv2.ClearSelection();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Campos())
            {
                MessageBox.Show("No se ha elegido nigun producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TxtPrecioVenta.Text == "")
            {
                MessageBox.Show("No se ha establecido el precio de venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ValidarExistencia())
            {
                try
                {
                    Conectar();
                    cmd = new MySqlCommand("EditaProductos", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter codigo = new MySqlParameter("pcodigo", MySqlDbType.VarChar, 15);
                    codigo.Value = TxtCodigo.Text;
                    cmd.Parameters.Add(codigo);

                    MySqlParameter precio_venta = new MySqlParameter("pprecio_venta", MySqlDbType.Double);
                    precio_venta.Value = TxtPrecioVenta.Text;
                    cmd.Parameters.Add(precio_venta);

                    cmd.ExecuteNonQuery();
                    Limpiar();
                    MessageBox.Show("Producto actualizado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Desconectar();
                }
                CargarRegistro();
            }
            else
            {
                MessageBox.Show("Producto no existente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Campos())
            {
                MessageBox.Show("No se ha elegido nigun producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ValidarExistencia())
            {
                if (TxtEstatus.Text == "Activo")
                {
                    TxtEstatus.Text = "Inactivo";
                    MessageBox.Show("Producto deshabilitado");
                }
                else
                {
                    TxtEstatus.Text = "Activo";
                    MessageBox.Show("Producto habilitado");
                }

                try
                {
                    Conectar();
                    cmd = new MySqlCommand("DeleteProductos", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter codigo = new MySqlParameter("pcodigo", MySqlDbType.VarChar, 15);
                    codigo.Value = TxtCodigo.Text;
                    cmd.Parameters.Add(codigo);

                    MySqlParameter estatus = new MySqlParameter("pestatus", MySqlDbType.VarChar, 15);
                    estatus.Value = TxtEstatus.Text;
                    cmd.Parameters.Add(estatus);

                    cmd.ExecuteNonQuery();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Desconectar();
                }
                CargarRegistro();
            }
            else
            {
                MessageBox.Show("Producto no existente");
            }
        }

        private void TxtBuscarProductosC_KeyUp(object sender, KeyEventArgs e)
        {
            if (CmbBuscarProductos.SelectedIndex < 0)
            {
                MessageBox.Show("Eliga por que quiere consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ConsultarProductosComprados();
            }
        }

        private void TxtBuscarRegistros_KeyUp(object sender, KeyEventArgs e)
        {
            if (CmbRegistros.SelectedIndex < 0)
            {
                MessageBox.Show("Eliga por que quiere consultar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ConsultarRegistro();
            }
        }
    }
}

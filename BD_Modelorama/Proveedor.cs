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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rd;
        MySqlDataAdapter da;
        DataTable dt;

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

        public void Limpiar()
        {
            TxtID.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtID.Focus();
            if (Dgv.Rows.Count > 0)
                Dgv.Rows.RemoveAt(0);
        }

        public bool CamposVacios()
        {
            bool aux = false;
            if (TxtID.Text == "" || TxtNombre.Text == "" || TxtDireccion.Text == "")
            {
                aux = true;
            }
            return aux;
        }

        public bool ConsultarExistencia()
        {
            bool aux = false;
            try
            {
                Conectar();
                string query = "Select * From proveedor Where ID = ('" + TxtID.Text + "'); ";
                cmd = new MySqlCommand(query, cnn);
                cmd.CommandType = CommandType.Text;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    aux = true;
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
            return aux;
        }

        public bool ValidarActualizacion()
        {
            bool aux = false;
            try
            {
                Conectar();
                string query = "Select * From proveedor Where ID = ('" + TxtID.Text + "') and Nombre = ('" + TxtNombre.Text + "') and Direccion = ('" + TxtDireccion.Text + "')";
                cmd = new MySqlCommand(query, cnn);
                cmd.CommandType= CommandType.Text;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    aux = true;
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

            return aux;
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ValidarActualizacion())
            {
                MessageBox.Show("No realizo ninguna actualizacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                try
                {
                    Conectar();
                    cmd = new MySqlCommand("EditaProveedor", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter id = new MySqlParameter("id", MySqlDbType.VarChar, 15);
                    id.Value = TxtID.Text;
                    cmd.Parameters.Add(id);

                    MySqlParameter nombre = new MySqlParameter("nombre", MySqlDbType.VarChar, 50);
                    nombre.Value = TxtNombre.Text;
                    cmd.Parameters.Add(nombre);

                    MySqlParameter direccion = new MySqlParameter("direccion", MySqlDbType.VarChar, 100);
                    direccion.Value = TxtDireccion.Text;
                    cmd.Parameters.Add(direccion);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor actualizado");
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
            }
            else
            {
                MessageBox.Show("No existe ese cliente");
            }
        }

        public string nombre;

        private void Proveedor_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = nombre;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                MessageBox.Show("Empleado ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("AddProveedor", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter id = new MySqlParameter("id", MySqlDbType.VarChar, 15);
                id.Value = TxtID.Text.ToUpper().Trim();
                cmd.Parameters.Add(id);

                MySqlParameter nombre = new MySqlParameter("nombre", MySqlDbType.VarChar, 50);
                nombre.Value = TxtNombre.Text.Trim();
                cmd.Parameters.Add(nombre);

                MySqlParameter direccion = new MySqlParameter("direccion", MySqlDbType.VarChar, 100);
                direccion.Value = TxtDireccion.Text.Trim();
                cmd.Parameters.Add(direccion);

                cmd.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("Proveedor agregado");
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                if (TxtEstatus.Text == "Activo")
                {
                    TxtEstatus.Text = "Inactivo";
                    MessageBox.Show("Proveedor deshabilitado");
                }
                else
                {
                    TxtEstatus.Text = "Activo";
                    MessageBox.Show("Proveedor habilitado");
                }


                try
                {
                    Conectar();
                    cmd = new MySqlCommand("DeleteProveedor", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter id = new MySqlParameter("id", MySqlDbType.VarChar, 15);
                    id.Value = TxtID.Text;
                    cmd.Parameters.Add(id);

                    MySqlParameter estatus = new MySqlParameter("estatus", MySqlDbType.VarChar, 15);
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
            }
            else
            {
                MessageBox.Show("Proveedor no existente");
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Ingrese el id", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool aux = false;
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
                    aux = true;
                    TxtNombre.Text = rd[1].ToString();
                    TxtDireccion.Text = rd[2].ToString();
                    TxtEstatus.Text = rd[3].ToString();
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

            if (aux == true)
            {
                try
                {
                    Conectar();
                    cmd = new MySqlCommand("ConsultaProveedor", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter id = new MySqlParameter("_id", MySqlDbType.VarChar, 15);
                    id.Value = TxtID.Text;
                    cmd.Parameters.Add(id);

                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    Dgv.DataSource = dt;
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
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.NombreTrabajador = LabelNombreEmpleado.Text;
            x.Show();
            this.Hide();
        }
    }
}

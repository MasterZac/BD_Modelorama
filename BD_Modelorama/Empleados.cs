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
    public partial class Empleados : Form
    {
        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rd;
        MySqlDataAdapter da;
        DataTable dt;

        public Empleados()
        {
            InitializeComponent();
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

        public bool ConsultarExistencia()
        {
            bool respuesta = false;
            try
            {
                Conectar();
                string query = "Select * From empleado Where Curp = ('" + TxtCurp.Text + "')";
                cmd = new MySqlCommand(query, cnn);
                cmd.CommandType = CommandType.Text;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    respuesta = true;
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
            return respuesta;
        }

        public string empleado;

        private void Empleados_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = String.Format("{0}", empleado);
        }

        public void Limpiar()
        {
            TxtCurp.Clear();
            TxtNombre.Clear();
            CmbPuesto.Text = "";
            TxtEstatus.Clear();
            TxtEdad.Clear();
            TxtContraseña.Clear();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.NombreTrabajador = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        public bool CamposVacios()
        {
            bool aux = false;
            if (TxtCurp.Text == "" || TxtNombre.Text == "" || TxtEdad.Text == "" || TxtContraseña.Text == "")
            {
                aux = true;
            }
            return aux;
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
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
                cmd = new MySqlCommand("AddEmpleado", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter pcurp = new MySqlParameter("pcurp", MySqlDbType.VarChar, 20);
                pcurp.Value = TxtCurp.Text.ToUpper().Trim();
                cmd.Parameters.Add(pcurp);

                MySqlParameter pedad = new MySqlParameter("pedad", MySqlDbType.Int32);
                pedad.Value = TxtEdad.Text.Trim();
                cmd.Parameters.Add(pedad);

                MySqlParameter ppuesto = new MySqlParameter("ppuesto", MySqlDbType.VarChar, 25);
                ppuesto.Value = CmbPuesto.Text;
                cmd.Parameters.Add(ppuesto);

                MySqlParameter pnombre = new MySqlParameter("pnombre", MySqlDbType.VarChar, 15);
                pnombre.Value = TxtNombre.Text.Trim();
                cmd.Parameters.Add(pnombre);

                MySqlParameter pcontraseña = new MySqlParameter("pcontraseña", MySqlDbType.VarChar, 10);
                pcontraseña.Value = TxtContraseña.Text.Trim();
                cmd.Parameters.Add(pcontraseña);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado registrado");
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtCurp.Text == "")
            {
                MessageBox.Show("Ingrese el codigo del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                if (TxtEstatus.Text == "Activo")
                {
                    TxtEstatus.Text = "Inactivo";
                    MessageBox.Show("Empleado deshabilitado");
                }
                else
                {
                    TxtEstatus.Text = "Activo";
                    MessageBox.Show("Empleado habilitado");
                }

                try
                {
                    Conectar();
                    cmd = new MySqlCommand("DeleteEmpleado", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter pcurp = new MySqlParameter("pcurp", MySqlDbType.VarChar, 20);
                    pcurp.Value = TxtCurp.Text;
                    cmd.Parameters.Add(pcurp);

                    MySqlParameter pestatus = new MySqlParameter("pestatus", MySqlDbType.VarChar, 15);
                    pestatus.Value = TxtEstatus.Text;
                    cmd.Parameters.Add(pestatus);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estatus del empleado: " + TxtEstatus.Text);
                    Limpiar();
                    DGVEmpleados.Rows.RemoveAt(0);
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
                MessageBox.Show("Empleado no existente");
            }
            
        }

        public bool ChecarActualizacion()
        {
            bool aux = false;
            try
            {
                Conectar();
                string query = "Select * From empleado Where Edad = ('" + TxtEdad.Text + "')" +
                    " and Puesto = ('" + CmbPuesto.Text + "') and Nombre =  ('" + TxtNombre.Text + "') and Contraseña = ('" + TxtContraseña.Text + "')" +
                    " and Curp = ('" + TxtCurp.Text + "')";
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ChecarActualizacion())
            {
                MessageBox.Show("No realizo ninguna actualizacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                try
                {
                    Conectar();
                    cmd = new MySqlCommand("EditaEmpleado", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter pcurp = new MySqlParameter("pcurp", MySqlDbType.VarChar, 20);
                    pcurp.Value = TxtCurp.Text.ToUpper().Trim();
                    cmd.Parameters.Add(pcurp);

                    MySqlParameter pedad = new MySqlParameter("pedad", MySqlDbType.Int32);
                    pedad.Value = TxtEdad.Text.Trim();
                    cmd.Parameters.Add(pedad);

                    MySqlParameter ppuesto = new MySqlParameter("ppuesto", MySqlDbType.VarChar, 25);
                    ppuesto.Value = CmbPuesto.Text;
                    cmd.Parameters.Add(ppuesto);

                    MySqlParameter pnombre = new MySqlParameter("pnombre", MySqlDbType.VarChar, 15);
                    pnombre.Value = TxtNombre.Text.Trim();
                    cmd.Parameters.Add(pnombre);

                    MySqlParameter pcontraseña = new MySqlParameter("pcontraseña", MySqlDbType.VarChar, 10);
                    pcontraseña.Value = TxtContraseña.Text.Trim();
                    cmd.Parameters.Add(pcontraseña);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado actualizado");
                    Limpiar();
                    DGVEmpleados.Rows.RemoveAt(0);

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
                MessageBox.Show("Empleado no existente");
            }
        }

        public void ValidarClave()
        {
            var vr = !string.IsNullOrEmpty(TxtCurp.Text);
            BtnConsultar.Enabled = vr;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (TxtCurp.Text == "")
            {
                MessageBox.Show("Ingrese el curp", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("ConsultaEmpleado", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter pcurp = new MySqlParameter("pcurp", MySqlDbType.VarChar, 20);
                pcurp.Value = TxtCurp.Text;
                cmd.Parameters.Add(pcurp);

                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                  
                    TxtEdad.Text = rd[1].ToString();
                    CmbPuesto.Text = rd[2].ToString();
                    TxtNombre.Text = rd[3].ToString();
                    TxtContraseña.Text = rd[4].ToString();
                    TxtEstatus.Text = rd[5].ToString();
                    DGVEmpleados.Rows.Add(TxtCurp.Text, TxtContraseña.Text, TxtNombre.Text, TxtEdad.Text, CmbPuesto.Text, TxtEstatus.Text);
                }
                else
                {
                    MessageBox.Show("No hay registros de ese empleado");
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            if (DGVEmpleados.Rows.Count > 0)
                DGVEmpleados.Rows.RemoveAt(0);
        }

        private void TxtCurp_TextChanged(object sender, EventArgs e)
        {
            ValidarClave();

        }

        private void TxtEdad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros, sin espacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }
    }
}

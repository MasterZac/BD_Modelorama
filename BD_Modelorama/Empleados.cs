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

        public string empleado { get; set; }

        private void Empleados_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = String.Format("{0}", empleado);
            BtnRegistrar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnConsultar.Enabled = false;
        }

        public void Limpiar()
        {
            TxtCurp.Clear();
            TxtNombre.Clear();
            CmbPuesto.Text = "";
            TxtEdad.Clear();
            TxtContraseña.Clear();
        }

        public void Validar()
        {
            var vr = !string.IsNullOrEmpty(TxtCurp.Text) &&
                !string.IsNullOrEmpty(TxtEdad.Text) &&
                !string.IsNullOrEmpty(TxtNombre.Text) &&
                !string.IsNullOrEmpty(TxtContraseña.Text);
            BtnRegistrar.Enabled = vr;
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.NombreTrabajador = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtCurp.Text == "" || TxtNombre.Text == "" || TxtEdad.Text == "" || TxtContraseña.Text == "")
            {
                MessageBox.Show("RELLENA TODOS LOS CAMPOS");
            }
            else
            {
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
                    pnombre.Value = TxtNombre.Text;
                    cmd.Parameters.Add(pnombre);

                    MySqlParameter pcontraseña = new MySqlParameter("pcontraseña", MySqlDbType.VarChar, 10);
                    pcontraseña.Value = TxtContraseña.Text;
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

            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            bool elimino = false;

            try
            {
                Conectar();
                cmd = new MySqlCommand("DeleteEmpleado", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter pcurp = new MySqlParameter("pcurp", MySqlDbType.VarChar, 20);
                pcurp.Value = TxtCurp.Text;
                cmd.Parameters.Add(pcurp);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado eliminado");
                Limpiar();
                elimino = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }

            if (elimino == true)
            {
                RefrescarDgv();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
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
                pnombre.Value = TxtNombre.Text;
                cmd.Parameters.Add(pnombre);

                MySqlParameter pcontraseña = new MySqlParameter("pcontraseña", MySqlDbType.VarChar, 10);
                pcontraseña.Value = TxtContraseña.Text;
                cmd.Parameters.Add(pcontraseña);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado actualizado");
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

        public void RefrescarDgv()
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("ConsultaEmpleado", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter pcurp = new MySqlParameter("pcurp", MySqlDbType.VarChar, 20);
                pcurp.Value = TxtCurp.Text;
                cmd.Parameters.Add(pcurp);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                DGVEmpleados.DataSource = dt;
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

        public void ValidarClave()
        {
            var vr = !string.IsNullOrEmpty(TxtCurp.Text);
            BtnConsultar.Enabled = vr;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            bool existe_empleado = true;

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
                    existe_empleado = true;
                    TxtEdad.Text = rd[1].ToString();
                    CmbPuesto.Text = rd[2].ToString();
                    TxtNombre.Text = rd[3].ToString();
                    TxtContraseña.Text = rd[4].ToString();
                    BtnRegistrar.Enabled = false;
                    BtnEliminar.Enabled = true;
                    BtnEditar.Enabled = true;
                }
                else
                {
                    existe_empleado = false;
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

            if (existe_empleado == true)
            {
                try
                {
                    Conectar();
                    cmd = new MySqlCommand("ConsultaEmpleado", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter pcurp = new MySqlParameter("pcurp", MySqlDbType.VarChar, 20);
                    pcurp.Value = TxtCurp.Text;
                    cmd.Parameters.Add(pcurp);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    DGVEmpleados.DataSource = dt;
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            
            BtnEliminar.Enabled = false;
            BtnEditar.Enabled = false;
            Limpiar();
            RefrescarDgv();
        }

        private void TxtCurp_TextChanged(object sender, EventArgs e)
        {
            Validar();
            ValidarClave();

        }

        private void TxtEdad_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            Validar();
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
    }
}

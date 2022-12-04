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


        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            TxtCurp.Clear();
            TxtNombre.Clear();
            TxtEdad.Clear();
            TxtContraseña.Clear();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
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
                cmd = new MySqlCommand("EditarEmpleado", cnn);

                MySqlParameter pcurp = new MySqlParameter("pcurp", MySqlDbType.VarChar, 20);
                pcurp.Value = TxtCurp.Text.ToUpper().Trim();
                cmd.Parameters.Add(pcurp);

                MySqlParameter pedad = new MySqlParameter("pedad", MySqlDbType.Int32);
                pedad.Value = TxtEdad.Text.Trim();
                cmd.Parameters.Add(pedad);

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
                    TxtNombre.Text = rd[2].ToString();
                    TxtContraseña.Text = rd[3].ToString();
                }
                else
                {
                    existe_empleado = false;
                    MessageBox.Show("No existe ese empleado");
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
            Limpiar();
            RefrescarDgv();
        }
    }
}

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
    public partial class Menu : Form
    {

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rd;
        MySqlDataAdapter da;
        DataTable table;

        public string NombreTrabajador;
        public string Rol;

        string f_i;
        string f_s;

        public Menu()
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

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_productos x = new Registro_productos();
            x.Nombre_empleado = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        private void EMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ConsultaPuestoEmpleado()
        {
            try
            {
                Conectar();
                string query = "Select Puesto, Curp From empleado Where Nombre = ('" + LabelNombreEmpleado.Text + "'); ";
                cmd = new MySqlCommand(query, cnn);
                cmd.CommandType = CommandType.Text;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    LabelPuesto.Text = rd[0].ToString();
                    labelcurp.Text = rd[1].ToString();
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

        private void Menu_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = string.Format("{0}", NombreTrabajador);
            f_i = Convert.ToString(DateTime.Now.ToString("G"));
            ConsultaPuestoEmpleado();
            if (LabelPuesto.Text == "Cajero")
            {
                EMPLEADOSToolStripMenuItem.Enabled = false;
                CLIENTESToolStripMenuItem.Enabled = false;
                PROVEEDORToolStripMenuItem.Enabled = false;
                PRODUCTOSToolStripMenuItem.Enabled = false;
                HistorialVentas.Enabled = false;
                cORTESDECAJAToolStripMenuItem.Enabled = false;
            }

            if (LabelPuesto.Text == "Administrador")
            {
                EMPLEADOSToolStripMenuItem.Enabled = false;
            }
            
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            f_s = Convert.ToString(DateTime.Now.ToString("G"));

            try
            {
                Conectar();
                cmd = new MySqlCommand("AddLOG", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter curp = new MySqlParameter("_curp", MySqlDbType.VarChar, 15);
                curp.Value = labelcurp.Text;
                cmd.Parameters.Add(curp);

                MySqlParameter fecha_entrada = new MySqlParameter("_fecha_i", MySqlDbType.DateTime);
                fecha_entrada.Value = Convert.ToDateTime(f_i);
                cmd.Parameters.Add(fecha_entrada);

                MySqlParameter fecha_salida = new MySqlParameter("_fecha_s", MySqlDbType.DateTime);
                fecha_salida.Value = Convert.ToDateTime(f_s);
                cmd.Parameters.Add(fecha_salida);

                cmd.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }


            LOGIN x = new LOGIN();
            this.Hide();
            x.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }

        private void CLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes x = new Clientes();
            x.nombre = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        private void PROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor x = new Proveedor();
            x.nombre = LabelNombreEmpleado.Text;
            x.Show();
            this.Hide();
            
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras form = new Compras();
            form.nombreEmpleado = LabelNombreEmpleado.Text;
            this.Hide();
            form.Show();
        }

        private void lISTADEENTRADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_de_entradas x = new Lista_de_entradas();
            x.nombreempleado = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        private void rEGISTRARVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas form = new Ventas();
            form.nombreEmpleado = LabelNombreEmpleado.Text;
            this.Hide();
            form.Show();
        }

        private void rEGISTRODEEMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados x = new Empleados();
            x.empleado = LabelNombreEmpleado.Text;
            this.Hide();
            x.Show();
        }

        public void ConsultarLOG()
        {
            try
            {
                Conectar();
                string consultar = "Select * From logempleado Where (" + comboBoxLOG.Text + ") Like ('" + TxtBuscar.Text + "')";
                cmd = new MySqlCommand(consultar, cnn);
                cmd.CommandType = CommandType.Text;
                da = new MySqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                DgvLOG.DataSource = table;
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

        public void CargarLOG()
        {
            try
            {
                Conectar();
                string Consultar = "Select * From logempleado";
                cmd = new MySqlCommand(Consultar, cnn);
                cmd.CommandType = CommandType.Text;

                da = new MySqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                DgvLOG.DataSource = table;  
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        private void lOGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabLOG.Visible == true)
            {
                tabLOG.Visible = false;
            }
            else
            {
                tabLOG.Visible = true;
                CargarLOG();
            }
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBoxLOG.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona por que quieres consultar");
            }
            else
            {
                ConsultarLOG();
            }
        }

        private void BtnLimpiar2_Click(object sender, EventArgs e)
        {
            TxtBuscar.Clear();
            CargarLOG();
        }

        private void vENTASREALIZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_ventas_y_productos form = new Historial_ventas_y_productos();
            form.empleado = LabelNombreEmpleado.Text;
            this.Hide();
            form.Show();
        }

        private void cORTESDECAJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cortes_de_caja form = new Cortes_de_caja();
            form.empleado = LabelNombreEmpleado.Text;
            this.Hide();
            form.Show();
        }
    }
}

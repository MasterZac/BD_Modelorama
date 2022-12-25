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
    public partial class LOGIN : Form
    {
        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rd;
        public LOGIN()
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

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            bool existencia = true;
            try
            {
                Conectar();
                cmd = new MySqlCommand("LOGIN", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter pnombre = new MySqlParameter("pnombre", MySqlDbType.VarChar, 15);
                pnombre.Value = TxtNombre.Text;
                cmd.Parameters.Add(pnombre);

                MySqlParameter pcontraseña = new MySqlParameter("pcontraseña", MySqlDbType.VarChar, 10);
                pcontraseña.Value = TxtContraseña.Text;
                cmd.Parameters.Add(pcontraseña);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {

                    existencia = true;
                }
                else
                {
                    existencia = false;
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

            bool estatus = true;
            try
            {
                Conectar();
                string query = "Select * From empleado Where Nombre = ('" + TxtNombre.Text + "') And Estatus = 'Activo' ";
                cmd = new MySqlCommand(query, cnn);
                cmd.CommandType = CommandType.Text;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    estatus = true;
                }
                else
                {
                    estatus = false;
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

            if (existencia == true)
            {
                if (estatus == true)
                {
                    Menu x = new Menu();
                    x.NombreTrabajador = TxtNombre.Text;
                    this.Hide();
                    x.Show();
                }
                else
                {
                    MessageBox.Show("No se encuentra habilitado este usuario");
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}

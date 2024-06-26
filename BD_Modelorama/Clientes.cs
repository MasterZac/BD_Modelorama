﻿using System;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rd;
        MySqlDataAdapter da;
        DataTable dt;

        public string nombre;


        public void Conectar()
        {
            cnn.ConnectionString = "Server = localhost; Database = bd_modelorama; user = root; password = root";
            cnn.Open();
        }

        public void Desconectar()
        {
            cnn.Close();
        }

        public void Limpiar()
        {
            TxtDni.Clear();
            TxtNombre.Clear();
            mkdNacimiento.Clear();
            TxtDireccion.Clear();
            TxtDni.Focus();
            TxtEstatus.Clear();
            if (Dgv.Rows.Count > 0)
                Dgv.Rows.RemoveAt(0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = Convert.ToString(DateTime.Now.ToString("G"));
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            LabelNombreEmpleado.Text = nombre;
        }

        public bool CamposVacios()
        {
            bool aux = false;
            if (TxtDni.Text == "" || TxtNombre.Text == "" || TxtDireccion.Text == "" || mkdNacimiento.Text == "")
            {
                aux = true;
            }
            return aux;
        }

        public bool ConsultarExistencia()
        {
            bool respuesta = false;
            try
            {
                Conectar();
                string query = "Select * From cliente Where Dni = ('" + TxtDni.Text + "');";
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

        public bool ValidarActualizacion()
        {
            bool aux = false;
            try
            {
                Conectar();
                string query = "Select * From cliente Where Nombre = ('" + TxtNombre.Text + "') and Fecha_nacimiento = ('" + mkdNacimiento.Text + "') " +
                    "and Direccion = ('" + TxtDireccion.Text + "') and Dni = ('" + TxtDni.Text + "')";
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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (TxtDni.Text == "")
            {
                MessageBox.Show("Ingrese el dni", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool existencia = false;
            try
            {
                Conectar();
                cmd = new MySqlCommand("ConsultaCliente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter dni = new MySqlParameter("_dni", MySqlDbType.VarChar, 15);
                dni.Value = TxtDni.Text.ToUpper();
                cmd.Parameters.Add(dni);

                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    existencia = true;
                    TxtNombre.Text = rd[1].ToString();
                    mkdNacimiento.Text = rd[2].ToString();
                    TxtDireccion.Text = rd[3].ToString();
                    TxtEstatus.Text = rd[4].ToString();
                }
                else
                {
                    existencia = false;
                    MessageBox.Show("Cliente no existente");
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
                try
                {
                    Conectar();
                    cmd = new MySqlCommand("ConsultaCliente", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter _dni = new MySqlParameter("_dni", MySqlDbType.VarChar, 15);
                    _dni.Value = TxtDni.Text.ToUpper();
                    cmd.Parameters.Add(_dni);

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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ConsultarExistencia())
            {
                MessageBox.Show("Cliente ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conectar();
                cmd = new MySqlCommand("AddCliente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter dni = new MySqlParameter("pdni", MySqlDbType.VarChar, 15);
                dni.Value = TxtDni.Text.ToUpper();
                cmd.Parameters.Add(dni);

                MySqlParameter nombre = new MySqlParameter("pnombre", MySqlDbType.VarChar, 50);
                nombre.Value = TxtNombre.Text.Trim();
                cmd.Parameters.Add(nombre);

                MySqlParameter nacimiento = new MySqlParameter("pnacimiento", MySqlDbType.VarChar, 10);
                nacimiento.Value = mkdNacimiento.Text;
                cmd.Parameters.Add(nacimiento);

                MySqlParameter direccion = new MySqlParameter("pdireccion", MySqlDbType.VarChar, 100);
                direccion.Value = TxtDireccion.Text.Trim();
                cmd.Parameters.Add(direccion);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado");
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
            if (TxtDni.Text == "")
            {
                MessageBox.Show("Ingrese el Dni del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ConsultarExistencia())
            {
                if (TxtEstatus.Text == "Activo")
                {
                    TxtEstatus.Text = "Inactivo";
                    MessageBox.Show("Cliente deshabilitado");
                }
                else
                {
                    TxtEstatus.Text = "Activo";
                    MessageBox.Show("Cliente habilitado");
                }

                try
                {
                    Conectar();
                    cmd = new MySqlCommand("DeleteCliente", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter dni = new MySqlParameter("pdni", MySqlDbType.VarChar, 15);
                    dni.Value = TxtDni.Text;
                    cmd.Parameters.Add(dni);

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
            }
            else
            {
                MessageBox.Show("Cliente no existente");
            }
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
                    cmd = new MySqlCommand("EditaCliente", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter dni = new MySqlParameter("pdni", MySqlDbType.VarChar, 15);
                    dni.Value = TxtDni.Text;
                    cmd.Parameters.Add(dni);

                    MySqlParameter nombre = new MySqlParameter("pnombre", MySqlDbType.VarChar, 50);
                    nombre.Value = TxtNombre.Text;
                    cmd.Parameters.Add(nombre);

                    MySqlParameter nacimiento = new MySqlParameter("pnacimiento", MySqlDbType.VarChar, 10);
                    nacimiento.Value = mkdNacimiento.Text;
                    cmd.Parameters.Add(nacimiento);

                    MySqlParameter direccion = new MySqlParameter("pdireccion", MySqlDbType.VarChar, 100);
                    direccion.Value = TxtDireccion.Text;
                    cmd.Parameters.Add(direccion);

                    cmd.ExecuteNonQuery();
                    Limpiar();
                    MessageBox.Show("Cliente actualizado");
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
                MessageBox.Show("Cliente no existete");
            } 
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.NombreTrabajador = LabelNombreEmpleado.Text;
            x.Show();
            this.Hide();
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros y letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33) && (e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Caracter no permitido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo caracter de letras ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}

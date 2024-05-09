using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actas
{
    public partial class Usuarios : Form

    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe;PASSWORD=admin;USER ID=admin;");
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand cargarcbxrol = new OracleCommand("select id_roles, descripcion from roles", conexion);
            OracleCommand cargarcbxnom = new OracleCommand("select nombre from usuarios", conexion);

            OracleDataReader carga = cargarcbxrol.ExecuteReader();
            while (carga.Read())
            {
               cbxRolUsuarios.Items.Add(carga["descripcion"].ToString());
            }
            OracleDataReader carga2 = cargarcbxnom.ExecuteReader();
            while (carga2.Read())
            {
                cbxNomUsu.Items.Add(carga2["nombre"].ToString());
            }
            conexion.Close();
            LlenarDatosUsuarios();

            btnCrearUsuarios.Enabled = false;
            btnActuUsuarios.Enabled = false;
            btnEliminarUsuarios.Enabled = false;

            cbxEstatusUs.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRolUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCrearUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cbxNomUsu.Items.Contains(cbxNomUsu.Text))
                    
                {
                    conexion.Open();
                    OracleCommand comandoCrear = new OracleCommand("insertar_usuarios", conexion);
                    string estatus = (cbxEstatusUs.Text == "ACTIVO") ? "A" : "I";
                    comandoCrear.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoCrear.Parameters.Add("nombre", OracleType.VarChar).Value = cbxNomUsu.Text;
                    comandoCrear.Parameters.Add("contra", OracleType.VarChar).Value = txtContUsu.Text;
                    comandoCrear.Parameters.Add("correo", OracleType.VarChar).Value = txtCorreoUsu.Text;
                    comandoCrear.Parameters.Add("id_roles", OracleType.Number).Value = ObtenerIdRolSeleccionado();
                    comandoCrear.Parameters.Add("estatus", OracleType.VarChar).Value = estatus;
                    comandoCrear.ExecuteNonQuery();
                    MessageBox.Show("Usuario Creado");
                    LlenarDatosUsuarios();
                    cbxNomUsu.Items.Add(cbxNomUsu.Text);

                }
                else
                {
                    MessageBox.Show("El usuario ya existe");
                }
            }   
            
            catch (Exception)
            {
                MessageBox.Show("Algo fallo");
            }

            conexion.Close();
        }
        private void LlenarDatosUsuarios()
        {
            OracleCommand mostrarUsuarios = new OracleCommand("mostrar_usuarios", conexion);
            mostrarUsuarios.CommandType = CommandType.StoredProcedure;
            mostrarUsuarios.Parameters.Add("mostrarU", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptadorU = new OracleDataAdapter();
            adaptadorU.SelectCommand = mostrarUsuarios;
            DataTable dt = new DataTable();
            adaptadorU.Fill(dt);
            dgvUsuarios.DataSource = dt;

            cbxNomUsu.Text = "";
            txtContUsu.Text = "";
            cbxRolUsuarios.Text = "";
            txtCorreoUsu.Text = "";
            cbxEstatusUs.Text = "";
          
        }

        private bool CamposEstanLlenos()
        {
            return !string.IsNullOrEmpty(cbxNomUsu.Text) && !string.IsNullOrEmpty(txtContUsu.Text) && !string.IsNullOrEmpty(txtCorreoUsu.Text) && !string.IsNullOrEmpty(cbxRolUsuarios.Text) && !string.IsNullOrEmpty(cbxEstatusUs.Text);
        }

        // Evento TextChanged para ComboBox y TextBox
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            // Verifica si los campos están llenos y habilita o deshabilita los botones en consecuencia
            btnCrearUsuarios.Enabled = CamposEstanLlenos();
            btnActuUsuarios.Enabled = CamposEstanLlenos();
            btnEliminarUsuarios.Enabled = CampoEstanLlenosEliminar();
            
        }
        private bool CampoEstanLlenosEliminar()
        {
            return !string.IsNullOrEmpty(cbxNomUsu.Text);
        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comandoElim = new OracleCommand("eliminar_usu2", conexion);
                comandoElim.CommandType = System.Data.CommandType.StoredProcedure;
                comandoElim.Parameters.Add("nombre", OracleType.VarChar).Value = cbxNomUsu.Text;
                comandoElim.ExecuteNonQuery();
                MessageBox.Show("Usuario Eliminado o desactivado segun corresponda");
                LlenarDatosUsuarios();
                cbxNomUsu.Items.Add(cbxNomUsu.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Algo Fallo");

            }
            conexion.Close();

        }

        private void btnActuUsuarios_Click(object sender, EventArgs e)
        {
                try
                {
                
                
                    conexion.Open();
                    OracleCommand comandoAct = new OracleCommand("actualizar_usu", conexion);
                    string estatus = (cbxEstatusUs.Text == "ACTIVO") ? "A" : "I";
                    comandoAct.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoAct.Parameters.Add("nombre", OracleType.VarChar).Value = cbxNomUsu.Text;
                    comandoAct.Parameters.Add("contra", OracleType.VarChar).Value = txtContUsu.Text;
                    comandoAct.Parameters.Add("correo", OracleType.VarChar).Value = txtCorreoUsu.Text;
                    comandoAct.Parameters.Add("id_roles", OracleType.VarChar).Value = ObtenerIdRolSeleccionado();
                    comandoAct.Parameters.Add("estatus", OracleType.VarChar).Value = estatus;
                    comandoAct.ExecuteNonQuery();
                    MessageBox.Show("Usuario Actualizado");
                    LlenarDatosUsuarios();
                    cbxNomUsu.Items.Add(cbxNomUsu.Text);

                
                                
                
                }
            catch (Exception)
            {
                MessageBox.Show("Algo Fallo");
            }
            conexion.Close();
        }

        /*private int ObtenerIdRolSeleccionado()
        {
            KeyValuePair<int,string> seleccion = (KeyValuePair<int, string>)cbxRolUsuarios.SelectedItem;
            return seleccion.Key;
        }*/

        private int ObtenerIdRolSeleccionado()
        {
            string descripcionSeleccionada = cbxRolUsuarios.SelectedItem.ToString();

            // consulta para obtener el id con la descripcion
            OracleCommand comandoIdRol = new OracleCommand("SELECT id_roles FROM roles WHERE descripcion = :descripcion", conexion);
            comandoIdRol.Parameters.Add("descripcion", OracleType.VarChar).Value = descripcionSeleccionada;
            object result = comandoIdRol.ExecuteScalar();

            // Verifica si el resultado es nulo
            if (result != null)
            {
               
                return Convert.ToInt32(result);
            }
            else
            {
             
                throw new Exception("No se encontró un ID correspondiente a la descripción seleccionada");
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtContUsu.PasswordChar == '*')
                {
                    txtContUsu.PasswordChar = '\0';
                }
            }
            else
            {
                txtContUsu.PasswordChar = '*';
            }
        }
    }
}

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
        //CAMBIO 
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand cargarcbxrol = new OracleCommand("select id_roles from roles", conexion);
            OracleCommand cargarcbxnom = new OracleCommand("select nombre from usuarios", conexion);

            OracleDataReader carga = cargarcbxrol.ExecuteReader();
            while (carga.Read())
            {
                cbxRolUsuarios.Items.Add(carga["id_roles"].ToString());
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
                    comandoCrear.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoCrear.Parameters.Add("nombre", OracleType.VarChar).Value = cbxNomUsu.Text;
                    comandoCrear.Parameters.Add("contra", OracleType.VarChar).Value = txtContUsu.Text;
                    comandoCrear.Parameters.Add("correo", OracleType.VarChar).Value = txtCorreoUsu.Text;
                    comandoCrear.Parameters.Add("id_roles", OracleType.Number).Value = Convert.ToInt32(cbxRolUsuarios.Text);
                    comandoCrear.Parameters.Add("estatus", OracleType.VarChar).Value = cbxEstatusUs.Text;
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
                OracleCommand comandoElim = new OracleCommand("eliminar_usu", conexion);
                comandoElim.CommandType = System.Data.CommandType.StoredProcedure;
                comandoElim.Parameters.Add("nombre", OracleType.VarChar).Value = cbxNomUsu.Text;
                comandoElim.ExecuteNonQuery();
                MessageBox.Show("Usuario Eliminado");
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
                if (!cbxNomUsu.Items.Contains(cbxNomUsu.Text))
                {
                    conexion.Open();
                    OracleCommand comandoAct = new OracleCommand("actualizar_usu", conexion);
                    comandoAct.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoAct.Parameters.Add("nombre", OracleType.VarChar).Value = cbxNomUsu.Text;
                    comandoAct.Parameters.Add("contra", OracleType.VarChar).Value = txtContUsu.Text;
                    comandoAct.Parameters.Add("correo", OracleType.VarChar).Value = txtCorreoUsu.Text;
                    comandoAct.Parameters.Add("id_roles", OracleType.VarChar).Value = Convert.ToInt32(cbxRolUsuarios.Text);
                    comandoAct.Parameters.Add("estatus", OracleType.VarChar).Value = cbxEstatusUs.Text;
                    comandoAct.ExecuteNonQuery();
                    MessageBox.Show("Usuario Actualizado");
                    LlenarDatosUsuarios();
                    cbxNomUsu.Items.Add(cbxNomUsu.Text);

                }
                else
                {
                    MessageBox.Show("Otro Usuario tiene ese nombre");
                }
                }
            catch (Exception)
            {
                MessageBox.Show("Algo Fallo");
            }
            conexion.Close();
        }
    }
}

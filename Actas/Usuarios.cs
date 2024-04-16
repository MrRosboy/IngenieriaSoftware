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
            OracleCommand cargarcbxrol = new OracleCommand("select id_roles from roles", conexion);
            OracleDataReader carga = cargarcbxrol.ExecuteReader();
            while (carga.Read())
            {
                cbxRolUsuarios.Items.Add(carga["id_roles"].ToString());
            }
            carga.Close();
 
            OracleCommand mostrarUsuarios = new OracleCommand("mostrar_usuarios", conexion);
            mostrarUsuarios.CommandType = CommandType.StoredProcedure;
            mostrarUsuarios.Parameters.Add("mostrarU", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptadorU = new OracleDataAdapter();
            adaptadorU.SelectCommand = mostrarUsuarios;
            DataTable dt = new DataTable();
            adaptadorU.Fill(dt);
            dgvUsuarios.DataSource = dt;

            txtNombreUsu.Text = "";
            txtContUsu.Text = "";
            cbxRolUsuarios.Text = "";
            txtCorreoUsu.Text = "";
            cbxEstatusUs.Text = "";
            conexion.Close();

        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCrearUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                
                OracleCommand comandoCrear = new OracleCommand("insertar_usuarios", conexion);
                comandoCrear.CommandType = System.Data.CommandType.StoredProcedure;
                comandoCrear.Parameters.Add("nombre", OracleType.VarChar).Value = txtNombreUsu.Text;
                comandoCrear.Parameters.Add("contra", OracleType.VarChar).Value = txtContUsu.Text;
                comandoCrear.Parameters.Add("correo", OracleType.VarChar).Value = txtCorreoUsu.Text;
                comandoCrear.Parameters.Add("id_roles", OracleType.Number).Value = Convert.ToInt32(cbxRolUsuarios.Text);
                comandoCrear.Parameters.Add("estatus", OracleType.VarChar).Value = cbxEstatusUs.Text;
                comandoCrear.ExecuteNonQuery();
                MessageBox.Show("Usuario Creado");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo");
            }

            conexion.Close();
        }
    }
}

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
    public partial class Proveedores2 : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe;PASSWORD=soft;USER ID=soft;");

        public Proveedores2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Proveedores2_Load(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand cargarcbxdesc = new OracleCommand("select nombre from proveedores", conexion);
            OracleDataReader carga = cargarcbxdesc.ExecuteReader();
            while (carga.Read())
            {
                cbxNom.Items.Add(carga["nombre"].ToString());
            }
            conexion.Close();

            btnCrearProv.Enabled = false;
            btnActProv.Enabled = false;
            btnELimProv.Enabled = false;

            llenarDataProv();


        }

        private void btnCrearProv_Click(object sender, EventArgs e)
        {
            try
            {
                    conexion.Open();
                OracleCommand comandoCrear = new OracleCommand("insertar_prov", conexion);
                comandoCrear.CommandType = System.Data.CommandType.StoredProcedure;
                comandoCrear.Parameters.Add("nombre", OracleType.VarChar).Value = cbxNom.Text;
                comandoCrear.Parameters.Add("direccion", OracleType.VarChar).Value = txtDir.Text;
                comandoCrear.Parameters.Add("telefono", OracleType.VarChar).Value = txtTel.Text;
                comandoCrear.Parameters.Add("descripcion", OracleType.VarChar).Value = txtDes.Text;
                comandoCrear.Parameters.Add("estatus", OracleType.VarChar).Value = cbxEst.Text;
                comandoCrear.ExecuteNonQuery();
                MessageBox.Show("Proveedor Creado");
                llenarDataProv();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo");
            }

            conexion.Close();
        }
        private bool CamposEstanLlenos()
        {
            return !string.IsNullOrEmpty(cbxNom.Text) && !string.IsNullOrEmpty(txtDir.Text) && !string.IsNullOrEmpty(txtTel.Text) && !string.IsNullOrEmpty(txtDes.Text) && !string.IsNullOrEmpty(cbxEst.Text);
        }

        // Evento TextChanged para ComboBox y TextBox
        private void ComboBox_TextChangedP(object sender, EventArgs e)
        {
            // Verifica si los campos están llenos y habilita o deshabilita los botones en consecuencia
            btnCrearProv.Enabled = CamposEstanLlenos();
            btnActProv.Enabled = CamposEstanLlenos();
            btnELimProv.Enabled = CampoEstanLlenosEliminar();
        }

        private void llenarDataProv()
        {

            OracleCommand comando = new OracleCommand("mostrar_prov", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("mostrarP", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvProv.DataSource = dt;

            cbxNom.Text = "";
            txtDir.Text = "";
            txtTel.Text = "";
            txtDes.Text = "";
            cbxEst.Text = "";

        }

        private bool CampoEstanLlenosEliminar()
        {
            return !string.IsNullOrEmpty(cbxNom.Text);
        }
        private void btnELimProv_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comandoElim = new OracleCommand("eliminar_prov", conexion);
                comandoElim.CommandType = System.Data.CommandType.StoredProcedure;
                comandoElim.Parameters.Add("nombre", OracleType.VarChar).Value = cbxNom.Text;
                comandoElim.ExecuteNonQuery();
                MessageBox.Show("Proveedor Eliminado");
                llenarDataProv();

            }
            catch (Exception)
            {
                MessageBox.Show("Algo Fallo");

            }
            conexion.Close();

        }

        private void btnActProv_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comandoAct = new OracleCommand("actualizar_prov", conexion);
                comandoAct.CommandType = System.Data.CommandType.StoredProcedure;
                comandoAct.Parameters.Add("nombre", OracleType.VarChar).Value = cbxNom.Text;
                comandoAct.Parameters.Add("direccion", OracleType.VarChar).Value = txtDir.Text;
                comandoAct.Parameters.Add("telefono", OracleType.Number).Value = Convert.ToInt32(txtTel.Text);
                comandoAct.Parameters.Add("descripcion", OracleType.VarChar).Value = txtDes.Text;
                comandoAct.Parameters.Add("estatus", OracleType.VarChar).Value = cbxEst.Text;
                comandoAct.ExecuteNonQuery();
                MessageBox.Show("Proveedor Actualizado");
                llenarDataProv();

            }
            catch (Exception)
            {
                MessageBox.Show("Algo Fallo");
            }
            conexion.Close();

        }

        private void cbxEst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}


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
    public partial class Compra_Productos : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe;PASSWORD=admin;USER ID=admin;");

        public Compra_Productos()
        {
            InitializeComponent();
        }

        private void Compra_Productos_Load(object sender, EventArgs e)
        {
            cbxProvComPro.DropDownStyle = ComboBoxStyle.DropDownList;
            conexion.Open();
            OracleCommand cargarcbxProvComp = new OracleCommand("select nombre from proveedores", conexion);

            OracleDataReader carga = cargarcbxProvComp.ExecuteReader();
            while (carga.Read())
            {
                cbxProvComPro.Items.Add(carga["nombre"].ToString());
            }
            conexion.Close();

            LlenarProductos();

            btnComprarPro.Enabled = false;
            btnLimpiarPro.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
        private void LlenarProductos()
        {
            DbCompraPro objetos = new DbCompraPro();

            objetos.Tabla = dvgCarrito;
            objetos.LlenarBotones(flCompraPro);
        }

        private bool CamposEstanLlenos()
        {
            return !string.IsNullOrEmpty(cbxProductoComPro.Text) && !string.IsNullOrEmpty(cbxProvComPro.Text);
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            // Verifica si los campos están llenos y habilita o deshabilita los botones en consecuencia
            btnComprarPro.Enabled = CamposEstanLlenos();
            btnLimpiarPro.Enabled = CamposEstanLlenos();
            //btnEliminarRoles.Enabled = CampoEstanLlenosEliminar();
        }
    }
}

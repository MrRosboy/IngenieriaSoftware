using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Actas
{
    public partial class Productos : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe;PASSWORD=admin;USER ID=admin;");
        
        public Productos()
        {
            InitializeComponent();

            ActualizarTabla();
            LlenarCombo();
            LlenarComboNombre();

        }

        public DataTable ConsutaProductosDataGrid()
        {
            conexion.Open();
            String query = "SELECT NOMBRE, PRECIO_VENTA AS PRECIO,EXISTENCIA FROM PRODUCTOS";
            String query2 = "SELECT NOMBRE, PRECIO_VENTA AS PRECIO,DESCRIPCION AS CATEGORIA,EXISTENCIA FROM PRODUCTOS, CATEGORIAS WHERE PRODUCTOS.ID_CATEGORIAS=CATEGORIAS.ID_CATEGORIAS";
            OracleCommand cmd= new OracleCommand(query2, conexion);
            OracleDataAdapter data = new OracleDataAdapter(cmd);

            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
           

        }


        public void ActualizarTabla() {
            dgvProductos.DataSource = ConsutaProductosDataGrid();
        }

        public void LlenarCombo() {
            conexion.Open();
            String query = "SELECT DESCRIPCION FROM CATEGORIAS";
            OracleCommand cmd = new OracleCommand(query, conexion);
            OracleDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                cbxDescCategorias.Items.Add(lector.GetString(0));
            }
            conexion.Close();
        }

        public void LlenarComboNombre() {
            conexion.Open();
            String query = "SELECT NOMBRE FROM PRODUCTOS";
            OracleCommand cmd = new OracleCommand(query, conexion);
            OracleDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                cmbNombrePro.Items.Add(lector.GetString(0));
            }
            conexion.Close();
        }

        public void InsertarDatos() {
            int categoria = ConsultaCategoria(cbxDescCategorias.SelectedItem.ToString());
            String nombre = cmbNombrePro.Text;
            double precio = double.Parse(txtPrecioVen.Text);

            if (ValidacionDeProductos(nombre))
            {

                try
                {
                    conexion.Open();// LO DEL AUTOINCREMENTO
                    String com = "INSERT INTO PRODUCTOS VALUES(0," + categoria + ",'" + nombre + "'," + precio + ",0)";
                    OracleCommand oracom = new OracleCommand(com, conexion);
                    oracom.ExecuteNonQuery();
                    conexion.Close();
                    ActualizarTabla();
                    MessageBox.Show("REGISTRO EXITOSO");
                }
                catch (Exception EX1)
                {
                    MessageBox.Show("ERROR: " + EX1.ToString());
                    conexion.Close();
                }
            }
            else {
                MessageBox.Show("Este Producto ya está registrado");
            
            }
                    
        }

        public int ConsultaCategoria(String categoria) {
            conexion.Open();
            String query = "SELECT ID_CATEGORIAS FROM CATEGORIAS WHERE DESCRIPCION='" + categoria+"'";
            OracleCommand cmd = new OracleCommand(query, conexion);

            int id = int.Parse(cmd.ExecuteOracleScalar().ToString());
            conexion.Close();
            return id;    
        }

        public bool ValidacionDeProductos(String producto) {
            conexion.Open();
            String query = "SELECT COUNT(*) FROM PRODUCTOS WHERE NOMBRE='" + producto+"'";
            OracleCommand cmd = new OracleCommand(query, conexion);
            int existe = int.Parse(cmd.ExecuteOracleScalar().ToString());
            conexion.Close();

            if (existe > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        

        public void EliminarDatos() {
            String nombre = cmbNombrePro.Text;

            if (!ValidacionDeProductos(nombre))
            {
                try
                {
                    conexion.Open();//FALTA VERIFICAR LO DE LA EXISTENCIA Y LO DEL AUTOINCREMENTO
                    String com = "DELETE FROM PRODUCTOS WHERE NOMBRE='" + nombre+"'";
                    OracleCommand oracom = new OracleCommand(com, conexion);
                    oracom.ExecuteNonQuery();
                    conexion.Close();
                    ActualizarTabla();
                    MessageBox.Show("ELIMINACIÓN EXITOSA");
                }
                catch (Exception EX1)
                {
                    MessageBox.Show("ERROR: " + EX1.ToString());
                    conexion.Close();
                }
            }
            else {
                MessageBox.Show("Este Producto no existe");
            }
        }

        public void ActualizarDatos() {
           
            int categoria = ConsultaCategoria(cbxDescCategorias.SelectedItem.ToString());
            String nombre = cmbNombrePro.Text;
            double precio = double.Parse(txtPrecioVen.Text);
            if (!ValidacionDeProductos(nombre))
            {
                try
                {
                    conexion.Open(); 
                    String com1 = "UPDATE PRODUCTOS SET NOMBRE='"+nombre +"' WHERE NOMBRE='" + nombre + "'";
                    String com2 = "UPDATE PRODUCTOS SET ID_CATEGORIAS=" + categoria + " WHERE NOMBRE='" + nombre + "'";
                    String com3 = "UPDATE PRODUCTOS SET PRECIO_VENTA=" + precio + " WHERE NOMBRE='" + nombre + "'";
                    OracleCommand oracom1 = new OracleCommand(com1, conexion);
                    OracleCommand oracom2 = new OracleCommand(com2, conexion);
                    OracleCommand oracom3 = new OracleCommand(com3, conexion);
                    oracom1.ExecuteNonQuery();
                    oracom2.ExecuteNonQuery();
                    oracom3.ExecuteNonQuery();
                    conexion.Close();
                    ActualizarTabla();
                    MessageBox.Show("Actualización EXITOSA");
                }
                catch (Exception EX1)
                {
                    MessageBox.Show("ERROR: " + EX1.ToString());
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Este Producto no existe");
            }
        }

        private bool CamposEstanLlenos()
        {
            return !string.IsNullOrEmpty(cbxDescCategorias.Text) && !string.IsNullOrEmpty(cmbNombrePro.Text) && !string.IsNullOrEmpty(txtPrecioVen.Text);
        }

        // Evento TextChanged para ComboBox y TextBox
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            // Verifica si los campos están llenos y habilita o deshabilita los botones en consecuencia
            btnCrearProductos.Enabled = CamposEstanLlenos();
            btnActualizarProducto.Enabled = CamposEstanLlenos();
            btnEliminarProducto.Enabled = CampoEstanLlenosEliminar();
        }
        private bool CampoEstanLlenosEliminar()
        {
            return !string.IsNullOrEmpty(cmbNombrePro.Text);
        }

        public bool ValidacionDeCampos() {
            if (!CamposEstanLlenos())
            {
                MessageBox.Show("Debe Rellenar TODOS los campos primero");
                return false;
            }
            else {
                return true;
            }
        }

        public void RecuperacionDeDatosAPartirDelNombre() {
            conexion.Open();
            String nombre = cmbNombrePro.Text;

            String query1 = "SELECT ID_CATEGORIAS FROM PRODUCTOS WHERE NOMBRE='" + nombre + "'";
            OracleCommand oracom = new OracleCommand(query1, conexion);

            int idcategorias = int.Parse(oracom.ExecuteOracleScalar().ToString());

            String query2 = "SELECT DESCRIPCION FROM CATEGORIAS WHERE ID_CATEGORIAS=" + idcategorias+ "";
            OracleCommand oracom2 = new OracleCommand(query2, conexion);
            cbxDescCategorias.Text = oracom2.ExecuteOracleScalar().ToString();

            String query3 = "SELECT PRECIO_VENTA FROM PRODUCTOS WHERE NOMBRE='" + nombre + "'";
            OracleCommand oracom3 = new OracleCommand(query3, conexion);

            txtPrecioVen.Text = oracom3.ExecuteOracleScalar().ToString();
            conexion.Close();
        }
        private void btnCrearRoles_Click(object sender, EventArgs e)
        {
            if (ValidacionDeCampos())
            {
                InsertarDatos();
                cmbNombrePro.Items.Clear();
                LlenarComboNombre();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarDatos();
            cmbNombrePro.Items.Clear();
            LlenarComboNombre();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            if (ValidacionDeCampos())
            {
                ActualizarDatos();
                cmbNombrePro.Items.Clear();
                LlenarComboNombre();
            }
        }


        

        private void cmbNombrePro_Leave_1(object sender, EventArgs e)
        {
            if (cmbNombrePro.Items.Count >= 1)
            {
                if (!string.IsNullOrEmpty(cmbNombrePro.Text) && !ValidacionDeProductos(cmbNombrePro.Text))
                {
                    RecuperacionDeDatosAPartirDelNombre();
                }
            }
        }
    }
}

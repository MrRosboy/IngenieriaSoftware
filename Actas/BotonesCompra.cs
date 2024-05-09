using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actas
{
    public partial class BotonesCompra : UserControl
    {
        private int id = 0;
        private String nombre = "";
        private String cantidad = "0";
        private String precio = "0";
        DataGridView tabla = null;
        String nombreTabla;
        String cantidadTabla;
        String precioTabla;
         public BotonesCompra()
        {
            InitializeComponent();
        }
        public void setTabla(DataGridView tab)
        {
            tabla = tab;
        }


        public void disponible(bool dis)
        {

            if (dis)
            {
                btnAgregar.Enabled = true;
                txtCantidad.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
                txtCantidad.Enabled = false;
            }

        }
        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public string Cantidad
        {
            get { return cantidad; }
            set { lbCantidad.Text = value; }

        }

        public String Precio
        {
            get { return precio; }
            set { lbPrecio.Text = value; }

        }

        public String Nombre
        {
            get { return nombre; }
            set { lbNombre.Text = value; }

        }

        public String ImgProducto
        {
            get { return pbProducto.ImageLocation; }
            set { pbProducto.ImageLocation = value; }
        }

        public DataGridView Tabla { get => tabla; set => tabla = value; }
        public string NombreTabla { get => nombreTabla; set => nombreTabla = value; }
        public string CantidadTabla { get => cantidadTabla; set => cantidadTabla = value; }
        public string PrecioTabla { get => precioTabla; set => precioTabla = value; }

        private void ImagenDelProcutoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            String codSub = lbNombre.Text.Substring(21);
            if (!String.IsNullOrEmpty(txtCantidad.Text) && !String.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                int cantidad = Int32.Parse(txtCantidad.Text);

                String precioStr = lbPrecio.Text.Substring(9);

                double precio = Double.Parse(precioStr);

                AgregarProducto(codSub, cantidad, precio);
                txtCantidad.Clear();
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR LA CANTIDAD ANTES DE AGREGAR");
            }

        }

        private void AgregarProducto(String nombre, int cantidad, Double precio)
        {
            double total;
            total = precio * cantidad;
            /*
            Tabla.Rows[Tabla.RowCount - 1].Cells[0].Value = nombre;
            Tabla.Rows[Tabla.RowCount - 1].Cells[1].Value = cantidad;
            Tabla.Rows[Tabla.RowCount - 1].Cells[2].Value = total;*/

            Tabla.Rows.Insert(Tabla.RowCount, "X", nombre, cantidad, total);

        }
       
    }
}

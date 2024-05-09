using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actas
{
    internal class DbCompraPro
    {
        
        private int id_proveedor;
        private int id_usuario;
        private string nombre;
        private int precio_venta;
        private int existencia;
        private String imagen;
        DataGridView tabla = null;

        
        public int Id_categoria { get => id_proveedor; set => id_proveedor = value; }
        public int Id_producto { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public DataGridView Tabla { get => tabla; set => tabla = value; }

        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe;PASSWORD=admin;USER ID=admin;");

        public void LlenarBotones(FlowLayoutPanel contenedor)
        {
            while (contenedor.Controls.Count > 0) contenedor.Controls.RemoveAt(0);
            contenedor.Controls.Clear();

            conexion.Open();
            String consulta = "SELECT * FROM PRODUCTOS";
            OracleCommand comando = new OracleCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            //comando.CommandType = System.Data.CommandType.Text;
            OracleDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id_proveedor = Convert.ToInt32(reader[0]);
                id_usuario = Convert.ToInt32(reader[1]);
                nombre = reader[2].ToString();
                precio_venta = Convert.ToInt32(reader[3]);
                existencia = Convert.ToInt32(reader[4]);
                imagen = reader[5].ToString();

                BotonesCompra btn = new BotonesCompra();

                btn.Id = id_proveedor;
                btn.Nombre = "Nombre del Producto: " + nombre;
                btn.Precio = "Precio: $" + precio_venta.ToString();
                btn.Cantidad = "Disponibles: " + existencia.ToString();
                btn.ImgProducto = imagen;
                btn.NombreTabla = nombre;
                btn.PrecioTabla = precio_venta.ToString();
                btn.Tabla = tabla;

                bool dispo;

                if (existencia > 0)
                {
                    dispo = true;
                }
                else
                {

                    dispo = false;
                }

                btn.disponible(dispo);


                contenedor.Controls.Add(btn);

            }
            conexion.Close();


        }

        public void LlenarBotonesEspecifico(FlowLayoutPanel contenedor, String Nombre)
        {

            while (contenedor.Controls.Count > 0) contenedor.Controls.RemoveAt(0);
            contenedor.Controls.Clear();

            conexion.Open();


            String consulta = "SELECT * FROM PRODUCTOS WHERE NOMBRE='" + Nombre + "'";

            OracleCommand comando = new OracleCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            //comando.CommandType = System.Data.CommandType.Text;
            OracleDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id_proveedor = Convert.ToInt32(reader[0]);
                id_usuario = Convert.ToInt32(reader[1]);
                nombre = reader[2].ToString();
                precio_venta = Convert.ToInt32(reader[3]);
                existencia = Convert.ToInt32(reader[4]);
                imagen = reader[5].ToString();

                BotonesCompra btn = new BotonesCompra();

                btn.Id = id_proveedor;
                btn.Nombre = "Nombre del Producto: " + nombre;
                btn.Precio = "Precio: $" + precio_venta.ToString();
                btn.Cantidad = "Disponibles: " + existencia.ToString();
                btn.ImgProducto = imagen;
                btn.NombreTabla = nombre;
                btn.PrecioTabla = precio_venta.ToString();
                btn.Tabla = tabla;

                bool dispo;

                if (existencia > 0)
                {
                    dispo = true;
                }
                else
                {

                    dispo = false;
                }

                btn.disponible(dispo);


                contenedor.Controls.Add(btn);

            }
            conexion.Close();

        }



    }
}


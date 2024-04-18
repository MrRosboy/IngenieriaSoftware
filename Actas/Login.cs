using System;
using System.Data.OracleClient;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe;PASSWORD=soft;USER ID=soft;");
        private void btnLogin_Click(object sender, EventArgs e) //Eventos que suceden al hacer click en el botón "Login"
        {
            conexion.Open(); 
            OracleCommand comando = new OracleCommand("SELECT * FROM personas WHERE usuario = :usuario AND contra = :contra", conexion);

            comando.Parameters.AddWithValue(":usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue(":contra", txtContraseña.Text);

            OracleDataReader lector = comando.ExecuteReader();

            if (lector.Read())   //Condicional
            {
                //interfaz inter = new interfaz();
                Menu inter = new Menu();
                conexion.Close();
                inter.Show();
                //inter.Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña son incorrectos");
                conexion.Close();
            }
        }

        private void Limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

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

        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe;PASSWORD=admin;USER ID=admin;");
        private void btnLogin_Click(object sender, EventArgs e) //Eventos que suceden al hacer click en el botón "Login"
        {
            conexion.Open(); 
            OracleCommand comando = new OracleCommand("SELECT * FROM personas WHERE usuario = :usuario AND contra = :contra", conexion);

            comando.Parameters.AddWithValue(":usuario", txtUsuario.Text);
            string contraL = contra();
            comando.Parameters.AddWithValue(":contra", contraL);

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

        private string contra()
        {
            try
            {
                OracleCommand comandoExist = new OracleCommand("SELECT * FROM personas WHERE usuario = :usuario", conexion);
                comandoExist.Parameters.AddWithValue(":usuario", txtUsuario.Text);
                OracleDataReader lector = comandoExist.ExecuteReader();

                if (lector.Read())
                {



                    OracleCommand comandoDesen = new OracleCommand("SELECT cryptit.decrypt_data(CONTRA) CONTRA FROM personas WHERE usuario= :usuario", conexion);
                    comandoDesen.Parameters.AddWithValue(":usuario", txtUsuario.Text);

                    String contrades = comandoDesen.ExecuteOracleScalar().ToString();

                    if (contrades.Equals(txtContraseña.Text))
                    {

                        OracleCommand comandoEncr = new OracleCommand("SELECT CONTRA FROM personas WHERE usuario= :usuario", conexion);
                        comandoEncr.Parameters.AddWithValue(":usuario", txtUsuario.Text);
                        String contrades2 = comandoEncr.ExecuteOracleScalar().ToString();
                        return contrades2;
                    }
                    else
                    {
                        return "";
                    }

                }
                else
                {

                    return "";
                }
            }
            catch (Exception ex)
            {

                return "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
               if (txtContraseña.PasswordChar == '*')
                {
                    txtContraseña.PasswordChar = '\0';
                } 
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }
    }
}

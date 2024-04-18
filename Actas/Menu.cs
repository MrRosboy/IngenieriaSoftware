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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roles interfazRoles = new Roles();   
            interfazRoles.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios interfazUsuarios = new Usuarios();
            interfazUsuarios.Show();
        }

        private void btnProv_Click(object sender, EventArgs e)
        {
            Proveedores2 intProv= new Proveedores2();
            intProv.Show();
        }
    }
}

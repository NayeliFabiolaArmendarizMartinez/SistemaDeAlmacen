using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlmacen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "Admin" && (tbxContraseña.Text == "1234"))
            {
                this.Hide();
                Menuu frm = new Menuu();
                frm.Show();
            }

            else
            {
                MessageBox.Show("Datos erróneos, intente de nuevo");
                tbxUsuario.Text = "";
                tbxContraseña.Text = "";

            }
        }
    }
}

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
        //Menuu logeo;
        //Menuu acceso = new Menuu();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Menuu m = new Menuu();

            if (tbxUsuario.Text == "Admin" && (tbxContraseña.Text == "1234"))
            {

                this.Hide();
                Menuu frm = new Menuu();
                frm.Show();

                /*this.Hide();
                acceso = new Menuu();
                acceso.ShowDialog();*/

                //this.DialogResult = DialogResult;
                //this.Hide();
                // m.ShowDialog();

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

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
        Menuu logeo;
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Menuu m = new Menuu();

            if (tbxUsuario.Text == "Admin" && tbxContraseña.Text == "1234")
            {

                this.Hide();
                logeo = new Menuu();
                logeo.ShowDialog();

                //this.DialogResult = DialogResult;
                //this.Hide();
                // m.ShowDialog();

            }


            else
            {
                lbError.Visible = true;
                this.DialogResult = DialogResult.None;

            }
        }
    }
}

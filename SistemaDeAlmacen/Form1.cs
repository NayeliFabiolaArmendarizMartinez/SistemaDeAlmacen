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
            if (tbxUsuario.Text == "Administrador" && tbxContraseña.Text == "1234")
                this.DialogResult = DialogResult.OK;
            else
            {
                lbError.Visible = true;
                this.DialogResult = DialogResult.None;

            }
        }
    }
}

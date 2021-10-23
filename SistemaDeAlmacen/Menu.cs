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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuProductos frm= new MenuProductos();
            frm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Login obj = new Login();

            if (obj.ShowDialog() != DialogResult.OK)
                this.Close();
        }
    }
}

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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvProducto);
            fila.Cells[0].Value = txtCodigo.Text;
            fila.Cells[1].Value = txtDescripcion.Text;
            fila.Cells[2].Value = txtCategoria.Text;
            fila.Cells[3].Value = txtAlmacen.Text;

            dgvProducto.Rows.Add(fila);

            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCategoria.Text = "";
            txtAlmacen.Text = "";
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resp = MessageBox.Show("¿Desea eliminar este producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    dgvProducto.Rows.Remove(dgvProducto.CurrentRow);
                }
            }
            catch { }
        }
    }
}

using _48284_TP6.Presentadores;
using _48284_TP6.Vistas;
using System;
using System.Windows.Forms;

namespace _48284_TP6_Presentacion
{
    public partial class GestorProductoVista : Form
    {
        public GestorProductoVista()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productos = new ListaProductosVista();
            productos.MdiParent = this;
            productos.Show();
            productos.WindowState = FormWindowState.Maximized;
        }
    }
}

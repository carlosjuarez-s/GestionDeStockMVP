using _48284_TP6.Interfaces;
using _48284_TP6.Presentadores;
using _48284_TP6.Vistas;
using _48284_TP6_Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48284_TP6_Presentacion
{
    public partial class GestorProductoVista : Form
    {
        private GestorProductoPresentador _presentador;

        public GestorProductoVista()
        {
            InitializeComponent();
        }

        private void GestorProductoVista_Load(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productos = new ListaProductosVista();
            productos.MdiParent = this;
            productos.Show();
            productos.WindowState = FormWindowState.Maximized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

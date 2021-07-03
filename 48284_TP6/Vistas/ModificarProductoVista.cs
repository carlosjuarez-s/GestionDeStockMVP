using _48284_TP6.Interfaces;
using _48284_TP6.Presentadores;
using _48284_TP6__Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48284_TP6.Vistas
{
    public partial class ModificarProductoVista : Form, IGestorModificarProducto
    {
        private GestorModificarProductoPresentador _presentador;
        private int _productoCodigo;

        public ModificarProductoVista(int v)
        {
            InitializeComponent();
            _presentador = new GestorModificarProductoPresentador(this);
            _productoCodigo = v;
            var productoClon = _presentador.BuscarProductoPorCodigo(_productoCodigo);
            comboBoxEstado.DataSource = Enum.GetValues(typeof(Estado));
            bsModificarProducto.DataSource = productoClon.Clone();
        }

        private void txtCostoSinIva_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarProductoVista_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            var producto = bsModificarProducto.Current as Producto;
            _presentador.ModificarProducto(producto);
            Dispose();
        }

        public bool ConfirmarModificarProducto(string mensaje)
        {
            return MessageBox.Show(mensaje, "Modificar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}

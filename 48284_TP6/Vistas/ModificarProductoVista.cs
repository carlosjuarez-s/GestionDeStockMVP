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

        private void ModificarProductoVista_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {

            if(VerficarCampos())
            {
                var producto = bsModificarProducto.Current as Producto;
                _presentador.ModificarProducto(producto);
                Dispose();
            }
        }

        public bool VerficarCampos()
        {
            var output = " ";
            if (txtCodigo.Text.ToString() == "0")
            {
                output = lblCodigo.Text.ToString();
                txtCodigo.BackColor = Color.Aqua;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text.ToString()))
            {
                output = lblDescripcion.Text.ToString();
                txtDescripcion.BackColor = Color.Aqua;
            }
            if (txtCostoSinIva.Text.ToString() == "0")
            {
                output = lblCostoSinIva.Text.ToString();
                txtCostoSinIva.BackColor = Color.Aqua;
            }
            if (txtPorcentajeIva.Text.ToString() == "0")
            {
                output = lblPorcentajeIva.Text.ToString();
                txtPorcentajeIva.BackColor = Color.Aqua;
            }
            if (txtExistencia.Text.ToString() == "0")
            {
                output = lblExistencia.Text.ToString();
                txtExistencia.BackColor = Color.Aqua;
            }
            if (output == " ") return true;

            _presentador.MensajeCampoFaltante(output);

            return false;
        }

        public bool ConfirmarModificarProducto(string mensaje)
        {
            return MessageBox.Show(mensaje, "Modificar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public bool ConfirmacionCampoFaltante(string mensaje)
        {
            return MessageBox.Show(mensaje, "Campo Faltante", MessageBoxButtons.OK) == DialogResult.OK;
        }

        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {
            txtExistencia.BackColor = Color.White;
        }

        private void txtCostoSinIva_TextChanged(object sender, EventArgs e)
        {
            txtCostoSinIva.BackColor = Color.White;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }
    }
}

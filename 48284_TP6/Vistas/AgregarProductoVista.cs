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
    public partial class AgregarProductoVista : Form, IGestorAgregarProducto
    {
        private GestorAgregarProductoPresentador _presentador;

        public AgregarProductoVista()
        {
            InitializeComponent();
            _presentador = new GestorAgregarProductoPresentador(this);
            bsAgregarProducto.DataSource = new Producto();

            comboBoxEstado.DataSource = Enum.GetValues(typeof(Estado));

           
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (VerficarCampos())
            {
                var producto = bsAgregarProducto.DataSource;
                _presentador.CrearProducto((Producto)producto);
                _presentador.ConfirmacionDeCreacion();
                Dispose();
            }
        }

        public bool ConfirmarCreacion(string mensaje)
        {
            return MessageBox.Show(mensaje, "Creacion de Producto", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public void ConfirmacionCreacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Creacion de Producto", MessageBoxButtons.OK);
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
            if(output == " ") return true;

            _presentador.MensajeCampoFaltante(output);

            return false;
        }

        public bool ConfirmacionCampoFaltante(string mensaje)
        {
            return MessageBox.Show(mensaje, "Campo Faltante", MessageBoxButtons.OK) == DialogResult.OK;
        }

        private void lblCostoConIva_Click(object sender, EventArgs e)
        {

        }

        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {
            txtExistencia.BackColor = Color.White;
        }

        private void lblExistencia_Click(object sender, EventArgs e)
        {

        }

        private void txtPorcentajeIva_TextChanged(object sender, EventArgs e)
        {
            txtPorcentajeIva.BackColor = Color.White;
            txtPorcentajeIva.Text.Replace("%", "");
            /*if(!txtPorcentajeIva.Text.ToString().Contains("%"))
            {
                var numeros = txtPorcentajeIva.Text.ToString();
                txtPorcentajeIva.Text = string.Concat(numeros, "%");
            }*/
        }

        private void lblPorcentajeIva_Click(object sender, EventArgs e)
        {

        }

        private void txtCostoSinIva_TextChanged(object sender, EventArgs e)
        {
            txtCostoSinIva.BackColor = Color.White;
        }

        private void lblCostoSinIva_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void txtCostoConIva_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.BackColor = Color.White;
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMargenGanancia_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProductoVista_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioFinal_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMargenDeGanacia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
            var codigoActual = int.Parse(txtCodigo.Text.ToString());

            if (VerficarCampos() && _presentador.ComprobarExistenciaProducto(codigoActual) != true)
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

        public bool ConfirmacionProductoExistente(string mensaje)
        {
            return MessageBox.Show(mensaje, "Producto Existente", MessageBoxButtons.OK) == DialogResult.OK;
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


        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {
            txtExistencia.BackColor = Color.White;
        }

        private void txtCostoSinIva_TextChanged(object sender, EventArgs e)
        {
            txtCostoSinIva.BackColor = Color.White;
        }

        private void txtCostoSinIva_TabIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }


        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.BackColor = Color.White;
        }


        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

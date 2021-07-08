using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _48284_TP6.Interfaces;
using _48284_TP6.Presentadores;
using _48284_TP6_Persistencia;

namespace _48284_TP6.Vistas
{
    public partial class ListaProductosVista : Form, IGestorProducto
    {
        private GestorProductoPresentador _presentador;

        public ListaProductosVista()
        {
            InitializeComponent();
            _presentador = new GestorProductoPresentador(this);
            productoBindingSource.DataSource = PersistenciaDeDatos.GetProductos();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = _presentador.BuscarProductosPorDescripcion(txtDescripcion.Text);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public int ObtenerCodigoProductoSeleccionado()
        {
            DataGridViewRow filaSeleccionada = dataGridProductos.Rows[dataGridProductos.CurrentCell.RowIndex];
            return int.Parse(filaSeleccionada.Cells[0].Value.ToString());
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            _presentador.EliminarProducto(ObtenerCodigoProductoSeleccionado());
            productoBindingSource.ResetBindings(true);
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            var codigo = ObtenerCodigoProductoSeleccionado();
            var modificarProductoVista = new ModificarProductoVista(codigo);
            modificarProductoVista.StartPosition = FormStartPosition.CenterParent;
            modificarProductoVista.ShowDialog();
            productoBindingSource.ResetBindings(true);
        }

        private void IconCrearProducto_Click(object sender, EventArgs e)
        {
            var agregarProducto = new AgregarProductoVista();
            agregarProducto.StartPosition = FormStartPosition.CenterParent;
            agregarProducto.ShowDialog();
            productoBindingSource.ResetBindings(true);
        }

        public bool ConfirmarEliminarProducto(string mensaje)
        {
            return MessageBox.Show(mensaje, "Eliminar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void ListaProductosVista_Load(object sender, EventArgs e)
        {
            
        }

        private void productoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridProductos.Sort(this.dataGridProductos.Columns[0], ListSortDirection.Ascending);
        }
    }
}

using _48284_TP6.Interfaces;
using _48284_TP6__Dominio;
using _48284_TP6_Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48284_TP6.Presentadores
{
    public class GestorProductoPresentador
    {
        private readonly IGestorProducto _vista;
        

        public GestorProductoPresentador(IGestorProducto vista)
        {
            _vista = vista;
            PersistenciaDeDatos.IniciarPersistencia();
        }

        public List<Producto> BuscarProductosPorDescripcion(string descripcion)
        {
            return PersistenciaDeDatos.BuscarProductos(descripcion);
        } 

        public void EliminarProducto(int codigo)
        {
            var producto = PersistenciaDeDatos.BuscarProducto(codigo);

            if (producto != null)
            {
                if(_vista.ConfirmarEliminarProducto($"¿Desea eliminar el producto {producto.Descripcion}?"))
                {
                    PersistenciaDeDatos.EliminarProducto(producto);
                }

            }
        }
    }
}

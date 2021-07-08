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
    public class GestorModificarProductoPresentador
    {
        private readonly IGestorModificarProducto _vista;

        public GestorModificarProductoPresentador(IGestorModificarProducto vista)
        {
            _vista = vista;
        }

        public void ModificarProducto(Producto producto)
        {
            if(_vista.ConfirmarModificarProducto($"¿Desea guardar los cambios?"))
            {
                if(BuscarProductoPorCodigo(producto.Codigo) != null)
                {
                    PersistenciaDeDatos.ActualizaProducto(producto);
                }
            }
        }

        public Producto BuscarProductoPorCodigo(int codigo)
        {
            return PersistenciaDeDatos.BuscarProducto(codigo);
        }

        public bool MensajeCampoFaltante(string campo)
        {
            return _vista.ConfirmacionCampoFaltante($"Por favor ingrese complete el Campo: {campo}");
        }
    }
}

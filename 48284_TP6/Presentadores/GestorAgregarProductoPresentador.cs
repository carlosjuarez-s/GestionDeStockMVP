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
    public class GestorAgregarProductoPresentador
    {
        private readonly IGestorAgregarProducto _vistaAgregarProducto;

        public GestorAgregarProductoPresentador(IGestorAgregarProducto vista)
        {
            _vistaAgregarProducto = vista;
        }

        public bool CrearProducto(Producto producto)
        {
            if(_vistaAgregarProducto.ConfirmarCreacion($"¿Desea crear el producto: {producto.Descripcion}?"))
            {
                PersistenciaDeDatos.AgregarProducto(producto);
                return true;
            }

            return false;
        }

        public void ConfirmacionDeCreacion()
        {
            _vistaAgregarProducto.ConfirmacionCreacion("El Producto se agregó con exito!");
        }
        

        public bool MensajeCampoFaltante(string campo)
        {
            return _vistaAgregarProducto.ConfirmacionCampoFaltante($"Por favor ingrese complete el Campo: {campo}");
        }

        public string RecalcularMargen(double precioFinal, double costoConIva)
        {
            try
            {
                var output = (precioFinal - costoConIva) / costoConIva;
                return output.ToString();
            }
            catch
            {
                return "0";
            }
        }
    }
}

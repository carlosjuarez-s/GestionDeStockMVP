using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48284_TP6.Interfaces
{
    public interface IGestorAgregarProducto
    {
        bool ConfirmarCreacion(string mensaje);
        void ConfirmacionCreacion(string mensaje);
        bool ConfirmacionCampoFaltante(string mensaje);
    }
}

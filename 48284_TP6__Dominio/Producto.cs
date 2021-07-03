using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48284_TP6__Dominio
{
    public class Producto : ICloneable
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double CostoSinIva { get; set; }
        public double MargenGanancia { get; set; }
        public int Existencia { get; set; }
        public Estado Estado { get; set; }
        public double PorcentajeIva { get; set; }

        public double CostoConIva => CostoSinIva + CostoSinIva * PorcentajeIva;

        public double PrecioFinal => CostoConIva + CostoConIva * MargenGanancia;

        public object Clone()
        {
            return (Producto)MemberwiseClone();
        }
    }
}

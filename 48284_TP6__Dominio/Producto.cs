using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48284_TP6__Dominio
{
    public class Producto : ICloneable
    {
        private double _porcentajeIva;
        private double _margenGanancia;

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double CostoSinIva { get; set; }
        public double MargenGanancia
        {
            get => _margenGanancia;
            set
            {
                _margenGanancia = (value + ((PrecioFinal - CostoConIva) / CostoConIva)) / 100;
            }
        }
        public int Existencia { get; set; }
        public Estado Estado { get; set; }
        public double PorcentajeIva
        {
            get => _porcentajeIva;
            set
            {
                if (value > 0) _porcentajeIva = value / 100;
            }
        }

        public double CostoConIva
        {
            get
            {
                if(CostoSinIva > 0) return CostoSinIva + CostoSinIva * PorcentajeIva;
                return 0;
            }
        } 

        public double PrecioFinal => CostoConIva + CostoConIva * MargenGanancia;

        public object Clone()
        {
            return (Producto)MemberwiseClone();
        }
    }
}

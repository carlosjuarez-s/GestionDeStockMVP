using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _48284_TP6__Dominio;

namespace _48284_TP6_Persistencia
{
    public static class PersistenciaDeDatos
    {
        public static List<Producto> Productos = new List<Producto>();

        
        public static void IniciarPersistencia()
        {
            Productos = new List<Producto>
            {
                new Producto {Codigo = 0001, Descripcion = "Coca Cola 3L", CostoSinIva = 110, Estado = Estado.Activo,
                          Existencia = 100, PorcentajeIva = 5, MargenGanancia = 10},
                new Producto {Codigo = 0002, Descripcion = "Hamburguesas", CostoSinIva = 80, Estado = Estado.Inactivo,
                          Existencia = 500, PorcentajeIva = 15, MargenGanancia = 20},
                new Producto {Codigo = 0025, Descripcion = "Lecha descremada", CostoSinIva = 20, Estado = Estado.Activo,
                          Existencia = 50, PorcentajeIva = 2, MargenGanancia = 30},
                new Producto {Codigo = 1005, Descripcion = "Aceite", CostoSinIva = 65, Estado = Estado.Inactivo,
                          Existencia = 200, PorcentajeIva = 20, MargenGanancia = 60},
                new Producto {Codigo = 9850, Descripcion = "Fideos", CostoSinIva = 15, Estado = Estado.Activo,
                          Existencia = 350, PorcentajeIva = 10, MargenGanancia = 70},
            };
        }

        public static List<Producto> GetProductos()
        {
            return Productos;
        }

        public static Producto BuscarProducto(int codigo)
        {
            foreach(Producto producto in Productos)
            {
                if (producto.Codigo == codigo) return producto;
            }

            return null;
        }

        public static List<Producto> BuscarProductos(string letras)
        {
            List<Producto> productosConLetras = new List<Producto>();

            foreach(Producto producto in Productos)
            {
                if (producto.Descripcion.ToUpper().Contains(letras.ToUpper()))
                {
                    productosConLetras.Add(producto);
                }
            }

            return productosConLetras;
        }

        public static void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public static void EliminarProducto(Producto producto)
        {
            Productos.Remove(producto);
        }

        public static void ActualizaProducto(Producto producto)
        {
            var nuevoProducto = new Producto();
            var viejoProducto = BuscarProducto(producto.Codigo);

            nuevoProducto.Codigo = producto.Codigo;
            nuevoProducto.Descripcion = producto.Descripcion;
            nuevoProducto.CostoSinIva = producto.CostoSinIva;
            nuevoProducto.Estado = producto.Estado;
            nuevoProducto.Existencia = producto.Existencia;
            nuevoProducto.PorcentajeIva = producto.PorcentajeIva;
            nuevoProducto.PorcentajeIva = producto.PorcentajeIva;
            nuevoProducto.MargenGanancia = producto.MargenGanancia;

            AgregarProducto(nuevoProducto);
            EliminarProducto(viejoProducto);
        }

    }
}

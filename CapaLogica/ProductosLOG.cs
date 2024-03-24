using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProductosLOG
    {
        ProductosDAL _productoDAL;

        public int EliminarProducto(int id)
        {
            _productoDAL = new ProductosDAL();
            return _productoDAL.EliminarProducto(id);
        }

        public int Guardar(Producto producto, int Id, bool actualizando = false)
        {
            _productoDAL = new ProductosDAL();
            return _productoDAL.Guardar(producto, Id, actualizando);
        }

        public List<Producto> Lista(bool activos = true)
        {
            _productoDAL = new ProductosDAL();
            return _productoDAL.Lista(activos);
        }

        public List<Producto> ListaFiltro(int codigo, string nombre, bool activos = true)
        {
            _productoDAL = new ProductosDAL();

            return _productoDAL.ListaFiltro(codigo, nombre, activos);
        }

        public Producto ObtenerProducto(int id)
        {
            _productoDAL = new ProductosDAL();

            return _productoDAL.ObtenerProducto(id);
        }
    }
}

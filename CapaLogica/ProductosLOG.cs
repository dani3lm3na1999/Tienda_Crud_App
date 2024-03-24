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

            List<Producto> listado = _productoDAL.Lista();

            if (codigo > 0)
            {
                return listado.Where(p => p.ProductoId == codigo && p.Estado == activos).ToList();
            }
            else if (!string.IsNullOrEmpty(nombre))
            {
                return listado.Where(p => p.Nombre.Contains(nombre) && p.Estado == activos).ToList();
            }
            else
            {
                return listado.Where(p => p.ProductoId == codigo && p.Nombre.Contains(nombre) && p.Estado == activos).ToList();
            }            
        }

        public Producto ObtenerProducto(int id)
        {
            _productoDAL = new ProductosDAL();

            return _productoDAL.ObtenerProducto(id);
        }
    }
}

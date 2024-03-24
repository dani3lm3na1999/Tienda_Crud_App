using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductosDAL
    {
        Tienda_DbContext _db;

        public int EliminarProducto(int id)
        {
            _db = new Tienda_DbContext();
            int resultado;

            var producto = _db.Productos.Find(id);

            if(producto != null)
            {
                producto.Estado = false;
                _db.SaveChanges();
                resultado = producto.ProductoId;
            }
            else
            {
                resultado = 0;
            }

            return resultado;
        }

        public int Guardar(Producto producto, int id, bool actualizando = false)
        {
            _db = new Tienda_DbContext();

            Producto consulta = new Producto();
            int resultado;

            if (actualizando)
            {
                producto.ProductoId = id;

                _db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Productos.Add(producto);
                _db.SaveChanges();
            }

            resultado = producto.ProductoId;

            return resultado;
        }

        public List<Producto> Lista(bool activos = true)
        {
            _db = new Tienda_DbContext();

            return _db.Productos.Where(x => x.Estado == activos).ToList();
        }

        public List<Producto> ListaFiltro(int codigo, string nombre, bool activos = true)
        {
            _db = new Tienda_DbContext();
            List<Producto> listado = new List<Producto>();

            if (codigo > 0)
            {
                listado.Add(_db.Productos.Where(x => x.ProductoId == codigo && x.Estado == activos).FirstOrDefault());
            }
            else if(!string.IsNullOrEmpty(nombre))
            {
                listado = _db.Productos.Where(x => x.Nombre.Contains(nombre) && x.Estado == activos).ToList();
            }
            else
            {
                listado.Add(_db.Productos.Where(x => x.ProductoId == codigo && x.Nombre.Contains(nombre) && x.Estado == activos).FirstOrDefault());
            }

            return listado;
        }

        public Producto ObtenerProducto(int id)
        {
            _db = new Tienda_DbContext();

            return _db.Productos.Find(id);
        }
    }
}

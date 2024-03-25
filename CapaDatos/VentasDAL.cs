using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentasDAL
    {
        ContextoBD _db;

        public int Guardar(Venta venta, int id, bool actualizando = false)
        {
            _db = new ContextoBD();
            int resultado;

            if (actualizando)
            {
                _db.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Ventas.Add(venta);
                _db.SaveChanges();
                
            }
            resultado = venta.VentaId;

            return resultado;
        }

        public List<Venta> Lista(DateTime fechaIni, DateTime fechaFin)
        {
            _db = new ContextoBD();

            return _db.Ventas.Where(v => v.FechaVenta > fechaIni.Date && v.FechaVenta < fechaFin.Date).ToList();
        }
    }


}

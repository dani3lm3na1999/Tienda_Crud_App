using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VentasLOG
    {
        VentasDAL _ventaDAL;

        public int Guardar(Venta venta, int id, bool actualizando = false)
        {
            _ventaDAL = new VentasDAL();

            return _ventaDAL.Guardar(venta, id, actualizando); 
        }

        public List<Venta> Lista()
        {
            _ventaDAL = new VentasDAL();

            return _ventaDAL.Lista();
        }
    }
}

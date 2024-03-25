using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class DetalleLOG
    {
        DetalleDAL _detalleDAL;

        public List<FacturaVentaDTO> FacturaVenta(int id)
        {
            _detalleDAL = new DetalleDAL();

            return _detalleDAL.FacturaVenta(id);
        }

        public List<FacturaVentaDTO> ReporteVentas(DateTime fechaIni, DateTime fechaFin)
        {
            _detalleDAL = new DetalleDAL();

            return _detalleDAL.ReporteVentas(fechaIni, fechaFin);
        }
    }
}

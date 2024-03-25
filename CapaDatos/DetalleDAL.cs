using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetalleDAL
    {
        ContextoBD _db;

        public List<FacturaVentaDTO> FacturaVenta(int id)
        {
            _db = new ContextoBD();

            var factura = from dt in _db.Detalle
                          where dt.VentaId == id
                          select new FacturaVentaDTO
                          {
                              Codigo = dt.VentaId,
                              Fecha = dt.Venta.FechaVenta,
                              Producto = dt.Producto.Nombre,
                              Cantidad = dt.Cantidad,
                              SubTotal = (dt.Cantidad * dt.Precio),
                              Total = dt.Venta.TotalVenta
                          };

            return factura.ToList();
        }

        public List<FacturaVentaDTO> ReporteVentas(DateTime fechaIni, DateTime fechaFin)
        {
            _db = new ContextoBD();

            var factura = from dt in _db.Detalle
                          where dt.Venta.FechaVenta > fechaIni && dt.Venta.FechaVenta < fechaFin
                          select new FacturaVentaDTO
                          {
                              Codigo = dt.VentaId,
                              Fecha = dt.Venta.FechaVenta,
                              Producto = dt.Producto.Nombre,
                              Precio = dt.Precio,
                              Cantidad = dt.Cantidad,
                              SubTotal = (dt.Cantidad * dt.Precio),
                              Total = dt.Venta.TotalVenta
                          };

            return factura.ToList();
        }
    }
}

using CapaVista.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Visores
{
    public partial class VisorRptFactura : Form
    {
        private CapaEntidades.Venta _venta;
        List<CapaEntidades.Producto> _productos;
        private RptFacturaVenta objRpt;
        public VisorRptFactura(CapaEntidades.Venta venta, List<CapaEntidades.Producto> productos)
        {
            InitializeComponent();
            _venta = venta;
            _productos = productos;
            CargarReporte();
            crvFactura.AllowedExportFormats = (int)CrystalDecisions.Shared.ViewerExportFormats.PdfFormat;
        }

        private void CargarReporte()
        {
            try
            {
                objRpt = new RptFacturaVenta();

                var factura = from v in _venta.Detalles
                              join p in _productos on v.ProductoId equals p.ProductoId
                              select new
                              {
                                  Codigo = v.Venta.VentaId,
                                  Fecha = v.Venta.FechaVenta,
                                  Producto = p.Nombre,
                                  v.Cantidad,
                                  SubTotal = (v.Cantidad * v.Precio),
                                  Total = v.Venta.TotalVenta
                              };

                objRpt.SetDataSource(factura);
                crvFactura.ReportSource = objRpt;                              
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango, El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

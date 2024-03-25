using CapaLogica;
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
    public partial class VisorRptVentas : Form
    {
        DetalleLOG _controlDetalle;
        private DateTime _fechaIni;
        private DateTime _fechaFin;
        private RptVentas objRptVentas;

        public VisorRptVentas(DateTime fechaIni, DateTime fechaFin)
        {
            InitializeComponent();
            _fechaIni = fechaIni;
            _fechaFin = fechaFin;
            GenerarReporte();
            crvRptVentas.AllowedExportFormats = (int)CrystalDecisions.Shared.ViewerExportFormats.PdfFormat;
        }

        private void GenerarReporte()
        {
            try
            {
                _controlDetalle = new DetalleLOG();
                objRptVentas = new RptVentas();

                var reporte = _controlDetalle.ReporteVentas(_fechaIni, _fechaFin);

                objRptVentas.SetDataSource(reporte);
                crvRptVentas.ReportSource = objRptVentas;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango, El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

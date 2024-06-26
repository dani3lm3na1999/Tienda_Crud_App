﻿using CapaLogica;
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
        DetalleLOG _controlDetalle;
        private int _ventaId;
        private RptFacturaVenta objRpt;
        public VisorRptFactura(int ventaId)
        {
            InitializeComponent();
            _ventaId = ventaId;
            CargarReporte();
            crvFactura.AllowedExportFormats = (int)CrystalDecisions.Shared.ViewerExportFormats.PdfFormat;
        }

        private void CargarReporte()
        {
            try
            {
                _controlDetalle = new DetalleLOG();
                objRpt = new RptFacturaVenta();

                var factura = _controlDetalle.FacturaVenta(_ventaId);

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

using CapaLogica;
using CapaVista.Visores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MantenimientoVentas : Form
    {
        VentasLOG _controlVenta;

        public MantenimientoVentas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerVentas();
        }

        private void ObtenerVentas()
        {
            try
            {
                _controlVenta = new VentasLOG();

                var ventas = _controlVenta.Lista(dtpFechaIni.Value.Date, dtpFechaFin.Value.Date.AddDays(1));
                dgvDetalleVentas.DataSource = ventas;

                txtMontoTotal.Text = ventas.Sum(x => x.TotalVenta).ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango, El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int codigo = int.Parse(dgvDetalleVentas.Rows[e.RowIndex].Cells["VentaId"].Value.ToString());

                if (dgvDetalleVentas.Columns[e.ColumnIndex].Name.Equals("Imprimir"))
                {
                    VisorRptFactura objVisorFactura = new VisorRptFactura(codigo);
                    objVisorFactura.ShowDialog();
                }        
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            VisorRptVentas objVsrVentas = new VisorRptVentas(dtpFechaIni.Value.Date, dtpFechaFin.Value.Date.AddDays(1));
            objVsrVentas.ShowDialog();
        }
    }
}

using CapaDatos;
using CapaEntidades;
using CapaLogica;
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
    public partial class RegistroVenta : Form
    {
        VentasLOG _controlVenta;
        ProductosLOG _controlProducto;
        private DataTable detalleVenta;

        public RegistroVenta()
        {
            InitializeComponent();

            CargarProductos();

            detalleVenta = new DataTable();
            detalleVenta.Columns.Add("Código", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Precio U", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("Sub Total", typeof(decimal));
        }

        private void CargarProductos()
        {
            _controlProducto = new ProductosLOG();
            productoBindingSource.DataSource = _controlProducto.Lista();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidarDatos();
            if (esValido) 
            {
                AgregarDetalle();
            }
        }

        private bool ValidarDatos(bool esProceso = false)
        {
            bool valido = false;
            if (esProceso)
            {
                if (detalleVenta.Rows.Count == 0)
                {
                    MessageBox.Show("Debe Ingresar productos para procesar la venta", "UNAB|Chalatenango, El Salvador",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    valido = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(cbxNombre.Text))
                {
                    MessageBox.Show("Debe Ingresar el códgio o el nombre del producto a vender", "UNAB|Chalatenango, El Salvador",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                    txtCodigo.BackColor = Color.LightYellow;
                }
                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Debe Ingresar la cantidad de producto a vender", "UNAB|Chalatenango, El Salvador",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    txtCantidad.BackColor = Color.LightYellow;
                }
                else
                {
                    valido = true;
                }
            }
            return valido;
        }

        private void AgregarDetalle()
        {
            _controlProducto = new ProductosLOG(); 

            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                var producto = _controlProducto.ObtenerProducto(codigo);

                if(producto != null)
                {
                    detalleVenta.Rows.Add(producto.ProductoId, producto.Nombre, producto.PrecioUnitario, 
                        cantidad, (cantidad * producto.PrecioUnitario));

                    dgvDetalleVenta.DataSource = detalleVenta;
                }

                decimal montoTotal = 0;

                foreach (DataRow row in detalleVenta.Rows)
                {
                    montoTotal += (decimal)row["Sub Total"];
                }

                txtMonto.Text = montoTotal.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango, El Salvador", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodigo.Text))
            {
                _controlProducto = new ProductosLOG();

                int codigo = int.Parse(txtCodigo.Text);

                var producto = _controlProducto.ObtenerProducto(codigo);

                if(producto != null)
                {
                    cbxNombre.Text = producto.Nombre;
                }
                else
                {
                    cbxNombre.Text = "";
                }                
            }
            else
            {
                CargarProductos();
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProcesarVenta();
        }

        private void ProcesarVenta()
        {
            _controlVenta = new VentasLOG();

            try
            {
                Venta venta = new Venta();
                decimal montoTotal = decimal.Parse(txtMonto.Text);

                venta.FechaVenta = DateTime.Now;
                venta.TotalVenta = montoTotal;

                foreach (DataRow row in detalleVenta.Rows)
                {
                    var detalle = new DetalleVenta() 
                    {
                        ProductoId = (int)row["Código"],
                        Cantidad = (int)row["Cantidad"]
                    };

                    venta.Detalles.Add(detalle);
                }

                int resultado = _controlVenta.Guardar(venta, 0, false);
                if (resultado > 0)
                {
                    MessageBox.Show("Venta procesada con exito", "UNAB|Chalatenango, El Salvador", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se logro procesar la venta", "UNAB|Chalatenango, El Salvador", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango, El Salvador", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                decimal nuevoMonto = CalcularMontoTotal();

                txtMonto.Text = nuevoMonto.ToString();
            }
        }

        private decimal CalcularMontoTotal()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                decimal subTotal = Convert.ToDecimal(row.Cells["Sub Total"].Value);
                montoTotal += subTotal;
            }

            return montoTotal;
        }
    }
}

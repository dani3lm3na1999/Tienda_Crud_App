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
            detalleVenta.Columns.Add("PrecioU", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));
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
                if (string.IsNullOrEmpty(txtMonto.Text) || decimal.Parse(txtMonto.Text) <= 0)
                {
                    MessageBox.Show("El monto total debe ser mayor a cero", "UNAB|Chalatenango, El Salvador",
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
                if (string.IsNullOrEmpty(txtCantidad.Text) || int.Parse(txtCantidad.Text) <= 0)
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

                var producto = (Producto)productoBindingSource.Current;

                if(producto != null)
                {
                    detalleVenta.Rows.Add(producto.ProductoId, producto.Nombre, producto.PrecioUnitario, 
                        cantidad, (cantidad * producto.PrecioUnitario));

                    dgvDetalleVenta.DataSource = detalleVenta;
                }

                decimal montoTotal = 0;

                foreach (DataRow row in detalleVenta.Rows)
                {
                    montoTotal += (decimal)row["SubTotal"];
                }

                txtMonto.Text = montoTotal.ToString();

                LimpiarCampos();
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
            bool esValido = ValidarDatos(true);
            if(esValido)
            {
                ProcesarVenta();
            }
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
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    bool precioValido = decimal.TryParse(dgvDetalleVenta.Rows[e.RowIndex].Cells["PrecioU"].Value.ToString(), out decimal precioUnitario);
                    bool cantidadValida = int.TryParse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString(), out int cantidad);

                    if (precioValido && cantidadValida || precioUnitario > 0 && cantidad > 0)
                    {
                        decimal subTotal = precioUnitario * cantidad;
                        dgvDetalleVenta.Rows[e.RowIndex].Cells["SubTotal"].Value = subTotal;

                        decimal nuevoMonto = CalcularMontoTotal();
                        txtMonto.Text = nuevoMonto.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Debe colocar un precio y una cantidad validad", "UNAB|Chalatenango, El Salvador",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango, El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalcularMontoTotal()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                
                montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }

            return montoTotal;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "0";
            txtCantidad.Clear();
        }
    }
}

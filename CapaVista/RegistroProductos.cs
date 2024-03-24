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
    public partial class RegistroProductos : Form
    {
        ProductosLOG _controlProducto;
        private int _id;
        private bool _actualizando;

        public RegistroProductos(int id = 0, bool actualizando = false)
        {
            InitializeComponent();
            _id = id;
            _actualizando = actualizando;

            if (actualizando)
            {
                this.Text = "Tienda|Edición de Productos";
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            _controlProducto = new ProductosLOG();
            productoBindingSource.DataSource = _controlProducto.ObtenerProducto(_id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error, favor comunicarse con el área de soporte","UNAB|Chalatenango",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarDatos()
        {
            bool datosValidos = ValidarDatos();

            if (datosValidos)
            {
                if (_actualizando)
                {
                    Producto producto;
                    producto = (Producto)productoBindingSource.Current;

                    _controlProducto = new ProductosLOG();

                    int respuesta = _controlProducto.Guardar(producto, _id, true);

                    if (respuesta > 0)
                    {
                        MessageBox.Show("Producto actualizado con exito", "UNAB|Chalatenango, El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro actualizar el producto", "UNAB|Chalatenango, El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    productoBindingSource.EndEdit();

                    Producto producto;
                    producto = (Producto)productoBindingSource.Current;

                    _controlProducto = new ProductosLOG();

                    int respuesta = _controlProducto.Guardar(producto, 0);

                    if (respuesta > 0)
                    {
                        MessageBox.Show("Producto guardado con exito", "UNAB|Chalatenango, El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar el producto", "UNAB|Chalatenango, El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {
            if(_actualizando == false)
            {
                productoBindingSource.MoveLast();
                productoBindingSource.AddNew();
            }
        }

        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('.'))
            {
                e.Handled= true;
            }
        }

        private bool ValidarDatos()
        {
            bool esValido = false;

            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe Ingresar el nombre del producto", "UNAB|Chalatenango El Salvador",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                txtNombre.BackColor = Color.LightYellow;
            }
            else if(string.IsNullOrEmpty(txtDescripcion.Text)) {
                MessageBox.Show("Debe Ingresar la descripción del producto", "UNAB|Chalatenango El Salvador",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Focus();
                txtDescripcion.BackColor = Color.LightYellow;
            }
            else if(string.IsNullOrEmpty(txtPrecio.Text) || Convert.ToDecimal(txtPrecio.Text) == 0)
            {
                MessageBox.Show("Debe Ingresar el precio del producto", "UNAB|Chalatenango El Salvador",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrecio.Focus();
                txtPrecio.BackColor = Color.LightYellow;
            }
            else if(string.IsNullOrEmpty(txtExistencias.Text) || Convert.ToInt32(txtExistencias.Text) == 0)
            {
                MessageBox.Show("Debe Ingresar las existencias del producto", "UNAB|Chalatenango El Salvador",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExistencias.Focus();
                txtExistencias.BackColor = Color.LightYellow;
            }
            else if(!chkEstado.Checked)
            {
                var dialogo = MessageBox.Show("¿Esta Seguro que desea guardar el producto Inactivo?", "UNAB|Chalatenango El Salvador",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ( dialogo != DialogResult.Yes)
                {
                    MessageBox.Show("Seleccione el cuadro 'Activo' para guardar el producto como Activo", "UNAB|Chalatenango El Salvador",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chkEstado.Focus();
                }
                else
                {
                    esValido = true;
                }
            }
            else
            {
                esValido = true;
            }

            return esValido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

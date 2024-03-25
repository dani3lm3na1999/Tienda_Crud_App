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
    public partial class MantenimientoProductos : Form
    {
        ProductosLOG _controlProductos;

        public MantenimientoProductos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistroProductos objRegistroProductos = new RegistroProductos();
            objRegistroProductos.ShowDialog();
            CargarProductos();
        }

        private void CargarProductos()
        {
            _controlProductos = new ProductosLOG();
            if(rdbActivos.Checked )
            {
                dgvProductos.DataSource = _controlProductos.Lista();
            }
            else
            {
                dgvProductos.DataSource = _controlProductos.Lista(false);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            _controlProductos = new ProductosLOG();
            string codigo = txtCodigo.Text;

            if(!string.IsNullOrEmpty(codigo))
            {
                if (rdbActivos.Checked)
                {
                    dgvProductos.DataSource = _controlProductos.ListaFiltro(int.Parse(codigo), null);
                }
                else
                {
                    dgvProductos.DataSource = _controlProductos.ListaFiltro(int.Parse(codigo), null, false);
                }                
            }
            else
            {
                CargarProductos();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            _controlProductos = new ProductosLOG();
            string nombre = txtNombre.Text;

            if(!string.IsNullOrEmpty(nombre) )
            {
                if (rdbActivos.Checked)
                {
                    dgvProductos.DataSource = _controlProductos.ListaFiltro(0, nombre);
                }
                else
                {
                    dgvProductos.DataSource = _controlProductos.ListaFiltro(0, nombre, false);
                }            }
            else
            {
                CargarProductos();
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                int id = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ProductoId"].Value);

                if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Editar"))
                {
                    RegistroProductos objRegistroProductos = new RegistroProductos(id, true);
                    objRegistroProductos.ShowDialog();
                    CargarProductos();
                }
                else if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                {
                    _controlProductos = new ProductosLOG();

                    var producto = _controlProductos.ObtenerProducto(id);
                    var dialogo = MessageBox.Show($"Esta seguro que desea eliminar el producto: {producto.Nombre}","UNAB|Chalatenango",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Opción Cancelada por el Usuario", "UNAB|Chalatenango",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        int resultado = _controlProductos.EliminarProducto(id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Producto eliminado con exito", "UNAB|Chalatenango, El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se logro eliminar el producto", "UNAB|Chalatenango, El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    CargarProductos();
                }                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbActivos_CheckedChanged_1(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos(); 
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

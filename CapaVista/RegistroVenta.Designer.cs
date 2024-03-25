namespace CapaVista
{
    partial class RegistroVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVenta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ProductoId", true));
            this.txtCodigo.Location = new System.Drawing.Point(114, 24);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(89, 22);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CapaEntidades.Producto);
            // 
            // txtCantidad
            // 
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DetalleBindingSource, "Cantidad", true));
            this.txtCantidad.Location = new System.Drawing.Point(114, 62);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(89, 22);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // DetalleBindingSource
            // 
            this.DetalleBindingSource.DataSource = typeof(CapaEntidades.DetalleVenta);
            // 
            // cbxNombre
            // 
            this.cbxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNombre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.DetalleBindingSource, "ProductoId", true));
            this.cbxNombre.DataSource = this.productoBindingSource;
            this.cbxNombre.DisplayMember = "Nombre";
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(346, 24);
            this.cbxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(259, 24);
            this.cbxNombre.TabIndex = 5;
            this.cbxNombre.ValueMember = "ProductoId";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(521, 58);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.PrecioU,
            this.Cantidad,
            this.SubTotal});
            this.dgvDetalleVenta.Location = new System.Drawing.Point(22, 110);
            this.dgvDetalleVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(583, 135);
            this.dgvDetalleVenta.TabIndex = 7;
            this.dgvDetalleVenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellValueChanged);
            this.dgvDetalleVenta.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDetalleVenta_UserDeletedRow);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Código";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 75;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // PrecioU
            // 
            this.PrecioU.DataPropertyName = "PrecioU";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PrecioU.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecioU.HeaderText = "Precio";
            this.PrecioU.Name = "PrecioU";
            this.PrecioU.Width = 75;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 75;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 310);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 29);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Procesar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(CapaEntidades.Venta);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(521, 310);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 29);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monto Total:";
            // 
            // txtMonto
            // 
            this.txtMonto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "TotalVenta", true));
            this.txtMonto.Location = new System.Drawing.Point(505, 266);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.TabIndex = 11;
            this.txtMonto.Text = "0.00";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Existencias:";
            // 
            // txtExistencias
            // 
            this.txtExistencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Stock", true));
            this.txtExistencias.Location = new System.Drawing.Point(346, 59);
            this.txtExistencias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.ReadOnly = true;
            this.txtExistencias.Size = new System.Drawing.Size(89, 22);
            this.txtExistencias.TabIndex = 13;
            this.txtExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 352);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxNombre);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "RegistroVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda | Registro de Venta";
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbxNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource DetalleBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExistencias;
    }
}
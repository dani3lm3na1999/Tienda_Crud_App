namespace CapaVista
{
    partial class MantenimientoVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoVentas));
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.VentaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIni.Location = new System.Drawing.Point(86, 26);
            this.dtpFechaIni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(94, 22);
            this.dtpFechaIni.TabIndex = 0;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(253, 26);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(94, 22);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(355, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Green;
            this.btnImprimir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(12, 301);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 28);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dgvDetalleVentas
            // 
            this.dgvDetalleVentas.AllowUserToAddRows = false;
            this.dgvDetalleVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imprimir,
            this.VentaId,
            this.Fecha,
            this.Total});
            this.dgvDetalleVentas.Location = new System.Drawing.Point(12, 66);
            this.dgvDetalleVentas.Name = "dgvDetalleVentas";
            this.dgvDetalleVentas.ReadOnly = true;
            this.dgvDetalleVentas.Size = new System.Drawing.Size(408, 215);
            this.dgvDetalleVentas.TabIndex = 4;
            this.dgvDetalleVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVentas_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(310, 301);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(110, 22);
            this.txtMontoTotal.TabIndex = 8;
            this.txtMontoTotal.Text = "0.00";
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VentaId
            // 
            this.VentaId.DataPropertyName = "VentaId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VentaId.DefaultCellStyle = dataGridViewCellStyle2;
            this.VentaId.HeaderText = "N° Venta";
            this.VentaId.Name = "VentaId";
            this.VentaId.ReadOnly = true;
            this.VentaId.Width = 75;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaVenta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "Fecha Venta";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "TotalVenta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Monto Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Print";
            this.dataGridViewImageColumn1.Image = global::CapaVista.Properties.Resources.print;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 75;
            // 
            // Imprimir
            // 
            this.Imprimir.HeaderText = "Print";
            this.Imprimir.Image = global::CapaVista.Properties.Resources.print;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.ReadOnly = true;
            this.Imprimir.Width = 70;
            // 
            // MantenimientoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 342);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetalleVentas);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaIni);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MantenimientoVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda|Mantenimiento Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgvDetalleVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
namespace CapaVista.Visores
{
    partial class VisorRptFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorRptFactura));
            this.crvFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvFactura
            // 
            this.crvFactura.ActiveViewIndex = -1;
            this.crvFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFactura.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crvFactura.Location = new System.Drawing.Point(0, 0);
            this.crvFactura.Name = "crvFactura";
            this.crvFactura.ShowCloseButton = false;
            this.crvFactura.ShowCopyButton = false;
            this.crvFactura.ShowGroupTreeButton = false;
            this.crvFactura.ShowParameterPanelButton = false;
            this.crvFactura.ShowRefreshButton = false;
            this.crvFactura.ShowTextSearchButton = false;
            this.crvFactura.Size = new System.Drawing.Size(799, 450);
            this.crvFactura.TabIndex = 0;
            this.crvFactura.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorRptFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisorRptFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda|Factura Venta";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFactura;
    }
}
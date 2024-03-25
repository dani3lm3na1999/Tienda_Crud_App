namespace CapaVista.Visores
{
    partial class VisorRptVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorRptVentas));
            this.crvRptVentas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvRptVentas
            // 
            this.crvRptVentas.ActiveViewIndex = -1;
            this.crvRptVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvRptVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRptVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRptVentas.Location = new System.Drawing.Point(0, 0);
            this.crvRptVentas.Name = "crvRptVentas";
            this.crvRptVentas.ShowCloseButton = false;
            this.crvRptVentas.ShowCopyButton = false;
            this.crvRptVentas.ShowGroupTreeButton = false;
            this.crvRptVentas.ShowParameterPanelButton = false;
            this.crvRptVentas.ShowRefreshButton = false;
            this.crvRptVentas.ShowTextSearchButton = false;
            this.crvRptVentas.ShowZoomButton = false;
            this.crvRptVentas.Size = new System.Drawing.Size(798, 449);
            this.crvRptVentas.TabIndex = 0;
            this.crvRptVentas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorRptVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvRptVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisorRptVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda|Reporte Ventas";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRptVentas;
    }
}
namespace Twelve.Maxiconfort.Facturacion
{
    partial class frmImprimirFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirFactura));
            this.SPGetFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaxiconfortDataSet = new Twelve.Maxiconfort.Facturacion.MaxiconfortDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SPGetFacturaTableAdapter = new Twelve.Maxiconfort.Facturacion.MaxiconfortDataSetTableAdapters.SPGetFacturaTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPGetFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiconfortDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SPGetFacturaBindingSource
            // 
            this.SPGetFacturaBindingSource.DataMember = "SPGetFactura";
            this.SPGetFacturaBindingSource.DataSource = this.MaxiconfortDataSet;
            // 
            // MaxiconfortDataSet
            // 
            this.MaxiconfortDataSet.DataSetName = "MaxiconfortDataSet";
            this.MaxiconfortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "FacturaDataSet";
            reportDataSource1.Value = this.SPGetFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Twelve.Maxiconfort.Facturacion.Reports.rptFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(995, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // SPGetFacturaTableAdapter
            // 
            this.SPGetFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(932, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 595);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImprimirFactura";
            this.Text = "frmImprimirFactura";
            this.Load += new System.EventHandler(this.frmImprimirFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SPGetFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiconfortDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SPGetFacturaBindingSource;
        private MaxiconfortDataSet MaxiconfortDataSet;
        private MaxiconfortDataSetTableAdapters.SPGetFacturaTableAdapter SPGetFacturaTableAdapter;
        private System.Windows.Forms.Button btnCerrar;
    }
}
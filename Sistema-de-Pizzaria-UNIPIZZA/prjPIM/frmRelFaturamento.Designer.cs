namespace prjPIM
{
    partial class frmRelFaturamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelFaturamento));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtRelatorios = new prjPIM.dtRelatorios();
            this.cadpedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadpedidoTableAdapter = new prjPIM.dtRelatoriosTableAdapters.cadpedidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadpedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cadpedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjPIM.Relatorios.RelFaturamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 481);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dtRelatorios
            // 
            this.dtRelatorios.DataSetName = "dtRelatorios";
            this.dtRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadpedidoBindingSource
            // 
            this.cadpedidoBindingSource.DataMember = "cadpedido";
            this.cadpedidoBindingSource.DataSource = this.dtRelatorios;
            // 
            // cadpedidoTableAdapter
            // 
            this.cadpedidoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelFaturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 481);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelFaturamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Faturamento";
            this.Load += new System.EventHandler(this.frmFaturamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadpedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dtRelatorios dtRelatorios;
        private System.Windows.Forms.BindingSource cadpedidoBindingSource;
        private dtRelatoriosTableAdapters.cadpedidoTableAdapter cadpedidoTableAdapter;
    }
}
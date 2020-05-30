namespace prjPIM
{
    partial class frmRelProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelProdutos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtRelatorios = new prjPIM.dtRelatorios();
            this.dtRelatoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadpermissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadpermissaoTableAdapter = new prjPIM.dtRelatoriosTableAdapters.cadpermissaoTableAdapter();
            this.cadprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadprodutoTableAdapter = new prjPIM.dtRelatoriosTableAdapters.cadprodutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadpermissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadprodutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtRelatorios";
            reportDataSource1.Value = this.cadprodutoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjPIM.Relatorios.RelProdutos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 481);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtRelatorios
            // 
            this.dtRelatorios.DataSetName = "dtRelatorios";
            this.dtRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtRelatoriosBindingSource
            // 
            this.dtRelatoriosBindingSource.DataSource = this.dtRelatorios;
            this.dtRelatoriosBindingSource.Position = 0;
            // 
            // cadpermissaoBindingSource
            // 
            this.cadpermissaoBindingSource.DataMember = "cadpermissao";
            this.cadpermissaoBindingSource.DataSource = this.dtRelatorios;
            // 
            // cadpermissaoTableAdapter
            // 
            this.cadpermissaoTableAdapter.ClearBeforeFill = true;
            // 
            // cadprodutoBindingSource
            // 
            this.cadprodutoBindingSource.DataMember = "cadproduto";
            this.cadprodutoBindingSource.DataSource = this.dtRelatoriosBindingSource;
            // 
            // cadprodutoTableAdapter
            // 
            this.cadprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 481);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.frmRelProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadpermissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadprodutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtRelatoriosBindingSource;
        private dtRelatorios dtRelatorios;
        private System.Windows.Forms.BindingSource cadpermissaoBindingSource;
        private dtRelatoriosTableAdapters.cadpermissaoTableAdapter cadpermissaoTableAdapter;
        private System.Windows.Forms.BindingSource cadprodutoBindingSource;
        private dtRelatoriosTableAdapters.cadprodutoTableAdapter cadprodutoTableAdapter;
    }
}
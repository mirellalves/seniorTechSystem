
namespace PI_SeniorTech.Relatórios
{
    partial class relcli
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tBCLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI_SeniorTechDataSet = new PI_SeniorTech.PI_SeniorTechDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tBCLIENTESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tB_CLIENTESTableAdapter = new PI_SeniorTech.PI_SeniorTechDataSetTableAdapters.TB_CLIENTESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBCLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCLIENTESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBCLIENTESBindingSource
            // 
            this.tBCLIENTESBindingSource.DataMember = "TB_CLIENTES";
            this.tBCLIENTESBindingSource.DataSource = this.pI_SeniorTechDataSet;
            // 
            // pI_SeniorTechDataSet
            // 
            this.pI_SeniorTechDataSet.DataSetName = "PI_SeniorTechDataSet";
            this.pI_SeniorTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetClientes";
            reportDataSource2.Value = this.tBCLIENTESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_SeniorTech.Relatórios.RelCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(842, 477);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tBCLIENTESBindingSource1
            // 
            this.tBCLIENTESBindingSource1.DataMember = "TB_CLIENTES";
            this.tBCLIENTESBindingSource1.DataSource = this.pI_SeniorTechDataSet;
            // 
            // tB_CLIENTESTableAdapter
            // 
            this.tB_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // relcli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 477);
            this.Controls.Add(this.reportViewer1);
            this.Name = "relcli";
            this.Text = "Relatório de Clientes";
            this.Load += new System.EventHandler(this.relcli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBCLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCLIENTESBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PI_SeniorTechDataSet pI_SeniorTechDataSet;
        private System.Windows.Forms.BindingSource tBCLIENTESBindingSource;
        private PI_SeniorTechDataSetTableAdapters.TB_CLIENTESTableAdapter tB_CLIENTESTableAdapter;
        private System.Windows.Forms.BindingSource tBCLIENTESBindingSource1;
    }
}
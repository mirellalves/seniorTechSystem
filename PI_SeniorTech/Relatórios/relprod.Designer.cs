
namespace PI_SeniorTech.Relatórios
{
    partial class relprod
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
            this.tBPRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI_SeniorTechDataSet = new PI_SeniorTech.PI_SeniorTechDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tB_PRODUTOSTableAdapter = new PI_SeniorTech.PI_SeniorTechDataSetTableAdapters.TB_PRODUTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tBPRODUTOSBindingSource
            // 
            this.tBPRODUTOSBindingSource.DataMember = "TB_PRODUTOS";
            this.tBPRODUTOSBindingSource.DataSource = this.pI_SeniorTechDataSet;
            // 
            // pI_SeniorTechDataSet
            // 
            this.pI_SeniorTechDataSet.DataSetName = "PI_SeniorTechDataSet";
            this.pI_SeniorTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProdutos";
            reportDataSource1.Value = this.tBPRODUTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_SeniorTech.Relatórios.RelProduto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tB_PRODUTOSTableAdapter
            // 
            this.tB_PRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // relprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "relprod";
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.Relatório_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PI_SeniorTechDataSet pI_SeniorTechDataSet;
        private System.Windows.Forms.BindingSource tBPRODUTOSBindingSource;
        private PI_SeniorTechDataSetTableAdapters.TB_PRODUTOSTableAdapter tB_PRODUTOSTableAdapter;
    }
}

namespace PI_SeniorTech.Relatórios
{
    partial class relped
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pI_SeniorTechDataSet = new PI_SeniorTech.PI_SeniorTechDataSet();
            this.tBPEDIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_PEDIDOSTableAdapter = new PI_SeniorTech.PI_SeniorTechDataSetTableAdapters.TB_PEDIDOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPEDIDOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPedido";
            reportDataSource1.Value = this.tBPEDIDOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_SeniorTech.Relatórios.RelPedido.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // pI_SeniorTechDataSet
            // 
            this.pI_SeniorTechDataSet.DataSetName = "PI_SeniorTechDataSet";
            this.pI_SeniorTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBPEDIDOSBindingSource
            // 
            this.tBPEDIDOSBindingSource.DataMember = "TB_PEDIDOS";
            this.tBPEDIDOSBindingSource.DataSource = this.pI_SeniorTechDataSet;
            // 
            // tB_PEDIDOSTableAdapter
            // 
            this.tB_PEDIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // relped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "relped";
            this.Text = "Relatório de Pedidos de Vendas";
            this.Load += new System.EventHandler(this.relped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPEDIDOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PI_SeniorTechDataSet pI_SeniorTechDataSet;
        private System.Windows.Forms.BindingSource tBPEDIDOSBindingSource;
        private PI_SeniorTechDataSetTableAdapters.TB_PEDIDOSTableAdapter tB_PEDIDOSTableAdapter;
    }
}
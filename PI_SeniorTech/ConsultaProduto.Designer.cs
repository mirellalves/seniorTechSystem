
namespace PI_SeniorTech
{
    partial class ConsultaProduto
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
            this.btFecharConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvarCliente = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tBPRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI_SeniorTechDataSet = new PI_SeniorTech.PI_SeniorTechDataSet();
            this.tB_PRODUTOSTableAdapter = new PI_SeniorTech.PI_SeniorTechDataSetTableAdapters.TB_PRODUTOSTableAdapter();
            this.labelCodigoProduto = new System.Windows.Forms.Label();
            this.textBoxValorVendaProduto = new System.Windows.Forms.TextBox();
            this.textBoxCorProduto = new System.Windows.Forms.TextBox();
            this.textBoxUnidadeMedidaProduto = new System.Windows.Forms.TextBox();
            this.textBoxModeloProduto = new System.Windows.Forms.TextBox();
            this.textBoxMarcaProduto = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoProduto = new System.Windows.Forms.TextBox();
            this.labelValorVendaProduto = new System.Windows.Forms.Label();
            this.labelCorProduto = new System.Windows.Forms.Label();
            this.labelUnidadeMedidaProduto = new System.Windows.Forms.Label();
            this.labelModeloProduto = new System.Windows.Forms.Label();
            this.labelMarcaProduto = new System.Windows.Forms.Label();
            this.labelDescricaoProduto = new System.Windows.Forms.Label();
            this.labelCodProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btFecharConsulta
            // 
            this.btFecharConsulta.BackColor = System.Drawing.Color.LightCoral;
            this.btFecharConsulta.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFecharConsulta.Location = new System.Drawing.Point(655, 100);
            this.btFecharConsulta.Name = "btFecharConsulta";
            this.btFecharConsulta.Size = new System.Drawing.Size(133, 63);
            this.btFecharConsulta.TabIndex = 81;
            this.btFecharConsulta.Text = "FECHAR";
            this.btFecharConsulta.UseVisualStyleBackColor = false;
            this.btFecharConsulta.Click += new System.EventHandler(this.btFecharConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Selecione o Produto: ";
            // 
            // btSalvarCliente
            // 
            this.btSalvarCliente.BackColor = System.Drawing.Color.Goldenrod;
            this.btSalvarCliente.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalvarCliente.Location = new System.Drawing.Point(655, 8);
            this.btSalvarCliente.Name = "btSalvarCliente";
            this.btSalvarCliente.Size = new System.Drawing.Size(133, 63);
            this.btSalvarCliente.TabIndex = 64;
            this.btSalvarCliente.Text = "SALVAR";
            this.btSalvarCliente.UseVisualStyleBackColor = false;
            this.btSalvarCliente.Click += new System.EventHandler(this.btSalvarCliente_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBPRODUTOSBindingSource;
            this.comboBox1.DisplayMember = "DESCR_PROD";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(514, 21);
            this.comboBox1.TabIndex = 82;
            this.comboBox1.ValueMember = "COD_PROD";
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
            // tB_PRODUTOSTableAdapter
            // 
            this.tB_PRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // labelCodigoProduto
            // 
            this.labelCodigoProduto.AutoSize = true;
            this.labelCodigoProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCodigoProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRODUTOSBindingSource, "COD_PROD", true));
            this.labelCodigoProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProduto.Location = new System.Drawing.Point(213, 34);
            this.labelCodigoProduto.Name = "labelCodigoProduto";
            this.labelCodigoProduto.Size = new System.Drawing.Size(15, 20);
            this.labelCodigoProduto.TabIndex = 96;
            this.labelCodigoProduto.Text = "-";
            // 
            // textBoxValorVendaProduto
            // 
            this.textBoxValorVendaProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxValorVendaProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRODUTOSBindingSource, "VALOR_UNT_VENDA", true));
            this.textBoxValorVendaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorVendaProduto.Location = new System.Drawing.Point(179, 316);
            this.textBoxValorVendaProduto.Name = "textBoxValorVendaProduto";
            this.textBoxValorVendaProduto.Size = new System.Drawing.Size(458, 25);
            this.textBoxValorVendaProduto.TabIndex = 95;
            // 
            // textBoxCorProduto
            // 
            this.textBoxCorProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxCorProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRODUTOSBindingSource, "COR", true));
            this.textBoxCorProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorProduto.Location = new System.Drawing.Point(70, 269);
            this.textBoxCorProduto.Name = "textBoxCorProduto";
            this.textBoxCorProduto.Size = new System.Drawing.Size(567, 25);
            this.textBoxCorProduto.TabIndex = 93;
            // 
            // textBoxUnidadeMedidaProduto
            // 
            this.textBoxUnidadeMedidaProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxUnidadeMedidaProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRODUTOSBindingSource, "UND", true));
            this.textBoxUnidadeMedidaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnidadeMedidaProduto.Location = new System.Drawing.Point(206, 220);
            this.textBoxUnidadeMedidaProduto.Name = "textBoxUnidadeMedidaProduto";
            this.textBoxUnidadeMedidaProduto.Size = new System.Drawing.Size(431, 25);
            this.textBoxUnidadeMedidaProduto.TabIndex = 91;
            // 
            // textBoxModeloProduto
            // 
            this.textBoxModeloProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxModeloProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRODUTOSBindingSource, "MODELO", true));
            this.textBoxModeloProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModeloProduto.Location = new System.Drawing.Point(108, 173);
            this.textBoxModeloProduto.Name = "textBoxModeloProduto";
            this.textBoxModeloProduto.Size = new System.Drawing.Size(529, 25);
            this.textBoxModeloProduto.TabIndex = 89;
            // 
            // textBoxMarcaProduto
            // 
            this.textBoxMarcaProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxMarcaProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRODUTOSBindingSource, "MARCA", true));
            this.textBoxMarcaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarcaProduto.Location = new System.Drawing.Point(92, 127);
            this.textBoxMarcaProduto.Name = "textBoxMarcaProduto";
            this.textBoxMarcaProduto.Size = new System.Drawing.Size(545, 25);
            this.textBoxMarcaProduto.TabIndex = 87;
            // 
            // textBoxDescricaoProduto
            // 
            this.textBoxDescricaoProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxDescricaoProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRODUTOSBindingSource, "DESCR_PROD", true));
            this.textBoxDescricaoProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricaoProduto.Location = new System.Drawing.Point(127, 77);
            this.textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            this.textBoxDescricaoProduto.Size = new System.Drawing.Size(510, 25);
            this.textBoxDescricaoProduto.TabIndex = 85;
            // 
            // labelValorVendaProduto
            // 
            this.labelValorVendaProduto.AutoSize = true;
            this.labelValorVendaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorVendaProduto.Location = new System.Drawing.Point(12, 323);
            this.labelValorVendaProduto.Name = "labelValorVendaProduto";
            this.labelValorVendaProduto.Size = new System.Drawing.Size(161, 18);
            this.labelValorVendaProduto.TabIndex = 94;
            this.labelValorVendaProduto.Text = "*VALOR DE VENDA:";
            // 
            // labelCorProduto
            // 
            this.labelCorProduto.AutoSize = true;
            this.labelCorProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorProduto.Location = new System.Drawing.Point(12, 276);
            this.labelCorProduto.Name = "labelCorProduto";
            this.labelCorProduto.Size = new System.Drawing.Size(52, 18);
            this.labelCorProduto.TabIndex = 92;
            this.labelCorProduto.Text = "*COR:";
            // 
            // labelUnidadeMedidaProduto
            // 
            this.labelUnidadeMedidaProduto.AutoSize = true;
            this.labelUnidadeMedidaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnidadeMedidaProduto.Location = new System.Drawing.Point(12, 227);
            this.labelUnidadeMedidaProduto.Name = "labelUnidadeMedidaProduto";
            this.labelUnidadeMedidaProduto.Size = new System.Drawing.Size(188, 18);
            this.labelUnidadeMedidaProduto.TabIndex = 90;
            this.labelUnidadeMedidaProduto.Text = "*UNIDADE DE MEDIDA:";
            // 
            // labelModeloProduto
            // 
            this.labelModeloProduto.AutoSize = true;
            this.labelModeloProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModeloProduto.Location = new System.Drawing.Point(12, 180);
            this.labelModeloProduto.Name = "labelModeloProduto";
            this.labelModeloProduto.Size = new System.Drawing.Size(90, 18);
            this.labelModeloProduto.TabIndex = 88;
            this.labelModeloProduto.Text = "*MODELO:";
            // 
            // labelMarcaProduto
            // 
            this.labelMarcaProduto.AutoSize = true;
            this.labelMarcaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcaProduto.Location = new System.Drawing.Point(12, 134);
            this.labelMarcaProduto.Name = "labelMarcaProduto";
            this.labelMarcaProduto.Size = new System.Drawing.Size(74, 18);
            this.labelMarcaProduto.TabIndex = 86;
            this.labelMarcaProduto.Text = "*MARCA:";
            // 
            // labelDescricaoProduto
            // 
            this.labelDescricaoProduto.AutoSize = true;
            this.labelDescricaoProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricaoProduto.Location = new System.Drawing.Point(12, 84);
            this.labelDescricaoProduto.Name = "labelDescricaoProduto";
            this.labelDescricaoProduto.Size = new System.Drawing.Size(109, 18);
            this.labelDescricaoProduto.TabIndex = 84;
            this.labelDescricaoProduto.Text = "*DESCRIÇÃO:";
            // 
            // labelCodProduto
            // 
            this.labelCodProduto.AutoSize = true;
            this.labelCodProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodProduto.Location = new System.Drawing.Point(12, 36);
            this.labelCodProduto.Name = "labelCodProduto";
            this.labelCodProduto.Size = new System.Drawing.Size(195, 18);
            this.labelCodProduto.TabIndex = 83;
            this.labelCodProduto.Text = "*CODIGO DO PRODUTO:";
            // 
            // ConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.labelCodigoProduto);
            this.Controls.Add(this.textBoxValorVendaProduto);
            this.Controls.Add(this.textBoxCorProduto);
            this.Controls.Add(this.textBoxUnidadeMedidaProduto);
            this.Controls.Add(this.textBoxModeloProduto);
            this.Controls.Add(this.textBoxMarcaProduto);
            this.Controls.Add(this.textBoxDescricaoProduto);
            this.Controls.Add(this.labelValorVendaProduto);
            this.Controls.Add(this.labelCorProduto);
            this.Controls.Add(this.labelUnidadeMedidaProduto);
            this.Controls.Add(this.labelModeloProduto);
            this.Controls.Add(this.labelMarcaProduto);
            this.Controls.Add(this.labelDescricaoProduto);
            this.Controls.Add(this.labelCodProduto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btFecharConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvarCliente);
            this.Name = "ConsultaProduto";
            this.ShowIcon = false;
            this.Text = "Consulta de Produto";
            this.Load += new System.EventHandler(this.ConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFecharConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvarCliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private PI_SeniorTechDataSet pI_SeniorTechDataSet;
        private System.Windows.Forms.BindingSource tBPRODUTOSBindingSource;
        private PI_SeniorTechDataSetTableAdapters.TB_PRODUTOSTableAdapter tB_PRODUTOSTableAdapter;
        private System.Windows.Forms.Label labelCodigoProduto;
        private System.Windows.Forms.TextBox textBoxValorVendaProduto;
        private System.Windows.Forms.TextBox textBoxCorProduto;
        private System.Windows.Forms.TextBox textBoxUnidadeMedidaProduto;
        private System.Windows.Forms.TextBox textBoxModeloProduto;
        private System.Windows.Forms.TextBox textBoxMarcaProduto;
        private System.Windows.Forms.TextBox textBoxDescricaoProduto;
        private System.Windows.Forms.Label labelValorVendaProduto;
        private System.Windows.Forms.Label labelCorProduto;
        private System.Windows.Forms.Label labelUnidadeMedidaProduto;
        private System.Windows.Forms.Label labelModeloProduto;
        private System.Windows.Forms.Label labelMarcaProduto;
        private System.Windows.Forms.Label labelDescricaoProduto;
        private System.Windows.Forms.Label labelCodProduto;
    }
}
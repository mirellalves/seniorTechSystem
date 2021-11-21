
namespace PI_SeniorTech
{
    partial class ConsultaPedido
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tBPEDIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI_SeniorTechDataSet = new PI_SeniorTech.PI_SeniorTechDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvarPedido = new System.Windows.Forms.Button();
            this.tB_PEDIDOSTableAdapter = new PI_SeniorTech.PI_SeniorTechDataSetTableAdapters.TB_PEDIDOSTableAdapter();
            this.btCarregarProduto = new System.Windows.Forms.Button();
            this.btCarregarCliente = new System.Windows.Forms.Button();
            this.labelNumPedido = new System.Windows.Forms.Label();
            this.maskedTextBoxVcto1ParcelaPedido = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataCadastroPedido = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.labelVcto1ParcelaPedido = new System.Windows.Forms.Label();
            this.textBoxUnidadeMedidaProduto = new System.Windows.Forms.TextBox();
            this.labelUnidadeMedidaProduto = new System.Windows.Forms.Label();
            this.textBoxObsPedido = new System.Windows.Forms.TextBox();
            this.labelObservacoesPedido = new System.Windows.Forms.Label();
            this.textBoxValorParcelaPedido = new System.Windows.Forms.TextBox();
            this.labelQuantidadeParcelasPedido = new System.Windows.Forms.Label();
            this.textBoxQuantidadeParcelasPedido = new System.Windows.Forms.TextBox();
            this.textBoxFormaPgtoPedido = new System.Windows.Forms.TextBox();
            this.labelFormaPgtoPedido = new System.Windows.Forms.Label();
            this.textBoxValorTotalPedido = new System.Windows.Forms.TextBox();
            this.labelValorTotalPedido = new System.Windows.Forms.Label();
            this.textBoxQuantidadePedido = new System.Windows.Forms.TextBox();
            this.labelQuantidadePedido = new System.Windows.Forms.Label();
            this.textBoxValorVendaProduto = new System.Windows.Forms.TextBox();
            this.textBoxCorProduto = new System.Windows.Forms.TextBox();
            this.labelValorVendaProduto = new System.Windows.Forms.Label();
            this.labelCorProduto = new System.Windows.Forms.Label();
            this.textBoxDescricaoProduto = new System.Windows.Forms.TextBox();
            this.textBoxCodProduto = new System.Windows.Forms.TextBox();
            this.labelDescricaoProduto = new System.Windows.Forms.Label();
            this.labelCodProduto = new System.Windows.Forms.Label();
            this.textBoxEmailCliente = new System.Windows.Forms.TextBox();
            this.labelEmailCliente = new System.Windows.Forms.Label();
            this.textBoxCodCliente = new System.Windows.Forms.TextBox();
            this.labelCodCliente = new System.Windows.Forms.Label();
            this.textBoxCidadeCliente = new System.Windows.Forms.TextBox();
            this.textBoxBairroCliente = new System.Windows.Forms.TextBox();
            this.textBoxNumeroEndCliente = new System.Windows.Forms.TextBox();
            this.textBoxEnderecoCliente = new System.Windows.Forms.TextBox();
            this.textBoxEstadoCliente = new System.Windows.Forms.TextBox();
            this.textBoxTelefoneCliente = new System.Windows.Forms.TextBox();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelCidadeCliente = new System.Windows.Forms.Label();
            this.labelBairroCliente = new System.Windows.Forms.Label();
            this.labelNumeroEndCliente = new System.Windows.Forms.Label();
            this.labelEnderecoCliente = new System.Windows.Forms.Label();
            this.labelEstadoCliente = new System.Windows.Forms.Label();
            this.labelCepCliente = new System.Windows.Forms.Label();
            this.labelTelefoneCliente = new System.Windows.Forms.Label();
            this.labelCpfCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelDataPedido = new System.Windows.Forms.Label();
            this.labelNumeroPedido = new System.Windows.Forms.Label();
            this.btExcluirPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBPEDIDOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btFecharConsulta
            // 
            this.btFecharConsulta.BackColor = System.Drawing.Color.LightCoral;
            this.btFecharConsulta.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFecharConsulta.Location = new System.Drawing.Point(655, 225);
            this.btFecharConsulta.Name = "btFecharConsulta";
            this.btFecharConsulta.Size = new System.Drawing.Size(133, 63);
            this.btFecharConsulta.TabIndex = 96;
            this.btFecharConsulta.Text = "FECHAR";
            this.btFecharConsulta.UseVisualStyleBackColor = false;
            this.btFecharConsulta.Click += new System.EventHandler(this.btFecharConsulta_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBPEDIDOSBindingSource;
            this.comboBox1.DisplayMember = "NUMERO_PED";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.ValueMember = "NUMERO_PED";
            // 
            // tBPEDIDOSBindingSource
            // 
            this.tBPEDIDOSBindingSource.DataMember = "TB_PEDIDOS";
            this.tBPEDIDOSBindingSource.DataSource = this.pI_SeniorTechDataSet;
            // 
            // pI_SeniorTechDataSet
            // 
            this.pI_SeniorTechDataSet.DataSetName = "PI_SeniorTechDataSet";
            this.pI_SeniorTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Selecione o Pedido:";
            // 
            // btSalvarPedido
            // 
            this.btSalvarPedido.BackColor = System.Drawing.Color.Goldenrod;
            this.btSalvarPedido.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalvarPedido.Location = new System.Drawing.Point(655, 39);
            this.btSalvarPedido.Name = "btSalvarPedido";
            this.btSalvarPedido.Size = new System.Drawing.Size(133, 63);
            this.btSalvarPedido.TabIndex = 64;
            this.btSalvarPedido.Text = "SALVAR";
            this.btSalvarPedido.UseVisualStyleBackColor = false;
            this.btSalvarPedido.Click += new System.EventHandler(this.btSalvarPedido_Click);
            // 
            // tB_PEDIDOSTableAdapter
            // 
            this.tB_PEDIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // btCarregarProduto
            // 
            this.btCarregarProduto.BackColor = System.Drawing.Color.ForestGreen;
            this.btCarregarProduto.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregarProduto.ForeColor = System.Drawing.Color.Honeydew;
            this.btCarregarProduto.Location = new System.Drawing.Point(321, 259);
            this.btCarregarProduto.Name = "btCarregarProduto";
            this.btCarregarProduto.Size = new System.Drawing.Size(81, 29);
            this.btCarregarProduto.TabIndex = 147;
            this.btCarregarProduto.Text = "Carregar";
            this.btCarregarProduto.UseVisualStyleBackColor = false;
            this.btCarregarProduto.Click += new System.EventHandler(this.btCarregarProduto_Click);
            // 
            // btCarregarCliente
            // 
            this.btCarregarCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btCarregarCliente.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarregarCliente.ForeColor = System.Drawing.Color.Honeydew;
            this.btCarregarCliente.Location = new System.Drawing.Point(231, 74);
            this.btCarregarCliente.Name = "btCarregarCliente";
            this.btCarregarCliente.Size = new System.Drawing.Size(81, 29);
            this.btCarregarCliente.TabIndex = 146;
            this.btCarregarCliente.Text = "Carregar";
            this.btCarregarCliente.UseVisualStyleBackColor = false;
            this.btCarregarCliente.Click += new System.EventHandler(this.btCarregarCliente_Click);
            // 
            // labelNumPedido
            // 
            this.labelNumPedido.AutoSize = true;
            this.labelNumPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNumPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "NUMERO_PED", true));
            this.labelNumPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPedido.Location = new System.Drawing.Point(202, 46);
            this.labelNumPedido.Name = "labelNumPedido";
            this.labelNumPedido.Size = new System.Drawing.Size(15, 20);
            this.labelNumPedido.TabIndex = 145;
            this.labelNumPedido.Text = "-";
            // 
            // maskedTextBoxVcto1ParcelaPedido
            // 
            this.maskedTextBoxVcto1ParcelaPedido.BackColor = System.Drawing.Color.Honeydew;
            this.maskedTextBoxVcto1ParcelaPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "VCTO_1PARC", true));
            this.maskedTextBoxVcto1ParcelaPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxVcto1ParcelaPedido.Location = new System.Drawing.Point(501, 418);
            this.maskedTextBoxVcto1ParcelaPedido.Mask = "00/00/0000";
            this.maskedTextBoxVcto1ParcelaPedido.Name = "maskedTextBoxVcto1ParcelaPedido";
            this.maskedTextBoxVcto1ParcelaPedido.Size = new System.Drawing.Size(134, 25);
            this.maskedTextBoxVcto1ParcelaPedido.TabIndex = 142;
            this.maskedTextBoxVcto1ParcelaPedido.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxCepCliente
            // 
            this.maskedTextBoxCepCliente.BackColor = System.Drawing.Color.Honeydew;
            this.maskedTextBoxCepCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "CEP", true));
            this.maskedTextBoxCepCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCepCliente.Location = new System.Drawing.Point(68, 198);
            this.maskedTextBoxCepCliente.Mask = "00,000\\-000";
            this.maskedTextBoxCepCliente.Name = "maskedTextBoxCepCliente";
            this.maskedTextBoxCepCliente.Size = new System.Drawing.Size(110, 25);
            this.maskedTextBoxCepCliente.TabIndex = 113;
            // 
            // maskedTextBoxDataCadastroPedido
            // 
            this.maskedTextBoxDataCadastroPedido.BackColor = System.Drawing.Color.Honeydew;
            this.maskedTextBoxDataCadastroPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "DT_PEDIDO", true));
            this.maskedTextBoxDataCadastroPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataCadastroPedido.Location = new System.Drawing.Point(505, 43);
            this.maskedTextBoxDataCadastroPedido.Mask = "00/00/0000";
            this.maskedTextBoxDataCadastroPedido.Name = "maskedTextBoxDataCadastroPedido";
            this.maskedTextBoxDataCadastroPedido.Size = new System.Drawing.Size(134, 25);
            this.maskedTextBoxDataCadastroPedido.TabIndex = 99;
            this.maskedTextBoxDataCadastroPedido.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxCPFCliente
            // 
            this.maskedTextBoxCPFCliente.BackColor = System.Drawing.Color.Honeydew;
            this.maskedTextBoxCPFCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "CPF", true));
            this.maskedTextBoxCPFCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCPFCliente.Location = new System.Drawing.Point(65, 105);
            this.maskedTextBoxCPFCliente.Mask = "000,000,000\\-00";
            this.maskedTextBoxCPFCliente.Name = "maskedTextBoxCPFCliente";
            this.maskedTextBoxCPFCliente.Size = new System.Drawing.Size(203, 25);
            this.maskedTextBoxCPFCliente.TabIndex = 105;
            // 
            // labelVcto1ParcelaPedido
            // 
            this.labelVcto1ParcelaPedido.AutoSize = true;
            this.labelVcto1ParcelaPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVcto1ParcelaPedido.Location = new System.Drawing.Point(341, 426);
            this.labelVcto1ParcelaPedido.Name = "labelVcto1ParcelaPedido";
            this.labelVcto1ParcelaPedido.Size = new System.Drawing.Size(154, 18);
            this.labelVcto1ParcelaPedido.TabIndex = 141;
            this.labelVcto1ParcelaPedido.Text = "*VCTO 1ª PARCELA:";
            // 
            // textBoxUnidadeMedidaProduto
            // 
            this.textBoxUnidadeMedidaProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxUnidadeMedidaProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "UND", true));
            this.textBoxUnidadeMedidaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnidadeMedidaProduto.Location = new System.Drawing.Point(202, 325);
            this.textBoxUnidadeMedidaProduto.Name = "textBoxUnidadeMedidaProduto";
            this.textBoxUnidadeMedidaProduto.Size = new System.Drawing.Size(110, 25);
            this.textBoxUnidadeMedidaProduto.TabIndex = 129;
            // 
            // labelUnidadeMedidaProduto
            // 
            this.labelUnidadeMedidaProduto.AutoSize = true;
            this.labelUnidadeMedidaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnidadeMedidaProduto.Location = new System.Drawing.Point(13, 328);
            this.labelUnidadeMedidaProduto.Name = "labelUnidadeMedidaProduto";
            this.labelUnidadeMedidaProduto.Size = new System.Drawing.Size(188, 18);
            this.labelUnidadeMedidaProduto.TabIndex = 128;
            this.labelUnidadeMedidaProduto.Text = "*UNIDADE DE MEDIDA:";
            // 
            // textBoxObsPedido
            // 
            this.textBoxObsPedido.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxObsPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "OBS", true));
            this.textBoxObsPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObsPedido.Location = new System.Drawing.Point(75, 453);
            this.textBoxObsPedido.Name = "textBoxObsPedido";
            this.textBoxObsPedido.Size = new System.Drawing.Size(561, 25);
            this.textBoxObsPedido.TabIndex = 144;
            // 
            // labelObservacoesPedido
            // 
            this.labelObservacoesPedido.AutoSize = true;
            this.labelObservacoesPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservacoesPedido.Location = new System.Drawing.Point(16, 457);
            this.labelObservacoesPedido.Name = "labelObservacoesPedido";
            this.labelObservacoesPedido.Size = new System.Drawing.Size(50, 18);
            this.labelObservacoesPedido.TabIndex = 143;
            this.labelObservacoesPedido.Text = "*OBS:";
            // 
            // textBoxValorParcelaPedido
            // 
            this.textBoxValorParcelaPedido.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxValorParcelaPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "VALOR_PARCELA", true));
            this.textBoxValorParcelaPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorParcelaPedido.Location = new System.Drawing.Point(184, 420);
            this.textBoxValorParcelaPedido.Name = "textBoxValorParcelaPedido";
            this.textBoxValorParcelaPedido.Size = new System.Drawing.Size(138, 25);
            this.textBoxValorParcelaPedido.TabIndex = 140;
            // 
            // labelQuantidadeParcelasPedido
            // 
            this.labelQuantidadeParcelasPedido.AutoSize = true;
            this.labelQuantidadeParcelasPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeParcelasPedido.Location = new System.Drawing.Point(65, 422);
            this.labelQuantidadeParcelasPedido.Name = "labelQuantidadeParcelasPedido";
            this.labelQuantidadeParcelasPedido.Size = new System.Drawing.Size(114, 18);
            this.labelQuantidadeParcelasPedido.TabIndex = 139;
            this.labelQuantidadeParcelasPedido.Text = "PARCELAS DE";
            // 
            // textBoxQuantidadeParcelasPedido
            // 
            this.textBoxQuantidadeParcelasPedido.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxQuantidadeParcelasPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "QTDD_PARCELAS", true));
            this.textBoxQuantidadeParcelasPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantidadeParcelasPedido.Location = new System.Drawing.Point(18, 419);
            this.textBoxQuantidadeParcelasPedido.Name = "textBoxQuantidadeParcelasPedido";
            this.textBoxQuantidadeParcelasPedido.Size = new System.Drawing.Size(41, 25);
            this.textBoxQuantidadeParcelasPedido.TabIndex = 138;
            // 
            // textBoxFormaPgtoPedido
            // 
            this.textBoxFormaPgtoPedido.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxFormaPgtoPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "FORMA_PAGTO", true));
            this.textBoxFormaPgtoPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFormaPgtoPedido.Location = new System.Drawing.Point(227, 387);
            this.textBoxFormaPgtoPedido.Name = "textBoxFormaPgtoPedido";
            this.textBoxFormaPgtoPedido.Size = new System.Drawing.Size(409, 25);
            this.textBoxFormaPgtoPedido.TabIndex = 137;
            // 
            // labelFormaPgtoPedido
            // 
            this.labelFormaPgtoPedido.AutoSize = true;
            this.labelFormaPgtoPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormaPgtoPedido.Location = new System.Drawing.Point(13, 394);
            this.labelFormaPgtoPedido.Name = "labelFormaPgtoPedido";
            this.labelFormaPgtoPedido.Size = new System.Drawing.Size(208, 18);
            this.labelFormaPgtoPedido.TabIndex = 136;
            this.labelFormaPgtoPedido.Text = "*FORMA DE PAGAMENTO:";
            // 
            // textBoxValorTotalPedido
            // 
            this.textBoxValorTotalPedido.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxValorTotalPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "VALOR_TOTAL", true));
            this.textBoxValorTotalPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorTotalPedido.Location = new System.Drawing.Point(482, 356);
            this.textBoxValorTotalPedido.Name = "textBoxValorTotalPedido";
            this.textBoxValorTotalPedido.Size = new System.Drawing.Size(154, 25);
            this.textBoxValorTotalPedido.TabIndex = 135;
            // 
            // labelValorTotalPedido
            // 
            this.labelValorTotalPedido.AutoSize = true;
            this.labelValorTotalPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalPedido.Location = new System.Drawing.Point(251, 359);
            this.labelValorTotalPedido.Name = "labelValorTotalPedido";
            this.labelValorTotalPedido.Size = new System.Drawing.Size(225, 18);
            this.labelValorTotalPedido.TabIndex = 134;
            this.labelValorTotalPedido.Text = "*VALOR TOTAL DO PEDIDO:";
            // 
            // textBoxQuantidadePedido
            // 
            this.textBoxQuantidadePedido.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxQuantidadePedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "QTDE", true));
            this.textBoxQuantidadePedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantidadePedido.Location = new System.Drawing.Point(144, 356);
            this.textBoxQuantidadePedido.Name = "textBoxQuantidadePedido";
            this.textBoxQuantidadePedido.Size = new System.Drawing.Size(101, 25);
            this.textBoxQuantidadePedido.TabIndex = 133;
            // 
            // labelQuantidadePedido
            // 
            this.labelQuantidadePedido.AutoSize = true;
            this.labelQuantidadePedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadePedido.Location = new System.Drawing.Point(13, 359);
            this.labelQuantidadePedido.Name = "labelQuantidadePedido";
            this.labelQuantidadePedido.Size = new System.Drawing.Size(126, 18);
            this.labelQuantidadePedido.TabIndex = 132;
            this.labelQuantidadePedido.Text = "*QUANTIDADE:";
            // 
            // textBoxValorVendaProduto
            // 
            this.textBoxValorVendaProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxValorVendaProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "VALOR_UNT_VENDA", true));
            this.textBoxValorVendaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorVendaProduto.Location = new System.Drawing.Point(488, 325);
            this.textBoxValorVendaProduto.Name = "textBoxValorVendaProduto";
            this.textBoxValorVendaProduto.Size = new System.Drawing.Size(149, 25);
            this.textBoxValorVendaProduto.TabIndex = 131;
            // 
            // textBoxCorProduto
            // 
            this.textBoxCorProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxCorProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "COR", true));
            this.textBoxCorProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorProduto.Location = new System.Drawing.Point(466, 263);
            this.textBoxCorProduto.Name = "textBoxCorProduto";
            this.textBoxCorProduto.Size = new System.Drawing.Size(170, 25);
            this.textBoxCorProduto.TabIndex = 125;
            // 
            // labelValorVendaProduto
            // 
            this.labelValorVendaProduto.AutoSize = true;
            this.labelValorVendaProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorVendaProduto.Location = new System.Drawing.Point(318, 328);
            this.labelValorVendaProduto.Name = "labelValorVendaProduto";
            this.labelValorVendaProduto.Size = new System.Drawing.Size(161, 18);
            this.labelValorVendaProduto.TabIndex = 130;
            this.labelValorVendaProduto.Text = "*VALOR DE VENDA:";
            // 
            // labelCorProduto
            // 
            this.labelCorProduto.AutoSize = true;
            this.labelCorProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorProduto.Location = new System.Drawing.Point(408, 266);
            this.labelCorProduto.Name = "labelCorProduto";
            this.labelCorProduto.Size = new System.Drawing.Size(52, 18);
            this.labelCorProduto.TabIndex = 124;
            this.labelCorProduto.Text = "*COR:";
            // 
            // textBoxDescricaoProduto
            // 
            this.textBoxDescricaoProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxDescricaoProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "DESCR_PROD", true));
            this.textBoxDescricaoProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricaoProduto.Location = new System.Drawing.Point(126, 294);
            this.textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            this.textBoxDescricaoProduto.Size = new System.Drawing.Size(510, 25);
            this.textBoxDescricaoProduto.TabIndex = 127;
            // 
            // textBoxCodProduto
            // 
            this.textBoxCodProduto.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxCodProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "COD_PROD", true));
            this.textBoxCodProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodProduto.Location = new System.Drawing.Point(212, 263);
            this.textBoxCodProduto.Name = "textBoxCodProduto";
            this.textBoxCodProduto.Size = new System.Drawing.Size(100, 25);
            this.textBoxCodProduto.TabIndex = 123;
            // 
            // labelDescricaoProduto
            // 
            this.labelDescricaoProduto.AutoSize = true;
            this.labelDescricaoProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricaoProduto.Location = new System.Drawing.Point(11, 301);
            this.labelDescricaoProduto.Name = "labelDescricaoProduto";
            this.labelDescricaoProduto.Size = new System.Drawing.Size(109, 18);
            this.labelDescricaoProduto.TabIndex = 126;
            this.labelDescricaoProduto.Text = "*DESCRIÇÃO:";
            // 
            // labelCodProduto
            // 
            this.labelCodProduto.AutoSize = true;
            this.labelCodProduto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodProduto.Location = new System.Drawing.Point(11, 270);
            this.labelCodProduto.Name = "labelCodProduto";
            this.labelCodProduto.Size = new System.Drawing.Size(195, 18);
            this.labelCodProduto.TabIndex = 122;
            this.labelCodProduto.Text = "*CODIGO DO PRODUTO:";
            // 
            // textBoxEmailCliente
            // 
            this.textBoxEmailCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxEmailCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "EMAIL", true));
            this.textBoxEmailCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailCliente.Location = new System.Drawing.Point(91, 136);
            this.textBoxEmailCliente.Name = "textBoxEmailCliente";
            this.textBoxEmailCliente.Size = new System.Drawing.Size(546, 25);
            this.textBoxEmailCliente.TabIndex = 109;
            // 
            // labelEmailCliente
            // 
            this.labelEmailCliente.AutoSize = true;
            this.labelEmailCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailCliente.Location = new System.Drawing.Point(12, 143);
            this.labelEmailCliente.Name = "labelEmailCliente";
            this.labelEmailCliente.Size = new System.Drawing.Size(73, 18);
            this.labelEmailCliente.TabIndex = 108;
            this.labelEmailCliente.Text = "*E-MAIL:";
            // 
            // textBoxCodCliente
            // 
            this.textBoxCodCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxCodCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "COD_CLIENTE", true));
            this.textBoxCodCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodCliente.Location = new System.Drawing.Point(144, 77);
            this.textBoxCodCliente.Name = "textBoxCodCliente";
            this.textBoxCodCliente.Size = new System.Drawing.Size(77, 25);
            this.textBoxCodCliente.TabIndex = 101;
            // 
            // labelCodCliente
            // 
            this.labelCodCliente.AutoSize = true;
            this.labelCodCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodCliente.Location = new System.Drawing.Point(12, 84);
            this.labelCodCliente.Name = "labelCodCliente";
            this.labelCodCliente.Size = new System.Drawing.Size(126, 18);
            this.labelCodCliente.TabIndex = 100;
            this.labelCodCliente.Text = "*COD CLIENTE:";
            // 
            // textBoxCidadeCliente
            // 
            this.textBoxCidadeCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxCidadeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "CIDADE", true));
            this.textBoxCidadeCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidadeCliente.Location = new System.Drawing.Point(102, 232);
            this.textBoxCidadeCliente.Name = "textBoxCidadeCliente";
            this.textBoxCidadeCliente.Size = new System.Drawing.Size(259, 25);
            this.textBoxCidadeCliente.TabIndex = 119;
            // 
            // textBoxBairroCliente
            // 
            this.textBoxBairroCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBairroCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "BAIRRO", true));
            this.textBoxBairroCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairroCliente.Location = new System.Drawing.Point(433, 198);
            this.textBoxBairroCliente.Name = "textBoxBairroCliente";
            this.textBoxBairroCliente.Size = new System.Drawing.Size(204, 25);
            this.textBoxBairroCliente.TabIndex = 117;
            // 
            // textBoxNumeroEndCliente
            // 
            this.textBoxNumeroEndCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxNumeroEndCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "NUM", true));
            this.textBoxNumeroEndCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroEndCliente.Location = new System.Drawing.Point(280, 198);
            this.textBoxNumeroEndCliente.Name = "textBoxNumeroEndCliente";
            this.textBoxNumeroEndCliente.Size = new System.Drawing.Size(63, 25);
            this.textBoxNumeroEndCliente.TabIndex = 115;
            // 
            // textBoxEnderecoCliente
            // 
            this.textBoxEnderecoCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxEnderecoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "ENDERECO", true));
            this.textBoxEnderecoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnderecoCliente.Location = new System.Drawing.Point(123, 167);
            this.textBoxEnderecoCliente.Name = "textBoxEnderecoCliente";
            this.textBoxEnderecoCliente.Size = new System.Drawing.Size(514, 25);
            this.textBoxEnderecoCliente.TabIndex = 111;
            // 
            // textBoxEstadoCliente
            // 
            this.textBoxEstadoCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxEstadoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "ESTADO", true));
            this.textBoxEstadoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstadoCliente.Location = new System.Drawing.Point(452, 233);
            this.textBoxEstadoCliente.Name = "textBoxEstadoCliente";
            this.textBoxEstadoCliente.Size = new System.Drawing.Size(185, 25);
            this.textBoxEstadoCliente.TabIndex = 121;
            // 
            // textBoxTelefoneCliente
            // 
            this.textBoxTelefoneCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxTelefoneCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "TELEFONE", true));
            this.textBoxTelefoneCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefoneCliente.Location = new System.Drawing.Point(406, 105);
            this.textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            this.textBoxTelefoneCliente.Size = new System.Drawing.Size(231, 25);
            this.textBoxTelefoneCliente.TabIndex = 107;
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPEDIDOSBindingSource, "NOME_CLIENTE", true));
            this.textBoxNomeCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeCliente.Location = new System.Drawing.Point(392, 74);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(245, 25);
            this.textBoxNomeCliente.TabIndex = 103;
            // 
            // labelCidadeCliente
            // 
            this.labelCidadeCliente.AutoSize = true;
            this.labelCidadeCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidadeCliente.Location = new System.Drawing.Point(16, 236);
            this.labelCidadeCliente.Name = "labelCidadeCliente";
            this.labelCidadeCliente.Size = new System.Drawing.Size(80, 18);
            this.labelCidadeCliente.TabIndex = 118;
            this.labelCidadeCliente.Text = "*CIDADE:";
            // 
            // labelBairroCliente
            // 
            this.labelBairroCliente.AutoSize = true;
            this.labelBairroCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairroCliente.Location = new System.Drawing.Point(349, 205);
            this.labelBairroCliente.Name = "labelBairroCliente";
            this.labelBairroCliente.Size = new System.Drawing.Size(78, 18);
            this.labelBairroCliente.TabIndex = 116;
            this.labelBairroCliente.Text = "*BAIRRO:";
            // 
            // labelNumeroEndCliente
            // 
            this.labelNumeroEndCliente.AutoSize = true;
            this.labelNumeroEndCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroEndCliente.Location = new System.Drawing.Point(185, 205);
            this.labelNumeroEndCliente.Name = "labelNumeroEndCliente";
            this.labelNumeroEndCliente.Size = new System.Drawing.Size(89, 18);
            this.labelNumeroEndCliente.TabIndex = 114;
            this.labelNumeroEndCliente.Text = "*NÚMERO:";
            // 
            // labelEnderecoCliente
            // 
            this.labelEnderecoCliente.AutoSize = true;
            this.labelEnderecoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnderecoCliente.Location = new System.Drawing.Point(12, 174);
            this.labelEnderecoCliente.Name = "labelEnderecoCliente";
            this.labelEnderecoCliente.Size = new System.Drawing.Size(109, 18);
            this.labelEnderecoCliente.TabIndex = 110;
            this.labelEnderecoCliente.Text = "*ENDEREÇO:";
            // 
            // labelEstadoCliente
            // 
            this.labelEstadoCliente.AutoSize = true;
            this.labelEstadoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoCliente.Location = new System.Drawing.Point(367, 239);
            this.labelEstadoCliente.Name = "labelEstadoCliente";
            this.labelEstadoCliente.Size = new System.Drawing.Size(84, 18);
            this.labelEstadoCliente.TabIndex = 120;
            this.labelEstadoCliente.Text = "*ESTADO:";
            // 
            // labelCepCliente
            // 
            this.labelCepCliente.AutoSize = true;
            this.labelCepCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCepCliente.Location = new System.Drawing.Point(16, 205);
            this.labelCepCliente.Name = "labelCepCliente";
            this.labelCepCliente.Size = new System.Drawing.Size(49, 18);
            this.labelCepCliente.TabIndex = 112;
            this.labelCepCliente.Text = "*CEP:";
            // 
            // labelTelefoneCliente
            // 
            this.labelTelefoneCliente.AutoSize = true;
            this.labelTelefoneCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefoneCliente.Location = new System.Drawing.Point(284, 112);
            this.labelTelefoneCliente.Name = "labelTelefoneCliente";
            this.labelTelefoneCliente.Size = new System.Drawing.Size(105, 18);
            this.labelTelefoneCliente.TabIndex = 106;
            this.labelTelefoneCliente.Text = "*TELEFONE:";
            // 
            // labelCpfCliente
            // 
            this.labelCpfCliente.AutoSize = true;
            this.labelCpfCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpfCliente.Location = new System.Drawing.Point(12, 112);
            this.labelCpfCliente.Name = "labelCpfCliente";
            this.labelCpfCliente.Size = new System.Drawing.Size(47, 18);
            this.labelCpfCliente.TabIndex = 104;
            this.labelCpfCliente.Text = "*CPF:";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(318, 81);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(68, 18);
            this.labelNomeCliente.TabIndex = 102;
            this.labelNomeCliente.Text = "*NOME:";
            // 
            // labelDataPedido
            // 
            this.labelDataPedido.AutoSize = true;
            this.labelDataPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataPedido.Location = new System.Drawing.Point(341, 50);
            this.labelDataPedido.Name = "labelDataPedido";
            this.labelDataPedido.Size = new System.Drawing.Size(158, 18);
            this.labelDataPedido.TabIndex = 98;
            this.labelDataPedido.Text = "*DATA DO PEDIDO:";
            // 
            // labelNumeroPedido
            // 
            this.labelNumeroPedido.AutoSize = true;
            this.labelNumeroPedido.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroPedido.Location = new System.Drawing.Point(12, 50);
            this.labelNumeroPedido.Name = "labelNumeroPedido";
            this.labelNumeroPedido.Size = new System.Drawing.Size(184, 18);
            this.labelNumeroPedido.TabIndex = 97;
            this.labelNumeroPedido.Text = "*NÚMERO DO PEDIDO:";
            // 
            // btExcluirPedido
            // 
            this.btExcluirPedido.BackColor = System.Drawing.Color.Red;
            this.btExcluirPedido.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluirPedido.Location = new System.Drawing.Point(655, 136);
            this.btExcluirPedido.Name = "btExcluirPedido";
            this.btExcluirPedido.Size = new System.Drawing.Size(133, 63);
            this.btExcluirPedido.TabIndex = 148;
            this.btExcluirPedido.Text = "EXCLUIR";
            this.btExcluirPedido.UseVisualStyleBackColor = false;
            this.btExcluirPedido.Click += new System.EventHandler(this.btExcluirPedido_Click);
            // 
            // ConsultaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(814, 520);
            this.Controls.Add(this.btExcluirPedido);
            this.Controls.Add(this.btCarregarProduto);
            this.Controls.Add(this.btCarregarCliente);
            this.Controls.Add(this.labelNumPedido);
            this.Controls.Add(this.maskedTextBoxVcto1ParcelaPedido);
            this.Controls.Add(this.maskedTextBoxCepCliente);
            this.Controls.Add(this.maskedTextBoxDataCadastroPedido);
            this.Controls.Add(this.maskedTextBoxCPFCliente);
            this.Controls.Add(this.labelVcto1ParcelaPedido);
            this.Controls.Add(this.textBoxUnidadeMedidaProduto);
            this.Controls.Add(this.labelUnidadeMedidaProduto);
            this.Controls.Add(this.textBoxObsPedido);
            this.Controls.Add(this.labelObservacoesPedido);
            this.Controls.Add(this.textBoxValorParcelaPedido);
            this.Controls.Add(this.labelQuantidadeParcelasPedido);
            this.Controls.Add(this.textBoxQuantidadeParcelasPedido);
            this.Controls.Add(this.textBoxFormaPgtoPedido);
            this.Controls.Add(this.labelFormaPgtoPedido);
            this.Controls.Add(this.textBoxValorTotalPedido);
            this.Controls.Add(this.labelValorTotalPedido);
            this.Controls.Add(this.textBoxQuantidadePedido);
            this.Controls.Add(this.labelQuantidadePedido);
            this.Controls.Add(this.textBoxValorVendaProduto);
            this.Controls.Add(this.textBoxCorProduto);
            this.Controls.Add(this.labelValorVendaProduto);
            this.Controls.Add(this.labelCorProduto);
            this.Controls.Add(this.textBoxDescricaoProduto);
            this.Controls.Add(this.textBoxCodProduto);
            this.Controls.Add(this.labelDescricaoProduto);
            this.Controls.Add(this.labelCodProduto);
            this.Controls.Add(this.textBoxEmailCliente);
            this.Controls.Add(this.labelEmailCliente);
            this.Controls.Add(this.textBoxCodCliente);
            this.Controls.Add(this.labelCodCliente);
            this.Controls.Add(this.textBoxCidadeCliente);
            this.Controls.Add(this.textBoxBairroCliente);
            this.Controls.Add(this.textBoxNumeroEndCliente);
            this.Controls.Add(this.textBoxEnderecoCliente);
            this.Controls.Add(this.textBoxEstadoCliente);
            this.Controls.Add(this.textBoxTelefoneCliente);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.labelCidadeCliente);
            this.Controls.Add(this.labelBairroCliente);
            this.Controls.Add(this.labelNumeroEndCliente);
            this.Controls.Add(this.labelEnderecoCliente);
            this.Controls.Add(this.labelEstadoCliente);
            this.Controls.Add(this.labelCepCliente);
            this.Controls.Add(this.labelTelefoneCliente);
            this.Controls.Add(this.labelCpfCliente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.labelDataPedido);
            this.Controls.Add(this.labelNumeroPedido);
            this.Controls.Add(this.btFecharConsulta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvarPedido);
            this.Name = "ConsultaPedido";
            this.ShowIcon = false;
            this.Text = "Consulta de Pedido";
            this.Load += new System.EventHandler(this.ConsultaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBPEDIDOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFecharConsulta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvarPedido;
        private PI_SeniorTechDataSet pI_SeniorTechDataSet;
        private System.Windows.Forms.BindingSource tBPEDIDOSBindingSource;
        private PI_SeniorTechDataSetTableAdapters.TB_PEDIDOSTableAdapter tB_PEDIDOSTableAdapter;
        private System.Windows.Forms.Button btCarregarProduto;
        private System.Windows.Forms.Button btCarregarCliente;
        private System.Windows.Forms.Label labelNumPedido;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVcto1ParcelaPedido;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCepCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataCadastroPedido;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPFCliente;
        private System.Windows.Forms.Label labelVcto1ParcelaPedido;
        private System.Windows.Forms.TextBox textBoxUnidadeMedidaProduto;
        private System.Windows.Forms.Label labelUnidadeMedidaProduto;
        private System.Windows.Forms.TextBox textBoxObsPedido;
        private System.Windows.Forms.Label labelObservacoesPedido;
        private System.Windows.Forms.TextBox textBoxValorParcelaPedido;
        private System.Windows.Forms.Label labelQuantidadeParcelasPedido;
        private System.Windows.Forms.TextBox textBoxQuantidadeParcelasPedido;
        private System.Windows.Forms.TextBox textBoxFormaPgtoPedido;
        private System.Windows.Forms.Label labelFormaPgtoPedido;
        private System.Windows.Forms.TextBox textBoxValorTotalPedido;
        private System.Windows.Forms.Label labelValorTotalPedido;
        private System.Windows.Forms.TextBox textBoxQuantidadePedido;
        private System.Windows.Forms.Label labelQuantidadePedido;
        private System.Windows.Forms.TextBox textBoxValorVendaProduto;
        private System.Windows.Forms.TextBox textBoxCorProduto;
        private System.Windows.Forms.Label labelValorVendaProduto;
        private System.Windows.Forms.Label labelCorProduto;
        private System.Windows.Forms.TextBox textBoxDescricaoProduto;
        private System.Windows.Forms.TextBox textBoxCodProduto;
        private System.Windows.Forms.Label labelDescricaoProduto;
        private System.Windows.Forms.Label labelCodProduto;
        private System.Windows.Forms.TextBox textBoxEmailCliente;
        private System.Windows.Forms.Label labelEmailCliente;
        private System.Windows.Forms.TextBox textBoxCodCliente;
        private System.Windows.Forms.Label labelCodCliente;
        private System.Windows.Forms.TextBox textBoxCidadeCliente;
        private System.Windows.Forms.TextBox textBoxBairroCliente;
        private System.Windows.Forms.TextBox textBoxNumeroEndCliente;
        private System.Windows.Forms.TextBox textBoxEnderecoCliente;
        private System.Windows.Forms.TextBox textBoxEstadoCliente;
        private System.Windows.Forms.TextBox textBoxTelefoneCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label labelCidadeCliente;
        private System.Windows.Forms.Label labelBairroCliente;
        private System.Windows.Forms.Label labelNumeroEndCliente;
        private System.Windows.Forms.Label labelEnderecoCliente;
        private System.Windows.Forms.Label labelEstadoCliente;
        private System.Windows.Forms.Label labelCepCliente;
        private System.Windows.Forms.Label labelTelefoneCliente;
        private System.Windows.Forms.Label labelCpfCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label labelDataPedido;
        private System.Windows.Forms.Label labelNumeroPedido;
        private System.Windows.Forms.Button btExcluirPedido;
    }
}

namespace PI_SeniorTech
{
    partial class ConsultaCliente
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
            this.tBCLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI_SeniorTechDataSet = new PI_SeniorTech.PI_SeniorTechDataSet();
            this.tB_CLIENTESTableAdapter = new PI_SeniorTech.PI_SeniorTechDataSetTableAdapters.TB_CLIENTESTableAdapter();
            this.btSalvarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.btConsultarCep = new System.Windows.Forms.Button();
            this.maskedTextBoxDataCadastroCliente = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataNascimentoCliente = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmailCliente = new System.Windows.Forms.TextBox();
            this.labelEmailCliente = new System.Windows.Forms.Label();
            this.textBoxCidadeCliente = new System.Windows.Forms.TextBox();
            this.textBoxBairroCliente = new System.Windows.Forms.TextBox();
            this.textBoxNumeroEndCliente = new System.Windows.Forms.TextBox();
            this.textBoxEnderecoCliente = new System.Windows.Forms.TextBox();
            this.textBoxEstadoCliente = new System.Windows.Forms.TextBox();
            this.textBoxTelefoneCliente = new System.Windows.Forms.TextBox();
            this.textBoxGeneroCliente = new System.Windows.Forms.TextBox();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelCidadeCliente = new System.Windows.Forms.Label();
            this.labelBairroCliente = new System.Windows.Forms.Label();
            this.labelNumeroEndCliente = new System.Windows.Forms.Label();
            this.labelEnderecoCliente = new System.Windows.Forms.Label();
            this.labelEstadoCliente = new System.Windows.Forms.Label();
            this.labelCepCliente = new System.Windows.Forms.Label();
            this.labelTelefoneCliente = new System.Windows.Forms.Label();
            this.labelGeneroCliente = new System.Windows.Forms.Label();
            this.labelCpfCliente = new System.Windows.Forms.Label();
            this.labelDataNascimentoCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelDataCadastroCliente = new System.Windows.Forms.Label();
            this.labelCodCliente = new System.Windows.Forms.Label();
            this.btFecharConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBCLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).BeginInit();
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
            // tB_CLIENTESTableAdapter
            // 
            this.tB_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // btSalvarCliente
            // 
            this.btSalvarCliente.BackColor = System.Drawing.Color.Goldenrod;
            this.btSalvarCliente.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalvarCliente.Location = new System.Drawing.Point(655, 8);
            this.btSalvarCliente.Name = "btSalvarCliente";
            this.btSalvarCliente.Size = new System.Drawing.Size(133, 63);
            this.btSalvarCliente.TabIndex = 30;
            this.btSalvarCliente.Text = "SALVAR";
            this.btSalvarCliente.UseVisualStyleBackColor = false;
            this.btSalvarCliente.Click += new System.EventHandler(this.btSelecionarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Selecione o Cliente: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBCLIENTESBindingSource;
            this.comboBox1.DisplayMember = "NOME_CLIENTE";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(515, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "COD_CLIENTE";
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCodigoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "COD_CLIENTE", true));
            this.labelCodigoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoCliente.Location = new System.Drawing.Point(102, 36);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(15, 20);
            this.labelCodigoCliente.TabIndex = 62;
            this.labelCodigoCliente.Text = "-";
            // 
            // btConsultarCep
            // 
            this.btConsultarCep.BackColor = System.Drawing.Color.ForestGreen;
            this.btConsultarCep.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarCep.ForeColor = System.Drawing.Color.Honeydew;
            this.btConsultarCep.Location = new System.Drawing.Point(166, 230);
            this.btConsultarCep.Name = "btConsultarCep";
            this.btConsultarCep.Size = new System.Drawing.Size(112, 29);
            this.btConsultarCep.TabIndex = 61;
            this.btConsultarCep.Text = "Consultar CEP";
            this.btConsultarCep.UseVisualStyleBackColor = false;
            this.btConsultarCep.Click += new System.EventHandler(this.btConsultarCep_Click);
            // 
            // maskedTextBoxDataCadastroCliente
            // 
            this.maskedTextBoxDataCadastroCliente.BackColor = System.Drawing.Color.Honeydew;
            this.maskedTextBoxDataCadastroCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "DT_CADASTRO", true));
            this.maskedTextBoxDataCadastroCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataCadastroCliente.Location = new System.Drawing.Point(469, 33);
            this.maskedTextBoxDataCadastroCliente.Mask = "00/00/0000";
            this.maskedTextBoxDataCadastroCliente.Name = "maskedTextBoxDataCadastroCliente";
            this.maskedTextBoxDataCadastroCliente.Size = new System.Drawing.Size(168, 25);
            this.maskedTextBoxDataCadastroCliente.TabIndex = 36;
            this.maskedTextBoxDataCadastroCliente.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDataNascimentoCliente
            // 
            this.maskedTextBoxDataNascimentoCliente.BackColor = System.Drawing.Color.Honeydew;
            this.maskedTextBoxDataNascimentoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "DT_NASC", true));
            this.maskedTextBoxDataNascimentoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataNascimentoCliente.Location = new System.Drawing.Point(217, 111);
            this.maskedTextBoxDataNascimentoCliente.Mask = "00/00/0000";
            this.maskedTextBoxDataNascimentoCliente.Name = "maskedTextBoxDataNascimentoCliente";
            this.maskedTextBoxDataNascimentoCliente.Size = new System.Drawing.Size(107, 25);
            this.maskedTextBoxDataNascimentoCliente.TabIndex = 40;
            this.maskedTextBoxDataNascimentoCliente.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxCepCliente
            // 
            this.maskedTextBoxCepCliente.BackColor = System.Drawing.Color.Honeydew;
            this.maskedTextBoxCepCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "CEP", true));
            this.maskedTextBoxCepCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCepCliente.Location = new System.Drawing.Point(65, 232);
            this.maskedTextBoxCepCliente.Mask = "00,000-000";
            this.maskedTextBoxCepCliente.Name = "maskedTextBoxCepCliente";
            this.maskedTextBoxCepCliente.Size = new System.Drawing.Size(95, 25);
            this.maskedTextBoxCepCliente.TabIndex = 50;
            // 
            // maskedTextBoxCPFCliente
            // 
            this.maskedTextBoxCPFCliente.BackColor = System.Drawing.Color.Honeydew;
            this.maskedTextBoxCPFCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "CPF", true));
            this.maskedTextBoxCPFCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCPFCliente.Location = new System.Drawing.Point(514, 111);
            this.maskedTextBoxCPFCliente.Mask = "000,000,000-00";
            this.maskedTextBoxCPFCliente.Name = "maskedTextBoxCPFCliente";
            this.maskedTextBoxCPFCliente.Size = new System.Drawing.Size(123, 25);
            this.maskedTextBoxCPFCliente.TabIndex = 42;
            // 
            // textBoxEmailCliente
            // 
            this.textBoxEmailCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxEmailCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "EMAIL", true));
            this.textBoxEmailCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailCliente.Location = new System.Drawing.Point(91, 193);
            this.textBoxEmailCliente.Name = "textBoxEmailCliente";
            this.textBoxEmailCliente.Size = new System.Drawing.Size(546, 25);
            this.textBoxEmailCliente.TabIndex = 48;
            // 
            // labelEmailCliente
            // 
            this.labelEmailCliente.AutoSize = true;
            this.labelEmailCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailCliente.Location = new System.Drawing.Point(12, 200);
            this.labelEmailCliente.Name = "labelEmailCliente";
            this.labelEmailCliente.Size = new System.Drawing.Size(73, 18);
            this.labelEmailCliente.TabIndex = 47;
            this.labelEmailCliente.Text = "*E-MAIL:";
            // 
            // textBoxCidadeCliente
            // 
            this.textBoxCidadeCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxCidadeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "CIDADE", true));
            this.textBoxCidadeCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidadeCliente.Location = new System.Drawing.Point(93, 354);
            this.textBoxCidadeCliente.Name = "textBoxCidadeCliente";
            this.textBoxCidadeCliente.Size = new System.Drawing.Size(544, 25);
            this.textBoxCidadeCliente.TabIndex = 60;
            // 
            // textBoxBairroCliente
            // 
            this.textBoxBairroCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBairroCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "BAIRRO", true));
            this.textBoxBairroCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairroCliente.Location = new System.Drawing.Point(368, 309);
            this.textBoxBairroCliente.Name = "textBoxBairroCliente";
            this.textBoxBairroCliente.Size = new System.Drawing.Size(269, 25);
            this.textBoxBairroCliente.TabIndex = 58;
            // 
            // textBoxNumeroEndCliente
            // 
            this.textBoxNumeroEndCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxNumeroEndCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "NUM", true));
            this.textBoxNumeroEndCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroEndCliente.Location = new System.Drawing.Point(102, 309);
            this.textBoxNumeroEndCliente.Name = "textBoxNumeroEndCliente";
            this.textBoxNumeroEndCliente.Size = new System.Drawing.Size(168, 25);
            this.textBoxNumeroEndCliente.TabIndex = 56;
            // 
            // textBoxEnderecoCliente
            // 
            this.textBoxEnderecoCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxEnderecoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "ENDERECO", true));
            this.textBoxEnderecoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnderecoCliente.Location = new System.Drawing.Point(123, 268);
            this.textBoxEnderecoCliente.Name = "textBoxEnderecoCliente";
            this.textBoxEnderecoCliente.Size = new System.Drawing.Size(514, 25);
            this.textBoxEnderecoCliente.TabIndex = 54;
            // 
            // textBoxEstadoCliente
            // 
            this.textBoxEstadoCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxEstadoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "ESTADO", true));
            this.textBoxEstadoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstadoCliente.Location = new System.Drawing.Point(378, 232);
            this.textBoxEstadoCliente.Name = "textBoxEstadoCliente";
            this.textBoxEstadoCliente.Size = new System.Drawing.Size(259, 25);
            this.textBoxEstadoCliente.TabIndex = 52;
            // 
            // textBoxTelefoneCliente
            // 
            this.textBoxTelefoneCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxTelefoneCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "TELEFONE", true));
            this.textBoxTelefoneCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefoneCliente.Location = new System.Drawing.Point(433, 152);
            this.textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            this.textBoxTelefoneCliente.Size = new System.Drawing.Size(204, 25);
            this.textBoxTelefoneCliente.TabIndex = 46;
            // 
            // textBoxGeneroCliente
            // 
            this.textBoxGeneroCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxGeneroCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "GENERO", true));
            this.textBoxGeneroCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGeneroCliente.Location = new System.Drawing.Point(106, 152);
            this.textBoxGeneroCliente.Name = "textBoxGeneroCliente";
            this.textBoxGeneroCliente.Size = new System.Drawing.Size(196, 25);
            this.textBoxGeneroCliente.TabIndex = 44;
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCLIENTESBindingSource, "NOME_CLIENTE", true));
            this.textBoxNomeCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeCliente.Location = new System.Drawing.Point(102, 71);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(535, 25);
            this.textBoxNomeCliente.TabIndex = 38;
            // 
            // labelCidadeCliente
            // 
            this.labelCidadeCliente.AutoSize = true;
            this.labelCidadeCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidadeCliente.Location = new System.Drawing.Point(11, 361);
            this.labelCidadeCliente.Name = "labelCidadeCliente";
            this.labelCidadeCliente.Size = new System.Drawing.Size(80, 18);
            this.labelCidadeCliente.TabIndex = 59;
            this.labelCidadeCliente.Text = "*CIDADE:";
            // 
            // labelBairroCliente
            // 
            this.labelBairroCliente.AutoSize = true;
            this.labelBairroCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairroCliente.Location = new System.Drawing.Point(284, 316);
            this.labelBairroCliente.Name = "labelBairroCliente";
            this.labelBairroCliente.Size = new System.Drawing.Size(78, 18);
            this.labelBairroCliente.TabIndex = 57;
            this.labelBairroCliente.Text = "*BAIRRO:";
            // 
            // labelNumeroEndCliente
            // 
            this.labelNumeroEndCliente.AutoSize = true;
            this.labelNumeroEndCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroEndCliente.Location = new System.Drawing.Point(12, 316);
            this.labelNumeroEndCliente.Name = "labelNumeroEndCliente";
            this.labelNumeroEndCliente.Size = new System.Drawing.Size(89, 18);
            this.labelNumeroEndCliente.TabIndex = 55;
            this.labelNumeroEndCliente.Text = "*NÚMERO:";
            // 
            // labelEnderecoCliente
            // 
            this.labelEnderecoCliente.AutoSize = true;
            this.labelEnderecoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnderecoCliente.Location = new System.Drawing.Point(12, 275);
            this.labelEnderecoCliente.Name = "labelEnderecoCliente";
            this.labelEnderecoCliente.Size = new System.Drawing.Size(109, 18);
            this.labelEnderecoCliente.TabIndex = 53;
            this.labelEnderecoCliente.Text = "*ENDEREÇO:";
            // 
            // labelEstadoCliente
            // 
            this.labelEstadoCliente.AutoSize = true;
            this.labelEstadoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoCliente.Location = new System.Drawing.Point(284, 239);
            this.labelEstadoCliente.Name = "labelEstadoCliente";
            this.labelEstadoCliente.Size = new System.Drawing.Size(84, 18);
            this.labelEstadoCliente.TabIndex = 51;
            this.labelEstadoCliente.Text = "*ESTADO:";
            // 
            // labelCepCliente
            // 
            this.labelCepCliente.AutoSize = true;
            this.labelCepCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCepCliente.Location = new System.Drawing.Point(12, 239);
            this.labelCepCliente.Name = "labelCepCliente";
            this.labelCepCliente.Size = new System.Drawing.Size(49, 18);
            this.labelCepCliente.TabIndex = 49;
            this.labelCepCliente.Text = "*CEP:";
            // 
            // labelTelefoneCliente
            // 
            this.labelTelefoneCliente.AutoSize = true;
            this.labelTelefoneCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefoneCliente.Location = new System.Drawing.Point(322, 159);
            this.labelTelefoneCliente.Name = "labelTelefoneCliente";
            this.labelTelefoneCliente.Size = new System.Drawing.Size(105, 18);
            this.labelTelefoneCliente.TabIndex = 45;
            this.labelTelefoneCliente.Text = "*TELEFONE:";
            // 
            // labelGeneroCliente
            // 
            this.labelGeneroCliente.AutoSize = true;
            this.labelGeneroCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneroCliente.Location = new System.Drawing.Point(12, 159);
            this.labelGeneroCliente.Name = "labelGeneroCliente";
            this.labelGeneroCliente.Size = new System.Drawing.Size(88, 18);
            this.labelGeneroCliente.TabIndex = 43;
            this.labelGeneroCliente.Text = "*GÊNERO:";
            // 
            // labelCpfCliente
            // 
            this.labelCpfCliente.AutoSize = true;
            this.labelCpfCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpfCliente.Location = new System.Drawing.Point(459, 118);
            this.labelCpfCliente.Name = "labelCpfCliente";
            this.labelCpfCliente.Size = new System.Drawing.Size(47, 18);
            this.labelCpfCliente.TabIndex = 41;
            this.labelCpfCliente.Text = "*CPF:";
            // 
            // labelDataNascimentoCliente
            // 
            this.labelDataNascimentoCliente.AutoSize = true;
            this.labelDataNascimentoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimentoCliente.Location = new System.Drawing.Point(12, 118);
            this.labelDataNascimentoCliente.Name = "labelDataNascimentoCliente";
            this.labelDataNascimentoCliente.Size = new System.Drawing.Size(199, 18);
            this.labelDataNascimentoCliente.TabIndex = 39;
            this.labelDataNascimentoCliente.Text = "*DATA DE NASCIMENTO:";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(12, 78);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(68, 18);
            this.labelNomeCliente.TabIndex = 37;
            this.labelNomeCliente.Text = "*NOME:";
            // 
            // labelDataCadastroCliente
            // 
            this.labelDataCadastroCliente.AutoSize = true;
            this.labelDataCadastroCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataCadastroCliente.Location = new System.Drawing.Point(284, 40);
            this.labelDataCadastroCliente.Name = "labelDataCadastroCliente";
            this.labelDataCadastroCliente.Size = new System.Drawing.Size(179, 18);
            this.labelDataCadastroCliente.TabIndex = 35;
            this.labelDataCadastroCliente.Text = "*DATA DE CADASTRO:";
            // 
            // labelCodCliente
            // 
            this.labelCodCliente.AutoSize = true;
            this.labelCodCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodCliente.Location = new System.Drawing.Point(12, 40);
            this.labelCodCliente.Name = "labelCodCliente";
            this.labelCodCliente.Size = new System.Drawing.Size(84, 18);
            this.labelCodCliente.TabIndex = 34;
            this.labelCodCliente.Text = "*CODIGO:";
            // 
            // btFecharConsulta
            // 
            this.btFecharConsulta.BackColor = System.Drawing.Color.LightCoral;
            this.btFecharConsulta.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFecharConsulta.Location = new System.Drawing.Point(655, 100);
            this.btFecharConsulta.Name = "btFecharConsulta";
            this.btFecharConsulta.Size = new System.Drawing.Size(133, 63);
            this.btFecharConsulta.TabIndex = 63;
            this.btFecharConsulta.Text = "FECHAR";
            this.btFecharConsulta.UseVisualStyleBackColor = false;
            this.btFecharConsulta.Click += new System.EventHandler(this.btFecharConsulta_Click);
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.btFecharConsulta);
            this.Controls.Add(this.labelCodigoCliente);
            this.Controls.Add(this.btConsultarCep);
            this.Controls.Add(this.maskedTextBoxDataCadastroCliente);
            this.Controls.Add(this.maskedTextBoxDataNascimentoCliente);
            this.Controls.Add(this.maskedTextBoxCepCliente);
            this.Controls.Add(this.maskedTextBoxCPFCliente);
            this.Controls.Add(this.textBoxEmailCliente);
            this.Controls.Add(this.labelEmailCliente);
            this.Controls.Add(this.textBoxCidadeCliente);
            this.Controls.Add(this.textBoxBairroCliente);
            this.Controls.Add(this.textBoxNumeroEndCliente);
            this.Controls.Add(this.textBoxEnderecoCliente);
            this.Controls.Add(this.textBoxEstadoCliente);
            this.Controls.Add(this.textBoxTelefoneCliente);
            this.Controls.Add(this.textBoxGeneroCliente);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.labelCidadeCliente);
            this.Controls.Add(this.labelBairroCliente);
            this.Controls.Add(this.labelNumeroEndCliente);
            this.Controls.Add(this.labelEnderecoCliente);
            this.Controls.Add(this.labelEstadoCliente);
            this.Controls.Add(this.labelCepCliente);
            this.Controls.Add(this.labelTelefoneCliente);
            this.Controls.Add(this.labelGeneroCliente);
            this.Controls.Add(this.labelCpfCliente);
            this.Controls.Add(this.labelDataNascimentoCliente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.labelDataCadastroCliente);
            this.Controls.Add(this.labelCodCliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvarCliente);
            this.Name = "ConsultaCliente";
            this.ShowIcon = false;
            this.Text = "Consulta de Cliente";
            this.Load += new System.EventHandler(this.ConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBCLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI_SeniorTechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PI_SeniorTechDataSet pI_SeniorTechDataSet;
        private System.Windows.Forms.BindingSource tBCLIENTESBindingSource;
        private PI_SeniorTechDataSetTableAdapters.TB_CLIENTESTableAdapter tB_CLIENTESTableAdapter;
        private System.Windows.Forms.Button btSalvarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelCodigoCliente;
        private System.Windows.Forms.Button btConsultarCep;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataCadastroCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataNascimentoCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCepCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPFCliente;
        private System.Windows.Forms.TextBox textBoxEmailCliente;
        private System.Windows.Forms.Label labelEmailCliente;
        private System.Windows.Forms.TextBox textBoxCidadeCliente;
        private System.Windows.Forms.TextBox textBoxBairroCliente;
        private System.Windows.Forms.TextBox textBoxNumeroEndCliente;
        private System.Windows.Forms.TextBox textBoxEnderecoCliente;
        private System.Windows.Forms.TextBox textBoxEstadoCliente;
        private System.Windows.Forms.TextBox textBoxTelefoneCliente;
        private System.Windows.Forms.TextBox textBoxGeneroCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label labelCidadeCliente;
        private System.Windows.Forms.Label labelBairroCliente;
        private System.Windows.Forms.Label labelNumeroEndCliente;
        private System.Windows.Forms.Label labelEnderecoCliente;
        private System.Windows.Forms.Label labelEstadoCliente;
        private System.Windows.Forms.Label labelCepCliente;
        private System.Windows.Forms.Label labelTelefoneCliente;
        private System.Windows.Forms.Label labelGeneroCliente;
        private System.Windows.Forms.Label labelCpfCliente;
        private System.Windows.Forms.Label labelDataNascimentoCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label labelDataCadastroCliente;
        private System.Windows.Forms.Label labelCodCliente;
        private System.Windows.Forms.Button btFecharConsulta;
    }
}
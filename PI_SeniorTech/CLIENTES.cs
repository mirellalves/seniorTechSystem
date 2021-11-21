using System;
using System.Windows.Forms;

namespace PI_SeniorTech
{
    public partial class CLIENTES : Form
    {
        public CLIENTES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConsultarCep_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(maskedTextBoxCepCliente.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(maskedTextBoxCepCliente.Text.Trim());

                        textBoxEstadoCliente.Text = endereco.uf;
                        textBoxCidadeCliente.Text = endereco.cidade;
                        textBoxBairroCliente.Text = endereco.bairro;
                        textBoxEnderecoCliente.Text = endereco.end;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Informe um CEP válido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadcliente = new CadastrarCliente(maskedTextBoxDataCadastroCliente.Text, textBoxNomeCliente.Text, maskedTextBoxDataNascimentoCliente.Text, maskedTextBoxCPFCliente.Text, textBoxGeneroCliente.Text, textBoxTelefoneCliente.Text, textBoxEmailCliente.Text, maskedTextBoxCepCliente.Text, textBoxEstadoCliente.Text, textBoxEnderecoCliente.Text, textBoxNumeroEndCliente.Text, textBoxBairroCliente.Text, textBoxCidadeCliente.Text);
            MessageBox.Show(cadcliente.mensagem);

            maskedTextBoxDataCadastroCliente.Text = "";
            textBoxNomeCliente.Text = "";
            maskedTextBoxDataNascimentoCliente.Text = "";
            maskedTextBoxCPFCliente.Text = "";
            textBoxGeneroCliente.Text = "";
            textBoxTelefoneCliente.Text = "";
            textBoxEmailCliente.Text = "";
            maskedTextBoxCepCliente.Text = "";
            textBoxEstadoCliente.Text = "";
            textBoxEnderecoCliente.Text = "";
            textBoxNumeroEndCliente.Text = "";
            textBoxBairroCliente.Text = "";
            textBoxCidadeCliente.Text = "";
            maskedTextBoxDataCadastroCliente.Focus();

        }

        private void btPesquisarCliente_Click(object sender, EventArgs e)
        {
            ConsultaCliente cs = new ConsultaCliente();
            cs.Show();
        }
    }
}

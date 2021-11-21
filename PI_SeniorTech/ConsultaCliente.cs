using System;
using System.Data;
using System.Windows.Forms;

namespace PI_SeniorTech
{
    public partial class ConsultaCliente : Form
    {
        DataTable dt = new DataTable();
        CLIENTES GetCLIENTES = new CLIENTES();


        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pI_SeniorTechDataSet.TB_CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_CLIENTESTableAdapter.Fill(this.pI_SeniorTechDataSet.TB_CLIENTES);
        }

        //private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridViewClientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //    {
        //        MessageBox.Show(dataGridViewClientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        //    }

        //}

        private void btSelecionarCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente consultcliente = new ConsultarCliente(maskedTextBoxDataCadastroCliente.Text, textBoxNomeCliente.Text, maskedTextBoxDataNascimentoCliente.Text, maskedTextBoxCPFCliente.Text, textBoxGeneroCliente.Text, textBoxTelefoneCliente.Text, textBoxEmailCliente.Text, maskedTextBoxCepCliente.Text, textBoxEstadoCliente.Text, textBoxEnderecoCliente.Text, textBoxNumeroEndCliente.Text, textBoxBairroCliente.Text, textBoxCidadeCliente.Text, labelCodigoCliente.Text);
            MessageBox.Show(consultcliente.mensagem);
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
        }

        private void btFecharConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
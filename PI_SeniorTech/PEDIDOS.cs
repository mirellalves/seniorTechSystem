using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PI_SeniorTech
{
    public partial class PEDIDOS : Form
    {
        public PEDIDOS()
        {
            InitializeComponent();
        }

        private void btCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrarPedido_Click(object sender, EventArgs e)
        {
            CadastrarPedido cadpedido = new CadastrarPedido(maskedTextBoxDataCadastroPedido.Text, textBoxCodCliente.Text, textBoxNomeCliente.Text, maskedTextBoxCPFCliente.Text, textBoxTelefoneCliente.Text, textBoxEmailCliente.Text, textBoxEnderecoCliente.Text, maskedTextBoxCepCliente.Text, textBoxNumeroEndCliente.Text, textBoxBairroCliente.Text, textBoxCidadeCliente.Text, textBoxEstadoCliente.Text, textBoxCodProduto.Text, textBoxCorProduto.Text, textBoxDescricaoProduto.Text, textBoxUnidadeMedidaProduto.Text, textBoxValorVendaProduto.Text, textBoxQuantidadePedido.Text, textBoxValorTotalPedido.Text, textBoxFormaPgtoPedido.Text, textBoxQuantidadeParcelasPedido.Text, textBoxValorParcelaPedido.Text, maskedTextBoxVcto1ParcelaPedido.Text, textBoxObsPedido.Text);
            MessageBox.Show(cadpedido.mensagem);

            maskedTextBoxDataCadastroPedido.Text = "";
            textBoxCodCliente.Text = "";
            textBoxNomeCliente.Text = "";
            maskedTextBoxCPFCliente.Text = "";
            textBoxTelefoneCliente.Text = "";
            textBoxEmailCliente.Text = "";
            textBoxEnderecoCliente.Text = "";
            maskedTextBoxCepCliente.Text = "";
            textBoxNumeroEndCliente.Text = "";
            textBoxBairroCliente.Text = "";
            textBoxCidadeCliente.Text = "";
            textBoxEstadoCliente.Text = "";
            textBoxCodProduto.Text = "";
            textBoxCorProduto.Text = "";
            textBoxDescricaoProduto.Text = "";
            textBoxUnidadeMedidaProduto.Text = "";
            textBoxValorVendaProduto.Text = "";
            //textBoxQuantidadePedido.Text = "";
            textBoxValorTotalPedido.Text = "";
            textBoxFormaPgtoPedido.Text = "";
            //textBoxQuantidadeParcelasPedido.Text = "";
            textBoxValorParcelaPedido.Text = "";
            maskedTextBoxVcto1ParcelaPedido.Text = "";
            textBoxObsPedido.Text = "";
            maskedTextBoxDataCadastroPedido.Focus();
        }

        private void btCarregarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection objcon = new SqlConnection(@"Data Source=DESKTOP-U86S4I8\SQLEXPRESS;Initial Catalog=PI_SeniorTech;Integrated Security=True");

                objcon.Open();

                SqlCommand objCmd = new SqlCommand("SELECT NOME_CLIENTE, CPF, TELEFONE, EMAIL, ENDERECO, CEP, NUM, BAIRRO, CIDADE, ESTADO FROM TB_CLIENTES WHERE COD_CLIENTE = @COD_CLIENTE", objcon);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@COD_CLIENTE", System.Data.SqlDbType.Int).Value = textBoxCodCliente.Text;

                //executa o comando
                objCmd.CommandType = System.Data.CommandType.Text;
                //recebe o conteudo que vem do Banco
                SqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();

                textBoxNomeCliente.Text = dr.GetString(0);
                maskedTextBoxCPFCliente.Text = dr.GetString(1);
                textBoxTelefoneCliente.Text = dr.GetString(2);
                textBoxEmailCliente.Text = dr.GetString(3);
                textBoxEnderecoCliente.Text = dr.GetString(4);
                maskedTextBoxCepCliente.Text = dr.GetString(5);
                textBoxNumeroEndCliente.Text = dr.GetString(6);
                textBoxBairroCliente.Text = dr.GetString(7);
                textBoxCidadeCliente.Text = dr.GetString(8);
                textBoxEstadoCliente.Text = dr.GetString(9);

                objcon.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro);
            }
        }

        private void btCarregarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objcon = new SqlConnection(@"Data Source=DESKTOP-U86S4I8\SQLEXPRESS;Initial Catalog=PI_SeniorTech;Integrated Security=True");

                objcon.Open();

                SqlCommand objCmd = new SqlCommand("SELECT COR, DESCR_PROD, UND, VALOR_UNT_VENDA FROM TB_PRODUTOS WHERE COD_PROD = @COD_PROD", objcon);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@COD_PROD", System.Data.SqlDbType.Int).Value = textBoxCodProduto.Text;

                //executa o comando
                objCmd.CommandType = System.Data.CommandType.Text;
                //recebe o conteudo que vem do Banco
                SqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();

                textBoxCorProduto.Text = dr.GetString(0);
                textBoxDescricaoProduto.Text = dr.GetString(1);
                textBoxUnidadeMedidaProduto.Text = dr.GetString(2);
                textBoxValorVendaProduto.Text = dr.GetString(3);

                objcon.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro);
            }

        }

        private void textBoxQuantidadePedido_TextChanged(object sender, EventArgs e)
        {

            double valorunit = Convert.ToDouble(textBoxValorVendaProduto.Text);
            double qtdd = Convert.ToDouble(textBoxQuantidadePedido.Text);
            double valortotal = valorunit * qtdd;
            textBoxValorTotalPedido.Text = valortotal.ToString();

        }

        private void textBoxQuantidadeParcelasPedido_TextChanged(object sender, EventArgs e)
        {
            double valortotal = Convert.ToDouble(textBoxValorTotalPedido.Text);
            double qtdd_parcelas = Convert.ToDouble(textBoxQuantidadeParcelasPedido.Text);
            double valor_parcela = valortotal / qtdd_parcelas;

            if (qtdd_parcelas > 0)
            {
                textBoxValorParcelaPedido.Text = valor_parcela.ToString();
            }
            else
            {
                textBoxValorParcelaPedido.Text = null;
            }



        }

        private void btEditarPedido_Click(object sender, EventArgs e)
        {
            ConsultaPedido cs = new ConsultaPedido();
            cs.Show();
        }
    }
}

using System;
using System.Windows.Forms;

namespace PI_SeniorTech
{
    public partial class PRODUTOS : Form
    {
        public PRODUTOS()
        {
            InitializeComponent();
        }

        private void btCancelarProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PRODUTOS_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadproduto = new CadastrarProduto(textBoxDescricaoProduto.Text, textBoxMarcaProduto.Text, textBoxModeloProduto.Text, textBoxUnidadeMedidaProduto.Text, textBoxCorProduto.Text, textBoxValorVendaProduto.Text);
            MessageBox.Show(cadproduto.mensagem);

            textBoxDescricaoProduto.Text = "";
            textBoxMarcaProduto.Text = "";
            textBoxModeloProduto.Text = "";
            textBoxUnidadeMedidaProduto.Text = "";
            textBoxCorProduto.Text = "";
            textBoxValorVendaProduto.Text = "";
            textBoxDescricaoProduto.Focus();

        }

        private void btEditarProduto_Click(object sender, EventArgs e)
        {
            ConsultaProduto cs = new ConsultaProduto();
            cs.Show();
        }
    }
}

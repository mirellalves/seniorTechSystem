using PI_SeniorTech.Relatórios;
using System;
using System.Windows.Forms;

namespace PI_SeniorTech
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            CLIENTES cad = new CLIENTES();
            cad.Show();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            PRODUTOS cad = new PRODUTOS();
            cad.Show();
        }

        private void btPedidos_Click(object sender, EventArgs e)
        {
            PEDIDOS cad = new PEDIDOS();
            cad.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRelatorioProdutos_Click(object sender, EventArgs e)
        {
            //Abre o relatório de Produtos
            relprod relatorio = new relprod();
            relatorio.Show();
        }

        private void btRelatorioClientes_Click(object sender, EventArgs e)
        {
            //Abre o relatório de Clientes
            relcli relatorio = new relcli();
            relatorio.Show();
        }

        private void btRelatorioPedidos_Click(object sender, EventArgs e)
        {
            //Abre o relatório de Pedidos de Vendas
            relped relatorio = new relped();
            relatorio.Show();
        }
    }
}


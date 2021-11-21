using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_SeniorTech
{
    public partial class ConsultaProduto : Form
    {
        public ConsultaProduto()
        {
            InitializeComponent();
        }

        private void ConsultaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pI_SeniorTechDataSet.TB_PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PRODUTOSTableAdapter.Fill(this.pI_SeniorTechDataSet.TB_PRODUTOS);

        }

        private void btSalvarCliente_Click(object sender, EventArgs e)
        {
            ConsultarProduto consultcliente = new ConsultarProduto(textBoxDescricaoProduto.Text, textBoxMarcaProduto.Text, textBoxModeloProduto.Text, textBoxUnidadeMedidaProduto.Text, textBoxCorProduto.Text, textBoxValorVendaProduto.Text, labelCodigoProduto.Text);
            MessageBox.Show(consultcliente.mensagem);
        }

        private void btFecharConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

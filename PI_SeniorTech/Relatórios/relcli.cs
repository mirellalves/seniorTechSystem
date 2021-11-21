using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_SeniorTech.Relatórios
{
    public partial class relcli : Form
    {
        public relcli()
        {
            InitializeComponent();
        }

        private void relcli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pI_SeniorTechDataSet.TB_CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_CLIENTESTableAdapter.Fill(this.pI_SeniorTechDataSet.TB_CLIENTES);
            // TODO: esta linha de código carrega dados na tabela 'pI_SeniorTechDataSet.TB_PEDIDOS'. Você pode movê-la ou removê-la conforme necessário.
            //this.tB_PEDIDOSTableAdapter.Fill(this.pI_SeniorTechDataSet.TB_PEDIDOS);
            // TODO: esta linha de código carrega dados na tabela 'pI_SeniorTechDataSet.TB_CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_CLIENTESTableAdapter.Fill(this.pI_SeniorTechDataSet.TB_CLIENTES);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }      

        
    }
}

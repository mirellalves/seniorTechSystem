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
    public partial class relped : Form
    {
        public relped()
        {
            InitializeComponent();
        }

        private void relped_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pI_SeniorTechDataSet.TB_PEDIDOS'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PEDIDOSTableAdapter.Fill(this.pI_SeniorTechDataSet.TB_PEDIDOS);

            this.reportViewer1.RefreshReport();
        }
    }
}

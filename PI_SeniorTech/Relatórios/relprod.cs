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
    public partial class relprod : Form
    {
        public relprod()
        {
            InitializeComponent();
        }

        private void Relatório_Produto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pI_SeniorTechDataSet.TB_PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PRODUTOSTableAdapter.Fill(this.pI_SeniorTechDataSet.TB_PRODUTOS);

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Windows.Forms;

namespace PI_SeniorTech
{
    public partial class LOGIN_CADASTRAR : Form
    {
        public LOGIN_CADASTRAR()
        {
            InitializeComponent();
        }

        private void btCadastrarNoCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(textBoxUsuarioCadastrar.Text, textBoxSenhaCadastrar.Text, textBoxConfirmarSenha.Text);
            if (controle.tem) //mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(controle.mensagem);  //mensagem de erro
                textBoxSenhaCadastrar.Text = "";
                textBoxConfirmarSenha.Text = "";
                textBoxSenhaCadastrar.Focus();



            }

        }
    }
}

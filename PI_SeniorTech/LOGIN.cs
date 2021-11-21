using System;
using System.Windows.Forms;

namespace PI_SeniorTech
{
    public partial class LOGIN : Form
    {
        public LOGIN() 
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            LOGIN_CADASTRAR cad = new LOGIN_CADASTRAR();
            cad.Show();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(textBoxUSUARIO.Text, textBoxSENHA.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MENU menu = new MENU();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Login não realizado, verifique Usuário e Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUSUARIO.Text = "";
                    textBoxSENHA.Text = "";
                    textBoxUSUARIO.Focus();

                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        
        }
        }
    }

using System;

namespace PI_SeniorTech
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;

        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);
            if (loginDao.tem)  //a mensagem que vai vir eh de sucesso
            {
                this.tem = true;

            }



            return mensagem;

        }

    }
}

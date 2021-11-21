using System;
using System.Data.SqlClient;

namespace PI_SeniorTech
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            //comando SQL para verificar se tem o login no banco
            cmd.CommandText = "select * from TB_LOGIN where COD_LOGIN = @login and SENHA = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)  //se foi encontrado 
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException erro)
            {
                this.mensagem = "Erro com Banco de Dados: " + erro;
            }
            return tem;

        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            //vai pegar o usuario e senha e vai cadastrar no banco
            tem = false;
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into TB_LOGIN values (@e, @s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com Sucesso!";
                    tem = true;
                }
                catch (SqlException erro)
                {
                    this.mensagem = "Erro com Banco de Dados: " + erro;
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }

    }
}

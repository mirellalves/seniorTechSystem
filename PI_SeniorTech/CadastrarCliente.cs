using System;
using System.Data.SqlClient;

namespace PI_SeniorTech
{
    public class CadastrarCliente
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public CadastrarCliente(String DT_CADASTRO, String NOME_CLIENTE, String DT_NASC, String CPF, String GENERO, String TELEFONE, String EMAIL, String CEP, String ESTADO, String ENDERECO, String NUM, String BAIRRO, String CIDADE)
        {
            //1. Comando SQL - insert, update, delete ---- SQL Command
            cmd.CommandText = "INSERT INTO TB_CLIENTES (DT_CADASTRO, NOME_CLIENTE, DT_NASC, CPF, GENERO, TELEFONE, EMAIL, CEP, ESTADO, ENDERECO, NUM, BAIRRO, CIDADE) VALUES (@DT_CADASTRO, @NOME_CLIENTE, @DT_NASC, @CPF, @GENERO, @TELEFONE, @EMAIL, @CEP, @ESTADO, @ENDERECO, @NUM, @BAIRRO, @CIDADE)";

            //Parametros
            cmd.Parameters.AddWithValue("@DT_CADASTRO", DT_CADASTRO);
            cmd.Parameters.AddWithValue("@NOME_CLIENTE", NOME_CLIENTE);
            cmd.Parameters.AddWithValue("@DT_NASC", DT_NASC);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@GENERO", GENERO);
            cmd.Parameters.AddWithValue("@TELEFONE", TELEFONE);
            cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
            cmd.Parameters.AddWithValue("@CEP", CEP);
            cmd.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmd.Parameters.AddWithValue("@ENDERECO", ENDERECO);
            cmd.Parameters.AddWithValue("@NUM", NUM);
            cmd.Parameters.AddWithValue("@BAIRRO", BAIRRO);
            cmd.Parameters.AddWithValue("@CIDADE", CIDADE);

            //Conectar com o Banco de Dados  ----Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Desconectar com o Banco de Dados
                conexao.desconectar();

                //Mostrar mensagem de erro ou sucesso  ---variavel
                this.mensagem = "Cliente Cadastrado com Sucesso!!";


            }
            catch (SqlException e)
            {
                this.mensagem = "Erro: " + e;
            }
        }
    }
}

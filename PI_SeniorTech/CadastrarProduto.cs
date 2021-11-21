using System;
using System.Data.SqlClient;

namespace PI_SeniorTech
{
    public class CadastrarProduto
    {


        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";


        public CadastrarProduto(String DESCR_PROD, String MARCA, String MODELO, String UND, String COR, String VALOR_UNT_VENDA)
        {
            //1. Comando SQL - insert, update, delete ---- SQL Command
            cmd.CommandText = "INSERT INTO TB_PRODUTOS (DESCR_PROD, MARCA, MODELO, UND, COR, VALOR_UNT_VENDA) VALUES (@DESCR_PROD, @MARCA, @MODELO, @UND, @COR, @VALOR_UNT_VENDA)";

            //Parametros
            cmd.Parameters.AddWithValue("@DESCR_PROD", DESCR_PROD);
            cmd.Parameters.AddWithValue("@MARCA", MARCA);
            cmd.Parameters.AddWithValue("@MODELO", MODELO);
            cmd.Parameters.AddWithValue("@UND", UND);
            cmd.Parameters.AddWithValue("@COR", COR);
            cmd.Parameters.AddWithValue("@VALOR_UNT_VENDA", VALOR_UNT_VENDA);

            //Conectar com o Banco de Dados  ----Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Desconectar com o Banco de Dados
                conexao.desconectar();

                //Mostrar mensagem de erro ou sucesso  ---variavel
                this.mensagem = "Produto Cadastrado com Sucesso!!";




            }
            catch (SqlException e)
            {

                this.mensagem = "Erro: " + e;
            }
        }
    }
}

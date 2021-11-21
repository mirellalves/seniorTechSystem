using System;
using System.Data.SqlClient;

namespace PI_SeniorTech
{
    public class ConsultarProduto
    {


        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";


        public ConsultarProduto(String DESCR_PROD, String MARCA, String MODELO, String UND, String COR, String VALOR_UNT_VENDA, String COD_PROD)
        {
            //1. Comando SQL - insert, update, delete ---- SQL Command
            cmd.CommandText = "UPDATE TB_PRODUTOS SET DESCR_PROD = @DESCR_PROD, MARCA = @MARCA, MODELO = @MODELO, UND = @UND, COR = @COR, VALOR_UNT_VENDA = @VALOR_UNT_VENDA WHERE COD_PROD = @COD_PROD";

            //Parametros
            cmd.Parameters.AddWithValue("@DESCR_PROD", DESCR_PROD);
            cmd.Parameters.AddWithValue("@MARCA", MARCA);
            cmd.Parameters.AddWithValue("@MODELO", MODELO);
            cmd.Parameters.AddWithValue("@UND", UND);
            cmd.Parameters.AddWithValue("@COR", COR);
            cmd.Parameters.AddWithValue("@VALOR_UNT_VENDA", VALOR_UNT_VENDA);
            cmd.Parameters.AddWithValue("@COD_PROD", COD_PROD);

            //Conectar com o Banco de Dados  ----Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Desconectar com o Banco de Dados
                conexao.desconectar();

                //Mostrar mensagem de erro ou sucesso  ---variavel
                this.mensagem = "Produto Alterado com Sucesso!!";




            }
            catch (SqlException e)
            {

                this.mensagem = "Erro: " + e;
            }
        }
    }
}

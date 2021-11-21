using System;
using System.Data.SqlClient;

namespace PI_SeniorTech
{
    public class ExcluirPedido
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public ExcluirPedido(String NUMERO_PED)
        {
            //1. Comando SQL - insert, update, delete ---- SQL Command
            cmd.CommandText = "DELETE FROM TB_PEDIDOS WHERE NUMERO_PED = @NUMERO_PED";

            //Parametros            
            cmd.Parameters.AddWithValue("@NUMERO_PED", NUMERO_PED);


            //Conectar com o Banco de Dados  ----Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Desconectar com o Banco de Dados
                conexao.desconectar();

                //Mostrar mensagem de erro ou sucesso  ---variavel
                this.mensagem = "Pedido EXCLUÍDO com Sucesso!!";


            }
            catch (SqlException e)
            {

                this.mensagem = "Erro: " + e;
            }







        }


    }
}

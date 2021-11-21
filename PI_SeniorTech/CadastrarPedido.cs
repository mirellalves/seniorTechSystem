﻿using System;
using System.Data.SqlClient;

namespace PI_SeniorTech
{
    public class CadastrarPedido
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public CadastrarPedido(String DT_PEDIDO, String COD_CLIENTE, String NOME_CLIENTE, String CPF, String TELEFONE, String EMAIL, String ENDERECO, String CEP, String NUM, String BAIRRO, String CIDADE, String ESTADO, String COD_PROD, String COR, String DESCR_PROD, String UND, String VALOR_UNT_VENDA, String QTDE, String VALOR_TOTAL, String FORMA_PAGTO, String QTDD_PARCELAS, String VALOR_PARCELA, String VCTO_1PARC, String OBS)
        {
            //1. Comando SQL - insert, update, delete ---- SQL Command
            cmd.CommandText = "INSERT INTO TB_PEDIDOS (DT_PEDIDO, COD_CLIENTE, NOME_CLIENTE, CPF, TELEFONE, EMAIL, ENDERECO, CEP, NUM, BAIRRO, CIDADE, ESTADO, COD_PROD, COR, DESCR_PROD, UND, VALOR_UNT_VENDA, QTDE, VALOR_TOTAL, FORMA_PAGTO, QTDD_PARCELAS, VALOR_PARCELA, VCTO_1PARC, OBS) VALUES (@DT_PEDIDO, @COD_CLIENTE, @NOME_CLIENTE, @CPF, @TELEFONE, @EMAIL, @ENDERECO, @CEP, @NUM, @BAIRRO, @CIDADE, @ESTADO, @COD_PROD, @COR, @DESCR_PROD, @UND, @VALOR_UNT_VENDA, @QTDE, @VALOR_TOTAL, @FORMA_PAGTO, @QTDD_PARCELAS, @VALOR_PARCELA, @VCTO_1PARC, @OBS)";

            //Parametros
            cmd.Parameters.AddWithValue("@DT_PEDIDO", DT_PEDIDO);
            cmd.Parameters.AddWithValue("@COD_CLIENTE", COD_CLIENTE);
            cmd.Parameters.AddWithValue("@NOME_CLIENTE", NOME_CLIENTE);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@TELEFONE", TELEFONE);
            cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
            cmd.Parameters.AddWithValue("@ENDERECO", ENDERECO);
            cmd.Parameters.AddWithValue("@CEP", CEP);
            cmd.Parameters.AddWithValue("@NUM", NUM);
            cmd.Parameters.AddWithValue("@BAIRRO", BAIRRO);
            cmd.Parameters.AddWithValue("@CIDADE", CIDADE);
            cmd.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmd.Parameters.AddWithValue("@COD_PROD", COD_PROD);
            cmd.Parameters.AddWithValue("@COR", COR);
            cmd.Parameters.AddWithValue("@DESCR_PROD", DESCR_PROD);
            cmd.Parameters.AddWithValue("@UND", UND);
            cmd.Parameters.AddWithValue("@VALOR_UNT_VENDA", VALOR_UNT_VENDA);
            cmd.Parameters.AddWithValue("@QTDE", QTDE);
            cmd.Parameters.AddWithValue("@VALOR_TOTAL", VALOR_TOTAL);
            cmd.Parameters.AddWithValue("@FORMA_PAGTO", FORMA_PAGTO);
            cmd.Parameters.AddWithValue("@QTDD_PARCELAS", QTDD_PARCELAS);
            cmd.Parameters.AddWithValue("@VALOR_PARCELA", VALOR_PARCELA);
            cmd.Parameters.AddWithValue("@VCTO_1PARC", VCTO_1PARC);
            cmd.Parameters.AddWithValue("@OBS", OBS);



            //Conectar com o Banco de Dados  ----Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Desconectar com o Banco de Dados
                conexao.desconectar();

                //Mostrar mensagem de erro ou sucesso  ---variavel
                this.mensagem = "Pedido Cadastrado com Sucesso!!";


            }
            catch (SqlException e)
            {

                this.mensagem = "Erro: " + e;
            }







        }


    }
}

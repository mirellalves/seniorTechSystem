using System.Data.SqlClient;

namespace PI_SeniorTech
{
    public class Conexao
    {

        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-U86S4I8\SQLEXPRESS;Initial Catalog=PI_SeniorTech;Integrated Security=True";

        }

        //metodo Conectar
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();

            }
            return con;
        }

        //Metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();

            }


        }



    }
}

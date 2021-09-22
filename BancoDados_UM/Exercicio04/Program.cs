using System;
using System.Data.SqlClient;

namespace Exercicio04
{
    class Program
    {
        public static object SqlConnection { get; private set; }
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            SqlCommand cmd;

            //exercicio 04

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira o {0}° e-mail", i + 1);
                string email = Console.ReadLine();
                string insert = $"INSERT into dbo.Email (endereco) values ('{email}')";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            //se quiser procurar por algo, pedir ao usuario, depois ler em uma variavel x, depois escrever:
            //string select = "SELECT * from dbo.Email WHERE endereco LIKE '%{x}%'";
            //string select = "SELECT * from dbo.Email WHERE endereco LIKE '%@outlook.com%' OR endereco LIKE '%@outlook.com.br%'";
            string select = "SELECT * from dbo.Email WHERE endereco LIKE '%@outlook.com%'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["idEmail"]);
                Console.WriteLine(dr[1]);
                Console.WriteLine("\n");
            }
            dr.Close();
            conn.Close();
        }
    }
}

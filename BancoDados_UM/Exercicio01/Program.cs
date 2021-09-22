using System;
using System.Data.SqlClient;

namespace Exercicio01
{
    class Program
    {
        public static object SqlConnection { get; private set; }
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            SqlCommand cmd;

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    Console.WriteLine("Insira o nome do {0}° Cliente", i + 1);
                    string nome = Console.ReadLine();
                    string cpf = Console.ReadLine();
                    int idade = int.Parse(Console.ReadLine());
                    string insert = $"INSERT into dbo.Cliente (Nome, Cpf, Idade) values ('{nome}', '{cpf}', {idade})";
                    cmd = new SqlCommand(insert, conn);
                    //cmd = new SqlCommand($"INSERT into dbo.Cliente (Nome, Cpf, Idade) values ('{nome}', '{cpf}', {idade})", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }

            //update
            string update = "UPDATE dbo.Cliente set Nome = 'Latino', Idade = 49 WHERE idCliente = 3";
            cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            //delete
            string delete = "DELETE from dbo.Cliente WHERE idCliente = 4";
            cmd = new SqlCommand(delete, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            //select
            string select = "SELECT * from dbo.Cliente";
            SqlDataReader dr;
            cmd = new SqlCommand(select, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["idCliente"]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr["Idade"]);
                Console.WriteLine("----------------------------");
            }
            dr.Close();
            conn.Close();


        }
    }
}

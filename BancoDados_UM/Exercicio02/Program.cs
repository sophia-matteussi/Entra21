using System;
using System.Data.SqlClient;

namespace Exercicio02
{
    class Program
    {
        public static object SqlConnection { get; private set; }
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            SqlCommand cmd;

            // exercicio 02

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.WriteLine("Insira o nome do {0}° Cachorro", i + 1);
                    string nome = Console.ReadLine();
                    string nomeDoDono = Console.ReadLine();
                    int telefone = int.Parse(Console.ReadLine());
                    string insert = $"INSERT into dbo.PetShop (Nome, NomeDoDono, TelefoneDono) values ('{nome}', '{nomeDoDono}', {telefone})";
                    cmd = new SqlCommand(insert, conn);
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
            //select
            string select = "SELECT * from dbo.PetShop";
            SqlDataReader dr;
            cmd = new SqlCommand(select, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["idPetShop"]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
                Console.WriteLine("----------------------------");
            }
            dr.Close();
            conn.Close();
        }
    }
}

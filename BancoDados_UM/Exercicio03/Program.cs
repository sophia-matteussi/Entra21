using System;
using System.Data.SqlClient;

namespace Exercicio03
{
    class Program
    {
        public static object SqlConnection { get; private set; }       
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            SqlCommand cmd;

            //exercicio 03

            while (true)
            {
                Console.WriteLine("Insira um funcionario ou S para sair");
                string nome = Console.ReadLine();
                if (nome.ToLower() == "s")
                {
                    break;
                }
                string cargo = Console.ReadLine();
                int salario = int.Parse(Console.ReadLine());
                string insert = $"INSERT into dbo.Funcionarios (Nome, Cargo, Salario) values ('{nome}', '{cargo}', {salario})";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            string select = "SELECT * from dbo.Funcionarios WHERE Salario > 3000";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["idFuncionario"]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
                Console.WriteLine("\n");
            }
            dr.Close();
            conn.Close();
        }
    }
}

﻿using System;
using System.Data.SqlClient;

namespace Exercicio06
{
    class Program
    {
        public static object SqlConnection { get; private set; }
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            SqlCommand cmd;

            //exercicio 06

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira o {0}° e-mail", i + 1);
                string email = Console.ReadLine();
                string insert = $"INSERT into dbo.Email (endereco) values ('{email}')";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            string delete = "DELETE from dbo.Email WHERE NOT (endereco LIKE '%@outlook.com%' OR endereco LIKE '%@outlook.com.br%')";
            cmd = new SqlCommand(delete, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

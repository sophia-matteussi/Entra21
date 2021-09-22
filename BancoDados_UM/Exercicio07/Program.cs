using System;
using System.Data.SqlClient;

namespace Exercicio07
{
    class Program
    {
        public static object SqlConnection { get; private set; }
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            SqlCommand cmd;

            //EXERCICIO 07

            // 7) Baseado no Banco De Dados do Exercício 5, TODOS os Funcionários ganharam um aumento de 25.93 %,
            // caso após o aumento algum funcionário possua mais que 5000 reduza o salário em 5,76 %

            string update = "UPDATE dbo.Funcionarios set Salario = Salario + (Salario * 0.2593)";
            cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            update = "UPDATE dbo.Funcionarios set Salario = Salario - (Salario * 0.0576) WHERE Salario > 5000";
            cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

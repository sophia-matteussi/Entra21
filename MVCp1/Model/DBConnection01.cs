using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCp1.Model
{
    class DBConnection01
    {
        private static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");     

        public static int ContaExistente(string conta)
        {
            int idConta = -1;
            string select = $"SELECT idConta from dbo.Conta WHERE NumeroConta = '{conta}'";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                idConta = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            return idConta;                     
        }

        public static bool AtualizaSaque(int valor, int idConta) //era void
        {
            int saldo = 0;
            string select = $"SELECT Saldo from dbo.Conta WHERE idConta = {idConta}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                saldo = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            if (saldo >= valor)
            {
                string update = $"UPDATE dbo.Conta set Saldo -= {valor} WHERE idConta = {idConta}";
                SqlCommand cmmd = new SqlCommand(update, Connection);
                Connection.Open();
                cmmd.ExecuteNonQuery();
                Connection.Close();
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void AtualizaDeposito(int valor, int idConta)
        {
            string update = $"UPDATE dbo.Conta set Saldo += {valor} WHERE idConta = {idConta}";
            SqlCommand cmd = new SqlCommand(update, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

    }
}

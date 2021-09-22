using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCp1.Model
{
    class DBConnection
    {
        private static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        
        public static List<string[]> AtualizaDG()
        {
            List<string[]> lista = new List<string[]>();
            string select = "SELECT * from dbo.Estacionamento";
            SqlCommand cmd = new SqlCommand(select, Connection );
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString() };
                lista.Add(vetor);

            }
            dr.Close();
            Connection.Close();
            return lista;
        }
        public static List<string> AtualizaCBPlaca()
        {
            List<string> lista = new List<string>();
            string select = "SELECT Placa from dbo.Estacionamento WHERE Placa is not null";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();
            return lista;
        }

        public static double AtualizaVaga(string placa)
        {
            double hora = -1;
            string select = $"SELECT HoraEntrada from dbo.Estacionamento WHERE Placa = '{placa}'";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                hora = Convert.ToDouble(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();
            if (hora != -1)
            {
                string update = $"UPDATE dbo.Estacionamento set Placa = null, HoraEntrada = 0 WHERE Placa = '{placa}'";
                Execute(update);
            }
            return hora;

        }

        private static void Execute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        /// <summary>
        /// Select all values from column from given table, table already includes dbo.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="table"></param>
        /// <returns></returns>

        public static List<string> GenericSelectUnit(string column, string table)
        {
            List<string> lista = new List<string>();
            string select = $"SELECT {column} from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();
            return lista;
        }
        public static List<string> GenericSelectUnit(string column, string table, string where)
        {
            List<string> lista = new List<string>();
            string select = $"SELECT {column} from dbo.{table} WHERE {where}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();
            return lista;
        }
        
        public static bool Entrar(string placa, string horario, string vaga)
        {
            CultureInfo temp = new CultureInfo("en-US");
            string update = $"UPDATE dbo.Estacionamento Set Placa = '{placa}',HoraEntrada = {Convert.ToDouble(horario).ToString(CultureInfo.InvariantCulture)} WHERE idVaga = {vaga}";
            Execute(update);
            return true;
        }

    }
}

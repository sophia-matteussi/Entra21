using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCp1.Model
{
    public static class ModelTabela
    {
        private static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        private static SqlCommand cmd { get; set; } = new SqlCommand("", Connection);

        public static bool AdicionaPessoa(string nome, string cpf, string rg)
        {
            //1° Passo = inserir na tabela primaria os valores referentes
            string insert = $"INSERT into dbo.Dados(Nome,Cpf,Rg) values ('{nome}', '{cpf}', '{rg}')";
            cmd.CommandText = insert;
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();

            //2° Passo = selecionar o Id do elemento recem inserido
            int idDados = 0;
            string select = "SELECT Top 1 idDados from dbo.Dados Order by idDados desc";
            cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                idDados = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            //3° Passo = inserir id selecionado mais o restante dos dados
            insert = $"INSERT into dbo.Pessoa (idDados) values ({idDados})";
            cmd.CommandText = insert;
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
            return true;

        }

        public static List<string[]> SelecionaPessoa()
        {
            List<string[]> lista = new List<string[]>();
            List<int> ids = new List<int>();

            //1° Passo = selecionar os Ids necessarios para o select da tabela primaria
            string select = "SELECT idDados from dbo.Pessoa";
            cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ids.Add(Convert.ToInt32(dr[0]));
            }
            dr.Close();
            Connection.Close();

            //2° Passo = selecionar os dados usando os ids como ref
            foreach (var item in ids)
            {
                select = $"SELECT * from dbo.Dados WHERE idDados = {item}";
                cmd.CommandText = select;
                Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string[] vetor = new string[dr.FieldCount];
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        vetor[i] = dr[i].ToString();

                    }
                    lista.Add(vetor);

                }
                dr.Close();
                Connection.Close();

            }
            return lista;

        }

        public static bool AdicionaFuncionario(string nome, string cpf, string rg, string salario)
        {
            //1° Passo = inserir na tabela primaria os valores referentes
            string insert = $"INSERT into dbo.Dados(Nome,Cpf,Rg) values ('{nome}', '{cpf}', '{rg}')";
            cmd.CommandText = insert;
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();

            //2° Passo = selecionar o Id do elemento recem inserido
            int idDados = 0;
            string select = "SELECT Top 1 idDados from dbo.Dados Order by idDados desc";
            cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                idDados = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            //3° Passo = Insere os demais valores na tabela 
            insert = $"INSERT into dbo.Funcionario (Salario, idDados) values ({Convert.ToDouble(salario).ToString(CultureInfo.InvariantCulture)}, {idDados})";
            cmd.CommandText = insert;
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();

            return true;
        }

        public static List<string[]> SelecionaFuncionarios()
        {
            List<string[]> lista = new List<string[]>();
            List<string[]> idSalarios = new List<string[]>();

            //1° Passo = select da tabela final para saber a fk
            string select = "SELECT * from dbo.Funcionario";
            cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = new string[2];
                vetor[0] = dr[1].ToString();
                vetor[1] = dr[2].ToString();
                idSalarios.Add(vetor);

            }
            dr.Close();
            Connection.Close();

            //2° passo =  seleciona da tabela inicial usando a chave
            foreach (var item in idSalarios)
            {
                select = $"SELECT * from dbo.Dados WHERE idDados = {item[1]}";
                cmd.CommandText = select;
                Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string[] vetor = new string[dr.FieldCount + 1];
                    for (int i = 0; i < vetor.Length -1; i++)
                    {
                        vetor[i] = dr[i].ToString();
                    }
                    vetor[vetor.Length - 1] = item[0];
                    lista.Add(vetor);
                }
                dr.Close();
                Connection.Close();

            }
            return lista;
        }

        public static bool AdicionaCliente(string nome, string cpf, string rg, int vip)
        {
            //1° Passo = inserir na tabela primaria os valores referentes
            string insert = $"INSERT into dbo.Dados(Nome,Cpf,Rg) values ('{nome}', '{cpf}', '{rg}')";
            cmd.CommandText = insert;
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();

            //2° Passo = selecionar o Id do elemento recem inserido
            int idDados = 0;
            string select = "SELECT Top 1 idDados from dbo.Dados Order by idDados desc";
            cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                idDados = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            //3° Passo = Insere os demais valores na tabela 
            insert = $"INSERT into dbo.Cliente (Vip, idDados) values ({vip}, {idDados})";
            cmd.CommandText = insert;
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();

            return true;
        }

        public static List<string[]> SelecionaCliente()
        {
            List<string[]> lista1 = new List<string[]>();
            List<string[]> lista = new List<string[]>();


            //1° Passo = selecionar os Ids necessarios para o select da tabela primaria
            string select = "SELECT * from dbo.Cliente";
            cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = new string[2];                
                vetor[0] = dr[1].ToString();
                vetor[1] = dr[2].ToString();
                lista1.Add(vetor);
            }
            dr.Close();
            Connection.Close();

            //2° passo =  seleciona da tabela inicial usando a chave
            foreach (var item in lista1)
            {
                select = $"SELECT * from dbo.Dados WHERE idDados = {item[1]}";
                cmd.CommandText = select;
                Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string[] vetor = new string[dr.FieldCount + 1];
                    for (int i = 0; i < vetor.Length - 1; i++)
                    {
                        vetor[i] = dr[i].ToString();
                    }
                    vetor[vetor.Length - 1] = item[0];
                    lista.Add(vetor);
                }
                dr.Close();
                Connection.Close();

            }
            return lista;

        }

    }
}

using System;
using System.Data.SqlClient;

namespace BancoDados_UM
{
    class Program
    {
        public static object SqlConnection { get; private set; }

        static void Main(string[] args)
        {           
            SqlConnection conn = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            SqlCommand cmd;

            //lista 02

            bool executa = true;

            while (executa)
            {
                Console.WriteLine("     MENU\n    ");
                Console.WriteLine(" 1 - Adicionar");
                Console.WriteLine(" 2 - Remover");
                Console.WriteLine(" 3 - Atualizar");
                Console.WriteLine(" 4 - Visualizar");
                Console.WriteLine(" 5 - Encerrar");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Nome:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Preço: ");
                        int preco = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade no estoque: ");
                        int estoque = int.Parse(Console.ReadLine());
                        string insert = $"INSERT into dbo.Produto (Nome, Preco, QtdEstoque) values ('{nome}', {preco}, {estoque}) "; //aspas é para varchar, char, nvarchar
                        cmd = new SqlCommand(insert, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        break;
                    case 2:
                        MostraEstoque(conn);
                        Console.WriteLine("\nQual produto vc deseja remover? \n*ESTA AÇÃO NAO PODE SER DESFEITA*");
                        string produto = Console.ReadLine();
                        string delete = $"DELETE from dbo.Produto WHERE Nome = '{produto}' or idProduto {produto}";
                        cmd = new SqlCommand(delete, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        break;
                    case 3:
                        MostraEstoque(conn);
                        Console.WriteLine("\nQual produto deseja atualizar?");
                        produto = Console.ReadLine();
                        Console.WriteLine("Nome");
                        nome = Console.ReadLine();
                        Console.WriteLine("Preço");
                        preco = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade em estoque?");
                        estoque = Convert.ToInt32(Console.ReadLine());
                        string update = $"UPDATE dbo.Produto set Nome = '{nome}', Preco = '{preco}', QtdEstoque = '{estoque}' WHERE  Nome = '{produto}' or  idProduto = '{produto}' ";
                        cmd = new SqlCommand(update, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        //Executa(cmd, conn);
                        break;
                    case 4:
                        MostraEstoque(conn);
                        break;
                    case 5:
                        Console.WriteLine("Obrigada por usar!");
                        executa = false;
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVALIDA!");
                        break;
                }


            }

            //letra b

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Para encerrar a compra, digite -1");
                MostraProdutos(conn);
                Console.WriteLine("\nQual produto deseja comprar?");
                string produto = Console.ReadLine();
                if (produto == "-1")
                {
                    Console.WriteLine("Sua compra finalizou em: ");
                    continuar = false;
                }
                string update = $"UPDATE dbo.Produto set QtdEstoque = QtdEstoque - 1 WHERE  Nome = '{produto}' or  idProduto = '{produto}' ";
                cmd = new SqlCommand(update, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                string preco = $"SELECT Preco from dbo.Produto WHERE Nome = '{produto}' or  idProduto = '{produto}'";
                int valor = Convert.ToInt32(preco);
                valor = TotalCompra(valor);
            }
            

        }
        public static int TotalCompra(int valor)
        {
            valor += valor;
            return valor;
        }
        public static void MostraProdutos(SqlConnection conn)
        {
            Console.Write("ID");
            Console.WriteLine("\tNome");         

            string select = "SELECT * from dbo.Produto WHERE QtdEstoque > 0";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.Write(dr[0]);
                Console.WriteLine("\t" + dr[1]);
            }
            dr.Close();
            conn.Close();
        }
        public static void Executa(SqlCommand cmd, SqlConnection conn)
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void MostraEstoque(SqlConnection conn)
        {
            Console.Write("ID");
            Console.Write("\tNome");
            Console.Write("\t\tPreço");
            Console.WriteLine("\tQuantidade no estoque");

            string select = "SELECT * from dbo.Produto";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.Write(dr[0]);
                Console.Write("\t" + dr[1]);
                Console.Write("\t" + dr[2]);
                Console.WriteLine("\t" + dr[3]);
            }
            dr.Close();
            conn.Close();
        }
    }
}

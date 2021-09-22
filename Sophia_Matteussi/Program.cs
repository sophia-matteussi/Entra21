using System;
using System.Collections.Generic;


namespace Sophia_Matteussi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] estoque1 = criarEstoque(1);
            int[][] estoque2 = criarEstoque(2);
            int[][] estoque3 = criarEstoque(3);
            int[][] estoque4 = criarEstoque(4);

            int contador;

            int quantidade;

            int qtd;

            List<string> entradaStrings = new List<string>(); //Lista que recebe a lista de produtos em int;    

            List<int> entrada = new List<int>(); //Lista que recebe a lista de produtos em int;

            string ordemDeServico = " "; //Recebe as ordens de serviço (entregas)

            List<int> entrega = new List<int>();

            //Percorre os dias;
            for (int dia = 1; dia < 7; dia++)
            {
                Console.WriteLine("DIA " + dia);

                Console.WriteLine("Para seguir para a próxima etapa das rotinas do dia, clique em ENTER.");

                Console.ReadLine(); //Esse input será apenas para o enter do usuário;  

                qtd = Geradores.Qtd(); //Gera e armazena a quantidade de entradas do dia;

                Console.WriteLine("Hoje irá chegar " + qtd + " carga(s).");

                Console.ReadLine();

                //Recebe carga e organiza no estoque;
                for (int i = 0; i < qtd; i++)
                {
                    entrada.Clear(); //Limpa/Remove os itens da lista;

                    entradaStrings = Geradores.GeraEntrada(); //Gera e armazena a entrada dos produtos;

                    //Mostra na tela;
                    foreach (var item in entradaStrings)
                    {
                        Console.Write(item + "  ");
                    }
                    Console.WriteLine();

                    //Converte cada elemento da lista entrada (string) para int, armazenando os elementos em entrada;           
                    for (int j = 0; j < entradaStrings.Count; j++)
                    {
                        entrada.Add(Convert.ToInt32(entradaStrings[j]));
                    }

                    //Irá chamar as funções para Contar quantos produtos há na entrada e, após, para adicionar os produtos aos seus respectivos estoques;
                    quantidade = ContarProduto(1, entrada);
                    estoque1 = AdicionarAoEstoque(estoque1, quantidade, 1);

                    quantidade = ContarProduto(2, entrada);
                    estoque2 = AdicionarAoEstoque(estoque2, quantidade, 2);

                    quantidade = ContarProduto(3, entrada);
                    estoque3 = AdicionarAoEstoque(estoque3, quantidade, 3);

                    quantidade = ContarProduto(4, entrada);
                    estoque4 = AdicionarAoEstoque(estoque4, quantidade, 4);

                }
                Console.ReadLine();

                //Irá mostrar na tela cada estoque atualizado;
                Console.WriteLine("O estoque atualizado do produto 1 é: ");
                MostrarEstoque(estoque1);

                Console.WriteLine("O estoque atualizado do produto 2 é: ");
                MostrarEstoque(estoque2);

                Console.WriteLine("O estoque atualizado do produto 3 é: ");
                MostrarEstoque(estoque3);

                Console.WriteLine("O estoque atualizado do produto 4 é: ");
                MostrarEstoque(estoque4);
                Console.ReadLine();

                qtd = Geradores.Qtd();  //Gera e armazena a quantidade de saidas/entregas do dia;

                Console.WriteLine("Hoje teremos " + qtd + " entrega(s).");
                Console.ReadLine();

                //Recebe ordem de serviço e envia a carga;
                for (int i = 0; i < qtd; i++)
                {
                    entrega.Clear();    //Limpa/Remove os itens da lista;            

                    ordemDeServico = Geradores.OrdemDeServico(); //Gera ordem de serviço;

                    int[] saida = new int[ordemDeServico.Length]; //Array responsável pela saída dos produtos, será gerado de acordo com o tamanho da ordem de serviço;

                    //Converte cada elemento da variavel (string) para int, armazenando os elementos em uma lista -> entregas;           
                    for (int j = 0; j < ordemDeServico.Length; j++)
                    {
                        entrega.Add(Convert.ToInt32(Char.GetNumericValue(ordemDeServico[j])));
                    }

                    entrega.Sort(); //Organiza os elementos da lista;

                    //Mostra na tela cada entrega que deve ser feita;
                    Console.Write("Entrega: ");
                    foreach (var item in entrega)
                    {
                        Console.Write(item + "  ");
                    }
                    Console.WriteLine();

                    //Irá chamar as funções para: (1°) contar quantos produtos de cada ID existem na lista entrega; 
                    //(2°) checar a disponibilidade dos produtos no estoque;
                    //(3°) colocar os produtos disponíveis no array para entrega; 
                    //(4°) retira os produtos que foram entregues do estoque; 

                    quantidade = ContarProduto(1, entrega);
                    contador = ContaEstoque(estoque1);
                    saida = ColocarNoArray(saida, contador, quantidade, 1);
                    estoque1 = RetiraDoEstoque(estoque1, quantidade);

                    quantidade = ContarProduto(2, entrega);
                    contador = ContaEstoque(estoque2);
                    saida = ColocarNoArray(saida, contador, quantidade, 2);
                    estoque2 = RetiraDoEstoque(estoque2, quantidade);

                    quantidade = ContarProduto(3, entrega);
                    contador = ContaEstoque(estoque3);
                    saida = ColocarNoArray(saida, contador, quantidade, 3);
                    estoque3 = RetiraDoEstoque(estoque3, quantidade);

                    quantidade = ContarProduto(4, entrega);
                    contador = ContaEstoque(estoque4);
                    saida = ColocarNoArray(saida, contador, quantidade, 4);
                    estoque4 = RetiraDoEstoque(estoque4, quantidade);


                    Console.Write("De acordo com nosso estoque atual, a entrega será: ");

                    //Mostra na tela;
                    foreach (var item in saida)
                    {
                        Console.Write(item + "  ");
                    }
                    Console.WriteLine();
                    Console.WriteLine(" ");
                }
                Console.ReadLine();

                //Mostra na tela o estoque atualizado;
                Console.WriteLine("O estoque atualizado do produto 1 é: ");
                MostrarEstoque(estoque1);

                Console.WriteLine("O estoque atualizado do produto 2 é: ");
                MostrarEstoque(estoque2);

                Console.WriteLine("O estoque atualizado do produto 3 é: ");
                MostrarEstoque(estoque3);

                Console.WriteLine("O estoque atualizado do produto 4 é: ");
                MostrarEstoque(estoque4);
                Console.ReadLine();

            }

            Console.WriteLine("Obrigada por utilizar!");
        }

        public static int[][] criarEstoque(int ID) //A variável ID refere-se ao ID de cada produto da empresa;
        {
            int[][] estoque = new int[6][]; //Cria um estoque para o produto;
            for (int i = 0; i < estoque.Length; i++)
            {
                estoque[i] = new int[6];

            }
            for (int i = 0; i < estoque.Length; i++) //Preenche o primeiro estoque do produto de determinada ID;
            {
                for (int j = 0; j < estoque[i].Length; j++)
                {
                    if (i < 3)    // i < 3 faz com que apenas metade da matriz seja preenchida, como solicitado;                 
                    {
                        estoque[i][j] = ID;
                        //Console.Write(estoque[i][j] + "  ");
                    }
                    else //Preenche o restante da matriz com zeros;
                    {
                        estoque[i][j] = 0;
                        //Console.Write(estoque[i][j] + "  ");
                    }
                }
                //Console.WriteLine();
            }
            return estoque;
        }

        public static int ContarProduto(int produto, List<int> entrada) //Essa função contará quantas vezes cada produto aparece na lista de entrada/entrega;
        {
            int quantidade = 0;

            for (int i = 0; i < entrada.Count; i++)
            {
                if (entrada[i] == produto)
                {
                    quantidade++; //cada vez que o valor em questao é igual ao produto (input), incrementa.
                }
            }
            return quantidade;
        }

        public static int[][] AdicionarAoEstoque(int[][] estoque, int quantidade, int ID) //Essa função adiciona os produtos ao estoque, organiza e confere se o estoque está cheio;
        {
            for (int x = 0; x < quantidade; x++)
            {
                bool jaAdicionou = false;
                for (int i = 0; i < estoque.Length; i++)
                {
                    for (int j = 0; j < estoque[i].Length; j++)
                    {
                        if (estoque[i][j] == 0)
                        {
                            estoque[i][j] = ID;
                            jaAdicionou = true;
                            break;
                        }

                        if (estoque[5][5] != 0)
                        {
                            return estoque;
                        }
                    }
                    if (jaAdicionou == true)
                    {
                        break;
                    }
                }
            }
            return estoque;
        }

        public static void MostrarEstoque(int[][] estoque) //Mostra o estoque;
        {
            for (int i = 0; i < estoque.Length; i++)
            {
                for (int j = 0; j < estoque[i].Length; j++)
                {
                    Console.Write(estoque[i][j] + "   ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] RetiraDoEstoque(int[][] estoque, int quantidade) //Percorre o estoque e retira os produtos que serão entregues;
        {
            for (int x = 0; x < quantidade; x++)
            {
                bool jaRemoveu = false;

                for (int i = 5; i >= 0; i--)
                {
                    for (int j = 5; j >= 0; j--)
                    {
                        if (estoque[i][j] != 0)
                        {
                            estoque[i][j] = 0;
                            jaRemoveu = true;
                            break;
                        }
                    }
                    if (jaRemoveu == true)
                    {
                        break;
                    }
                }
            }
            return estoque;

        }

        public static int ContaEstoque(int[][] estoque) //Confere a disponibilidade dos produtos no estoque;
        {
            int contador = 0;
            for (int i = 0; i < estoque.Length; i++)
            {
                for (int j = 0; j < estoque[i].Length; j++)
                {
                    if (estoque[i][j] != 0)
                    {
                        contador++;
                    }

                    else
                    {
                        return contador;
                    }
                }
            }
            return contador;
        }

        public static int[] ColocarNoArray(int[] array, int contador, int quantidade, int ID) //Coloca os produtos que devem ser entregues (disponiveis) no array de saida;
        {
            if (contador >= quantidade)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        for (int j = i; j < quantidade + i; j++)
                        {
                            array[j] = ID;
                        }
                        return array;
                    }
                }

            }

            else //contador < quantidade
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        for (int j = i; j < contador + i; j++)
                        {
                            array[j] = ID;
                        }
                        return array;
                    }
                }
            }
            return array;
        }
    }
}

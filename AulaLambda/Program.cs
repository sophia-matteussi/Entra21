using System;

namespace AulaLambda
{
    class Program
    {
           
        static void Main(string[] args)
        {
            //lista 2:

            //1) Crie um gerador de notas para saque de um caixa eletrônico, o caixa deve for-necer a menor quantidade de notas posíveis,
            //além disso, caso não consiga entregar completamente o dinheiro, cancele a operação e sugira o valor válido mais próximo.
            //As notas são, R$ 100. 50. 20. 10. 5. 2
            //Use Lambda para isso.

            Func<int, CaixaEletronico> dinheiro = x =>
            {
                CaixaEletronico resultado = new CaixaEletronico();
                int temp = x;
                while (true)
                {
                    if (x >= 100)
                    {
                        x -= 100;
                        resultado.Cem++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    if (x >= 50)
                    {
                        x -= 50;
                        resultado.Cinqenta++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    if (x >= 20)
                    {
                        x -= 20;
                        resultado.Vinte++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    if (x >= 10)
                    {
                        x -= 10;
                        resultado.Dez++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    if (x >= 5)
                    {
                        x -= 5;
                        resultado.Cinco++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    if (x >= 2)
                    {
                        x -= 2;
                        resultado.Dois++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (x > 0)
                {
                    Console.WriteLine("Este valor não conseguimos, tente " + (temp - x));
                }
                else
                {
                    Console.WriteLine("Notas de 100: " + resultado.Cem);
                    Console.WriteLine("Notas de 50: " + resultado.Cinqenta);
                    Console.WriteLine("Notas de 20: " + resultado.Vinte);
                    Console.WriteLine("Notas de 10: " + resultado.Dez);
                    Console.WriteLine("Notas de 5: " + resultado.Cinco);
                    Console.WriteLine("Notas de 2: " + resultado.Dois);
                }
                return resultado;
            };

            Console.WriteLine("Insira o valor que você deseja sacar: \nLembre-se que não temos moedas, deve-se inserir valor inteiro! ");
            int valor = int.Parse(Console.ReadLine());

        }


    }
}

using System;

namespace Exercicio04
{
    class Program
    {
        enum Cargo
        {
            auxiliar = 1000,
            assistente = 2500,
            analista = 3000,
            coordenador = 4000
        }
        static void Main(string[] args)
        {

            //Use um enum para criar 4 cargos de emprego,então, peça para o usuario escolher um cargo pelo índice,
            //os cargos tambem geram um salário (1000,2500,3000,4000 respectivamente),
            //após isso, mostre o cargo e o salário escolhidos.

            Console.WriteLine("Escolha o cargo desejado pelo índice: ");
            Console.WriteLine("1 = Auxiliar \n2 = Assistente \n3 = Analista \n4 = Coordenador ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine(Convert.ToInt32(Cargo.auxiliar));
                    break;

                case 2:
                    Console.WriteLine(Convert.ToInt32(Cargo.assistente));
                    break;

                case 3:
                    Console.WriteLine(Convert.ToInt32(Cargo.analista));
                    break;

                case 4:
                    Console.WriteLine(Convert.ToInt32(Cargo.coordenador));
                    break;

                default:
                    Console.WriteLine("Não encontrado!");
                    break;

            }
        }
    }
}

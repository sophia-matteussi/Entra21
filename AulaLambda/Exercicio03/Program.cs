using System;

namespace Exercicio03
{
    class Program
    {
        enum Potencia
        {
            dois = 4,
            tres = 8,
            quatro = 16,
            cinco = 32,
            seis = 64,
            sete = 128,
            oito = 256,
            nove = 512,
            dez = 1024
        }
        static void Main(string[] args)
        {
            //3) Use um enum para determinar as potências de 2 até 10

            Console.WriteLine("Digite o numero que vc deseja elevar o 2: (até 10)");
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 2:
                    Console.WriteLine(Convert.ToInt32(Potencia.dois));
                    break;

                case 3:
                    Console.WriteLine(Convert.ToInt32(Potencia.tres));
                    break;

                case 4:
                    Console.WriteLine(Convert.ToInt32(Potencia.quatro));
                    break;

                case 5:
                    Console.WriteLine(Convert.ToInt32(Potencia.cinco));
                    break;

                case 6:
                    Console.WriteLine(Convert.ToInt32(Potencia.seis));
                    break;

                case 7:
                    Console.WriteLine(Convert.ToInt32(Potencia.sete));
                    break;

                case 8:
                    Console.WriteLine(Convert.ToInt32(Potencia.oito));
                    break;

                case 9:
                    Console.WriteLine(Convert.ToInt32(Potencia.nove));
                    break;

                case 10:
                    Console.WriteLine(Convert.ToInt32(Potencia.dez));
                    break;

                default:
                    Console.WriteLine("Erro!");
                    break;

            }
        }
    }
}

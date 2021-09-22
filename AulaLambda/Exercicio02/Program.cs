using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2)Crie um programa que recebe 1 número e então eleve este numero ao quadrado caso o número seja maior que 10,
            //caso menor, nao faça nada (use Lambda)

            Func<int, int> quadrado = x =>
            {
                if (x < 10)
                {
                    return x;
                }
                else
                {
                    return x * x;
                }
            };

            Console.WriteLine("Querido e maravilhoso usuario, inzira um numérico");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(quadrado(numero));

        }
    }
}

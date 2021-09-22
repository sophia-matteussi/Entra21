using System;

namespace Exercicio01
{
    class Program
    {
        enum Nomes
        {
            Cazalbe,
            SilviuSantus,
            Joeslei,
            HebeCamaro,
            DerciGolSalves
        }
        static void Main(string[] args)
        {
            //1) Crie um programa que armazena 5 nome dentro de um enum e então, 
            //peça para o usuario escolher um nome pelo índice dele, então mostre na tela

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}  {1}",i+1,(Nomes)i);
            }
            Console.WriteLine("Qual nome deseja?");
            int escolha = int.Parse(Console.ReadLine());
            escolha--;
            Console.WriteLine((Nomes)escolha);
        }
    }
}

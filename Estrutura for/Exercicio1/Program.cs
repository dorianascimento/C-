using System;

namespace Exercicio1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite um número inteiro (1 <= número <= 1000): ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numero; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, fora, dentro;
            numero = fora = dentro = 0;

            Console.WriteLine("Quantos números serão lidos: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                int contagem = int.Parse(Console.ReadLine());

                if (contagem >= 10 && contagem <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine("\n{0} in\n{1} out", dentro, fora);
        }
    }
}
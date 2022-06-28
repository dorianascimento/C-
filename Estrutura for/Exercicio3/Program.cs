using System;

namespace Exercicio4
{
    class Program
    {
        static double ponderada(double a, double b, double c)
        {
            double peso1 = 2.0;
            double peso2 = 3.0;
            double peso3 = 5.0;
            double media;

            media = ((peso1 * a) + (peso2 * b) + (peso3 * c)) / 10.0;

            return media;
        }
        static void Main(string[] args)
        {
            int quantidade;

            Console.WriteLine("Números de casos:");
            quantidade = int.Parse(Console.ReadLine());
            double[] media = new double[100];

            for (int i = 1; i <= quantidade; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(valor[0]);
                double valor2 = double.Parse(valor[1]);
                double valor3 = double.Parse(valor[2]);

                media[i] = ponderada(valor1, valor2, valor3);
            }
            
            for (int a = 1; a <= quantidade; a++)
            {
                Console.WriteLine("{0:F1}", media[a]);
            }
        }
    }
}
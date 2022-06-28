using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Digite coordenadas X e Y:");
            string[] coordenadas = Console.ReadLine().Split(' ');

            x = int.Parse(coordenadas[0]);
            y = int.Parse(coordenadas[1]);

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                    coordenadas = Console.ReadLine().Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                    coordenadas = Console.ReadLine().Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                    coordenadas = Console.ReadLine().Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                    coordenadas = Console.ReadLine().Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }
            }
        }
    }
}
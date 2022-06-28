// uso do if aninhado

using System;

class Program
{
    // Programa que pede dois numeros e mostra na tela qual é o maior numero e se ele é impar ou par.
    static void Main()
    {
        int a, b;

        Console.WriteLine("Digite dois numeros inteiros:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("O numero {0} é maior que {1} e é par.", a, b);
            }
            else
            {
                Console.WriteLine("O numero {0} é maior que {1} e é impar.", a, b);
            }
        }else if (a < b)
        {
            if (b % 0 == 0)
            {
                Console.WriteLine("O numero {0} é maior que {1} e é par.", b, a);
            }
            else
            {
                Console.WriteLine("O numero {0} é maior que {1} e é impar.", b, a);
            }
        }


    }
}
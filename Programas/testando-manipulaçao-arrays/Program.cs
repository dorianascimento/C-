using System;

class Program
{
    static void Main()
    {
        int[] array = new int[4] { 1, 2, 3, 4 };
        int procurado = 4;

        int posiçao = Array.BinarySearch(array, procurado);
        Console.WriteLine("o valor {0} esta na posicao {1}", procurado, posiçao);


    }
}

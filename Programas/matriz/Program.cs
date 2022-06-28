// uso da matriz

using System;

class Program
{
    static void Main()
    {
        int[,] n = new int[2, 2] { { 1, 2 }, { 3, 4 } };

        for (int i = 0; i < n.GetLength(0); i++)
        {
            for (int j = 0; j < n.GetLength(1); j++)
            {
                Console.WriteLine(n[i, j]);
            }
        }
    }
}
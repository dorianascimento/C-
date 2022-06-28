// uso do for

using System;

class aulafor
{
    static void Main()
    {
        int quantidade, total, media;
        quantidade = total = media = 0;

        Console.Write("Quantas notas serão calculadas hoje?:\t");
        quantidade = int.Parse(Console.ReadLine());

        int[] notas = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("Digite a nota:\n");
            notas[i] = int.Parse(Console.ReadLine());
            total = total + notas[i];

        }

        media = total / quantidade;
    
        Console.WriteLine("A media das notas foi {0}", media);

    }
}
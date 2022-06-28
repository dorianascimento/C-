// programa que pega notas dos alunos como entrada e mostra a maior nota da sala

using System;

class Program
{
    static void Main()
    {
        int quantidades_notas = 0;

        Console.WriteLine("Quantos alunos tem na sala");
        quantidades_notas = int.Parse(Console.ReadLine());

        int[] notas_alunos = new int[quantidades_notas];

        for (int i = 0; i < quantidades_notas; i++)
        {
            Console.Write("Digite a nota >>\t");
            notas_alunos[i] = int.Parse(Console.ReadLine());
        }

        int maior_nota = notas_alunos.GetUpperBound(0);

        Console.WriteLine("A maior nota da sala foi {0}", maior_nota);
    }
}
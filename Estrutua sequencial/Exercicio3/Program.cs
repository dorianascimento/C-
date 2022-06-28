/* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */

using System;

class Exercico3
{
    static void Main()
    {
        int diferenca;
        int a, b;
        int[] vet = new int[4];

        Console.WriteLine("Digite 4 numeros inteiros:");

        for ( int i = 0; i < 4; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());
        }

        a = vet[0] * vet[1];
        b = vet[2] * vet[3];

        diferenca = a - b;

        Console.WriteLine("Diferença = {0}", diferenca);
    }
}

using System;

class Program
{
    static void Main()
    {
        int codigo1, codigo2, quantidade1, quantidade2;
        double preço1, preço2, valorfinal;

        Console.WriteLine("Digite o codigo, a quantidade e o preço do produto 1:\t");
        string[] produto1 = Console.ReadLine().Split(' ');

        codigo1 = int.Parse(produto1[0]);
        quantidade1 = int.Parse(produto1[1]);
        preço1 = double.Parse(produto1[2]);

        Console.WriteLine("Digite o codigo, a quantidade e o preço do produto 2:\t");
        string[] produto2 = Console.ReadLine().Split(' ');

        codigo2 = int.Parse(produto2[0]);
        quantidade2 = int.Parse(produto2[1]);
        preço2 = double.Parse(produto2[2]);

        valorfinal = (preço1 * quantidade1) + (preço2 * quantidade2);

        Console.WriteLine("VALOR A PAGAR: R$ {0}", valorfinal);
    }
}
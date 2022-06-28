/* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
mensagem explicativa, conforme exemplos */

using System;

class exercicio1
{
    static void Main()
    {
        int num1, num2, soma;

        Console.WriteLine("Digite um numero inteiro:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com outro numero inteiro:");
        num2 = int.Parse(Console.ReadLine());
        
        soma = num1 + num2;

        Console.WriteLine("SOMA = {0}", soma);
    }
}




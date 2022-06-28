// uso do goto

using System;

// calculadora usando goto
class Program
{
    static void Main()
    {
        int a, b;
        char escolha;
        a = b = 0;

    inicio:

        Console.Clear();

        Console.Write("Digite um numero >\t");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite outro numero >\t");
        b = int.Parse(Console.ReadLine());
        Console.Write("Digite a operação (*,/,+,-) >\t");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case '*':
                Console.WriteLine("Resultado da operação: {0}", a * b);
                break;

            case '+':
                Console.WriteLine("Resultado da operação: {0}", a + b);
                break;

            case '-':
                Console.WriteLine("Resultado da operação: {0}", a - b);
                break;

            case '/':
                Console.WriteLine("Resultado da operação: {0}", a / b);
                break;

            default:
                Console.WriteLine("Operação invalida digite novamente");
                goto inicio;
                break;
        }

        Console.WriteLine("Deseja repetir o programa?(s/n)");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == 's')
        {
            goto inicio;
        }
        else
        {
            Console.WriteLine("Fim do programa");
            Console.Clear();
        }
    }
}
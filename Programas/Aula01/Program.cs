// uso do for

using System;

class Program
{
    static void Main()
    {
        int nota;

        Console.WriteLine("Digite a nota do aluno:");
        nota = int.Parse(Console.ReadLine());

        // nota >= 7 Aprovado
        // nota <=6 >4 Recuperação
        // nota <= 4 Reprovado
        if (nota <= 4)
        {
            Console.WriteLine("Reprovado");
        }
        else if (nota <=6 && nota > 4)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Aprovado");
        }
        
    }
}
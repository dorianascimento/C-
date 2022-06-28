using System;

class Program
{
    static void Main()
    {
        int numero;
        double salarioPorHora, horas, salario;

        Console.WriteLine("Digite o numero do funcionario:");
        numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o salario do funcionario:");
        salarioPorHora = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite as horas trabalhadas:");
        horas = double.Parse(Console.ReadLine());
        Console.WriteLine();

        salario = salarioPorHora * horas;

        Console.WriteLine("NUMBER = {0:F2}", numero);
        Console.WriteLine("SALARY = U$ {0:F2}", salario);

    }
}
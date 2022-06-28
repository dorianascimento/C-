using System;

class Dados
{
    public string nome;
    public double salario;
}
class Program
{
    static void Main()
    {
        double media;
        Dados funcionario1 = new Dados();
        Dados funcionario2 = new Dados();

        Console.WriteLine("Dados do primeiro funcionario:");
        Console.Write("Nome: ");
        funcionario1.nome = Console.ReadLine();
        Console.Write("Salário: ");
        funcionario1.salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Dados do segundo funcionario:");
        Console.Write("Nome: ");
        funcionario2.nome = Console.ReadLine();
        Console.Write("Salário: ");
        funcionario2.salario = double.Parse(Console.ReadLine());

        media = (funcionario1.salario + funcionario2.salario) / 2;

        Console.WriteLine("Salario medio: {0}", media);

    }
}

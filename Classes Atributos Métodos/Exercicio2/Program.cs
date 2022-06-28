using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Sálario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());
            double salarioLiquido = f.SalarioLiquido();

            Console.WriteLine("Funcionário: "+ f);
            Console.Write("Digite a porcentagem para aumentar o salário: \n");
            double porcentagem = double.Parse(Console.ReadLine());

            salarioLiquido = f.SalarioLiquido();
            Console.WriteLine("Funcionário: "+ f);
        }
    }
}
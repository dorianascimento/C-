using System;
using System.Globalization;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados: ");
            int funcionarios = int.Parse(Console.ReadLine());

            List<Empregado> list = new List<Empregado>();

            for (int i = 1; i <= funcionarios; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregado(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Entre com a Id do funcionário que irá aumentar o salário: ");
            int procurarId = int.Parse(Console.ReadLine());

            Empregado emp = list.Find(x => x.Id == procurarId);
            if (emp != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double valor = double.Parse(Console.ReadLine());
                emp.IncrementarSalario(valor);
            }
            else
            {
                Console.WriteLine("Funcionário não exite");
            }

            Console.WriteLine();

            foreach (Empregado obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
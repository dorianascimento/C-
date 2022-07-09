using System;

namespace MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pessoa 1");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Pessoa pessoa1 = new Pessoa(nome, idade);
            Console.WriteLine();

            Console.WriteLine("Pessoa 2");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            Pessoa pessoa2 = new Pessoa(nome, idade);
            Console.WriteLine();

            Console.WriteLine("Pessoa 3");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            Pessoa pessoa3 = new Pessoa(nome, idade);
            Console.WriteLine();

            if ( pessoa1.Idade > pessoa2.Idade && pessoa1.Idade > pessoa3.Idade)
            {
                pessoa1.ExibirDados();
            }
            else if (pessoa2.Idade > pessoa1.Idade && pessoa2.Idade > pessoa3.Idade)
            {
                pessoa2.ExibirDados();
            }
            else
            {
                pessoa3.ExibirDados();
            }
        }
    }
}
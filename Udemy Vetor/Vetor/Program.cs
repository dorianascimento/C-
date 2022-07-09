using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quntos quartos serão alugados: ");
            int quant = int.Parse(Console.ReadLine());

            DadosPessoais[] quartos = new DadosPessoais[9];

            for (int i = 0; i < quant; i++)
            {
                Console.Write("Aluguel #"+ i +": ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                quartos[i] = new DadosPessoais(nome, email, quarto);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados");

            for (int i = 0; i < quant; i++)
            {
                if (quartos[i] != null)
                {
                    quartos[i].Apresentar(i);
                }
            }
        }
    }
}
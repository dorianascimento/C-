using System;

public class Dados
{
    public string nome;
    public int idade;
}
class Program
{
    static void Main(string[] args)
    {
        Dados pessoa1 = new Dados();
        Dados pessoa2 = new Dados();

        for (int i = 1; i <= 2; i++)
        {
            Console.WriteLine("Dados da pessoa {0}:", i);
            Console.Write("Nome: ");
            if (i == 1)
            {
                pessoa1.nome = Console.ReadLine();
            }
            else
            {
                pessoa2.nome = Console.ReadLine();
            }
            Console.Write("Idade: ");
            if (i == 1)
            {
                pessoa1.idade = int.Parse(Console.ReadLine());
            }
            else
            {
                pessoa2.idade = int.Parse(Console.ReadLine());
            }
        }

        if (pessoa1.idade > pessoa2.idade)
        {
            Console.WriteLine("Pessoa mais velha: {0}", pessoa1.nome);
        }
        else
        {
            Console.WriteLine("Pessoa mais velha: {0}", pessoa2.nome);
        }
    }
}
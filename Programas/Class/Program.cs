using System;

public class Cadastro
{
    public string nome;
    public int idade;
    public long cpf;
}

class Program
{
    static void Main()
    {
        Cadastro pessoa1 = new Cadastro();

        Console.WriteLine("Realize seu cadastro: ");
        
        Console.WriteLine("Digite seu nome: ");
        pessoa1.nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        pessoa1.idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu cpf sem pontos: ");
        pessoa1.cpf = long.Parse(Console.ReadLine());

        Console.WriteLine("\nCadastro realizado com sucesso.");

        Console.WriteLine("Seus dados:\nNome: {0}\nIdade: {1}\nCpf: {2}", pessoa1.nome, pessoa1.idade, pessoa1.cpf);
            
        
    }
}

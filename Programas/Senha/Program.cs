// programa de login que recusa se for digitado errado a senha ou email

using System;

class Program
{
    static void Main()
    {
        string email, senha, senhacomfirmação, nomeusuario, usernome, usersenha;
        int data_nascimento, idade, tentativas;

        Console.WriteLine("Cadastre para continuar no programa.\n");
        Console.Write("Email>>\t\t\t");
        email = Console.ReadLine();
        cls();
        Console.Write("Usuario>>\t\t");
        nomeusuario = Console.ReadLine();
        cls();

    repetirsenha:
        Console.Write("Senha>>\t\t\t");
        senha = Console.ReadLine();
        Console.Write("Repita a senha>>\t");
        senhacomfirmação = Console.ReadLine();
        cls();

        if (senha != senhacomfirmação)
        {
            Console.WriteLine("Repita a senha");
            goto repetirsenha;
        }

    repetiridade:
        Console.Write("Digite o ano de nascimento");
        data_nascimento = int.Parse(Console.ReadLine());
        idade = 2022 - data_nascimento;

        if (idade < 18)
        {
            Console.WriteLine("Apenas para maiores de 18");
            goto repetiridade;
        }

        Console.WriteLine("Conta criada com sucesso");
        Console.WriteLine("Realize seu login para prosseguir");
        do
        {
            Console.Write("Usuario>>\t\t\t");
            usernome = Console.ReadLine();
            Console.Write("Senha>>\t\t\t");
            usersenha = Console.ReadLine();
        
        } while (nomeusuario != usernome || senha != usersenha);

        Console.WriteLine("Login bem sucedido");
    }

    static void cls()
    {
        Console.Clear();
    }
}

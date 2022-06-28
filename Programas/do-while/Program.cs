// uso do do-while


using System;

class Program
{
    static void Main()
    {
        string usuario = "rndoria";
        string senha = "1234";
        string senhausuario, usuario2;
        int tentativas = 0;

        Console.WriteLine("Realize seu login\n");

        do
        {
            Console.WriteLine("Digite seu usuario:");
            usuario2 = Console.ReadLine();
            Console.WriteLine("Digite a senha:");
            senhausuario = Console.ReadLine();
            tentativas++;
            Console.Clear();
            
        }while (usuario != usuario2 || senha != senhausuario);

        Console.Clear();
        Console.WriteLine("Login bem sucedido tentativas {0}", tentativas);
    }
}



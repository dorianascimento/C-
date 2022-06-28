using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;

            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida");
                senha = int.Parse(Console.ReadLine());
            }

            if (senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
            }
        }
    }
}
// construtores

using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Rafael";
            int idade = 21;
            double altura = 1.77;

            Dados pessoa1 = new Dados( nome,  idade,  altura);//so posso fazer a inicialização da classe se eu passar parametros

            Console.WriteLine(pessoa1);
        }
    }
}

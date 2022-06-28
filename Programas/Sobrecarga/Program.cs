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

            Dados pessoa1 = new Dados(nome, idade, altura);//so posso fazer a inicialização da classe se eu passar parametros

            Console.WriteLine(pessoa1);
        }
    }
}
namespace Course
{
    public class Dados
    {
        public string Nome;
        public int Idade;
        public double Altura;

        public Dados(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public override string ToString()
        {
            return "Dados pessoais, Nome: " + Nome + ", Idade: " + Idade + ", Altura: " + Altura;
        }
    }
}


using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, dolar;

            Console.Write("Qual a cotação do dolar? ");
            cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares  você vai comprar? ");
            dolar = double.Parse(Console.ReadLine());

            double reais = ConversorDeMoeda.Cambio(cotacao, dolar);

            Console.WriteLine("Valor a ser pago em reais = {0:F2}", reais);


        }
    }
}
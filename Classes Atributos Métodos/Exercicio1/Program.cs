using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo valores = new Retangulo();
            double area, perimetro, diagonal;

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            valores.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valores.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = valores.Area();
            perimetro = valores.Perimetro();
            diagonal = valores.Diagonal();

            Console.WriteLine("AREA: "+ area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + area.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
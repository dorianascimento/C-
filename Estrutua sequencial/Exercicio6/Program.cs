using System;

class Program
{
    static void Main()
    {
        double a, b, c;
        double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
        double pi = 3.14159;

        Console.WriteLine("Digite valor de A, B e C:");
        string[] vet = Console.ReadLine().Split(' ');

        a = double.Parse(vet[0]);
        b = double.Parse(vet[1]);
        c = double.Parse(vet[2]);

        areaTriangulo = (a * b) / 2;
        areaCirculo = pi * Math.Pow(c, 2);
        areaTrapezio = ((a + b) / 2) * c;
        areaQuadrado = Math.Pow(b , 2);
        areaRetangulo = a * b;

        Console.WriteLine("TRIANGULO: {0}", areaTriangulo);
        Console.WriteLine("CIRCULO: {0}", areaCirculo);
        Console.WriteLine("TRAPEZIO: {0}", areaTrapezio);
        Console.WriteLine("QUADRADO: {0}", areaQuadrado);
        Console.WriteLine("RETANGULO: {0}", areaRetangulo);
    }
}
/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159 */

using System;

class Exercico2
{
    static void Main()
    {
        double pi = 3.14159;
        double area, raio;

        Console.WriteLine("Digite valor do raio:");
        raio = Double.Parse(Console.ReadLine());

        area = pi * Math.Pow(raio, 2);
        Console.WriteLine("A = {0:F4}", area);
    }
}
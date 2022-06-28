// uso do while

using System;

class Program
{
    // progroma que pede dois numeros e mostra os numeros entre eles usando while
    static void Main()
    {
        int num1, num2;
        num1 = num2 = 0;

        Console.WriteLine("Digite dois numeros:");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("\n\n");

        if (num1 < num2)
        {
            while (num1 <= num2)
            {
                Console.Write("{0}\t", num1);
                num1++;
            }
        }
        else
        {
            while (num2 <= num1)
            {
                Console.Write("{0}\t", num2);
                num2++;
            }
        }
    }
}

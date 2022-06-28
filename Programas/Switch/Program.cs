// uso do switch

using System;

class Program
{
    // programa que fala o tempo de uma cidade a outra com diferentes tipos de locomoção usando switch.
    static void Main()
    {
        char escolha;
        int minutos = 0;

        Console.WriteLine("Fernandopolis/Sp a São Paulo/Sp:");
        Console.WriteLine("Escolha seu transporte: [a]Avião  |  [b]Carro  |  [c]Ônibus");
        escolha= char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A':
                minutos = 60;
                break;

            case 'b':
            case 'B':
                minutos = 8*60;
                break;

            case 'c':
            case 'C':
                minutos = 12 * 60;
                break;

            default:
                minutos = -1;
                break;
        }
        
        if (escolha < 0)
        {
            Console.WriteLine("Transporte negado");
        }else
        {
            Console.WriteLine("O tempo de viagem é {0} minutos", minutos);
        }

    }
}
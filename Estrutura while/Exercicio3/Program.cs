using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool, gasolina, diesel, escolha;
            alcool = gasolina = diesel = 0;

            Console.WriteLine("Pesquisa de preferência de produtos\n");
            Console.WriteLine("1.Álcool\t2.Gasolina\t3.Diesel\t4.Fim\n");

            escolha = int.Parse(Console.ReadLine());

            while (escolha != 4)
            {
                if (escolha == 1)
                {
                    alcool++;
                    escolha = int.Parse(Console.ReadLine());
                }
                else if (escolha == 2)
                {
                    gasolina++;
                    escolha = int.Parse(Console.ReadLine());
                }
                else
                {
                    diesel++;
                    escolha = int.Parse(Console.ReadLine());
                }

                if (escolha == 4)
                {
                    Console.WriteLine("MUITO OBRIGADO\nÁlcool: {0}\nGasolina: {1}\nDiesel: {2}", alcool, gasolina, diesel);
                }
            }
        }
    }
}
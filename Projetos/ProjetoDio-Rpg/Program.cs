using System;
using ProjetoDio_Rpg.Entities;

namespace ProjetoDio.Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(42, "Arus", 749, 72, "Kinght");
            Ninja ninja = new Ninja(42, "Wedge", 574, 89, "Ninja");
            WriteWizard writeWizard = new WriteWizard(42, "Jenica", 601, 482, "Write Wizard");
            BlackWizard blackWizzard = new BlackWizard(42, "Topapa", 385, 641, "Black Wizard");
            Console.WriteLine(knight + "" + ninja + "" + writeWizard + "" + blackWizzard);
        }
    }
}
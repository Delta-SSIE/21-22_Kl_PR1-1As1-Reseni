using System;

namespace _03_While_170_Minimax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sestavte program, který se uživatele ptá na čísla tak dlouho, dokud uživatel nevloží příkaz "X"
            //Poté vypíše minimální a maximální a průměrné vložené číslo.
            //Pozor, neplatné vstupy budou uživateli oznámeny jako chyba, program nespadne.

            Console.WriteLine("Zadávej čísla, ukonči příkazem \"X\"");

            double minimum = double.PositiveInfinity;
            double maximum = double.NegativeInfinity;
            double soucet = 0;
            int pocet = 0;

            Console.Write("Zadej první číslo: ");
            string prikaz = Console.ReadLine();

            while (prikaz.ToUpper() != "X")
            {
                double cislo;

                if (double.TryParse(prikaz, out cislo))
                {
                    soucet += cislo;
                    pocet++;
                    if (cislo < minimum)
                        minimum = cislo;
                    if (cislo > maximum) // Pozor, nelze použít else if. Uhodnete proč?
                        maximum = cislo;

                    Console.Write("Zadej další: ");
                }
                else
                {
                    Console.Write("To není číslo, zkus to znovu");
                }

                prikaz = Console.ReadLine();
            }
            if (pocet > 0)
                Console.WriteLine($"Zadáno {pocet} čísel, nejmenší bylo {minimum}, největší {maximum}, průměr vložených čísel byl {soucet/pocet}.");
            else
                Console.WriteLine("3 vloženo žádné číslo.");
        }
    }
}

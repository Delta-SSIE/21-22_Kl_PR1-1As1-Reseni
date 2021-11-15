using System;

namespace _03_While_160_Bezpecne_nacteni_cisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej celé číslo: ");

            int cislo; // připravím proměnnou do které se bude ukládat

            // dokud nebude pokus o parsování úspěšný,
            // bude se opakovat načítání kolem dokola
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                // varování s evypíše jen, pokud se parsování nepovedlo
                Console.WriteLine("Má to být číslo.");
            }

            // záverečný výpis
            Console.WriteLine("Zadal jsi {0}", cislo);

        }
    }
}

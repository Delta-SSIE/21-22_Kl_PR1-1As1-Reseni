using System;

namespace _04_For_120_Jsou_vsechna_cisla_licha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik čísel budeme testovat: ");

            int pocet = int.Parse(Console.ReadLine());
            bool vsechnaLicha = true;

            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Zadej číslo: ");
                int cislo = int.Parse(Console.ReadLine());
                if (cislo % 2 == 0)
                {
                    vsechnaLicha = false;
                    break;
                }
            }

            if (vsechnaLicha)
                Console.WriteLine("Všechna vložená čísla byla lichá.");
            else
                Console.WriteLine("Poslední vložené číslo bylo sudé.");
        }
    }
}

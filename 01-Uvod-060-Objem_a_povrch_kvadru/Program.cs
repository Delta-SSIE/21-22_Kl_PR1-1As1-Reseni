using System;

namespace _060_Objem_a_povrch_kvadru
{
    class Program
    {
        static void Main(string[] args)
        {
            // Úloha je stejná s předchozí, komentáře jsou všechny tam

            Console.Write("Zadej hranu A: ");
            string zadanoA = Console.ReadLine();
            double hranaA = double.Parse(zadanoA);

            Console.Write("Zadej hranu B: ");
            string zadanoB = Console.ReadLine();
            double hranaB = double.Parse(zadanoB);

            Console.Write("Zadej hranu A: ");
            string zadanoC = Console.ReadLine();
            double hranaC = double.Parse(zadanoC);

            double objem = hranaA * hranaB * hranaC;
            double povrch = 2 * (hranaA * hranaB + hranaB * hranaC + hranaC * hranaA);

            Console.WriteLine("Kvádr o stranách {0}, {1} a {2} má objem {3} a povrch {4}.", hranaA, hranaB, hranaC, objem, povrch);
        }
    }
}

using System;

namespace _02_Podm_070_Chyba_c_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napiš číslo: ");
            string nacteno = Console.ReadLine();
            double cislo = double.Parse(nacteno);

            if (10 > Math.Abs(cislo))
                Console.WriteLine($"Číslo {cislo} je blízko nuly.");
            else
                Console.WriteLine($"Číslo {cislo} je poměrně velké.");

        }
    }
}

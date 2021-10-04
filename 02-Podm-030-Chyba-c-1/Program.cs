using System;

namespace _02_Podm_030_Chyba_c_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napiš číslo: ");
            string nacteno = Console.ReadLine();
            double cislo = double.Parse(nacteno);

            if (cislo % 4 == 0)
            {
                Console.WriteLine($"Číslo {cislo} je dělitelné čtyřmi.");
            }
            else
            {
                Console.WriteLine($"Čtyřmi {cislo} číslo dělitelné není.");
            }
        }
    }
}

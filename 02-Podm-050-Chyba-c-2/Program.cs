using System;

namespace _02_Podm_050_Chyba_c_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Napiš číslo: ");
            string nacteno = Console.ReadLine();
            int cislo = int.Parse(nacteno);

            if (cislo % 3 == 0)
            {
                Console.WriteLine($"Číslo {cislo} je dělitelné třemi, to se mi líbí.");
            }
            else
            { // jde o tyhle závorky
                Console.WriteLine($"Třemi číslo {cislo} dělitelné není.");
                Console.WriteLine("Taková čísla nemám rád.");
            } // které tu chyběly a tak se dělal podmínečně pouze první příkaz, druhý vždy

        }
    }
}

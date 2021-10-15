using System;

namespace _02_Podm_180_Delitelnost_2_a_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej celé číslo: ");
            int cislo = int.Parse(Console.ReadLine());

            // přímočará cesta
            // if (cislo % 2 == 0 && cislo % 3 == 0) což by šlo přepsat - viz následující řádek
            if (cislo % 6 == 0) 
                Console.WriteLine($"Číslo {cislo} je dělitelné 2 i 3.");
            else if (cislo % 3 == 0)
                Console.WriteLine($"Číslo {cislo} není dělitelné 2 a je dělitelné 3.");
            else if (cislo % 2 == 0)
                Console.WriteLine($"Číslo {cislo} je dělitelné 2 a není dělitelné 3.");
            else
                Console.WriteLine($"Číslo {cislo} není dělitelné 2 a ani 3.");

            // jednodušší kód, horší čeština:
            Console.WriteLine(
                "Číslo {0} {1} dělitelné 2 a {2} dělitelné 3", 
                cislo, 
                cislo % 2 == 0 ? "je" : "není", 
                cislo % 3 == 0 ? "je" : "není"
            );
        }
    }
}

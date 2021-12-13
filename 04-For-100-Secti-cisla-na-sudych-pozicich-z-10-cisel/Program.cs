using System;

namespace _04_For_100_Secti_cisla_na_sudych_pozicich_z_10_cisel
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocet = 10;
            double suma = 0;

            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Zadej číslo: ");

                /* buď prosté načtení */
                double cislo = double.Parse(Console.ReadLine());

                /* nebo bezpečný zápis s parsováním - odkomentujte a zakomentujte řádek nad */
                //double cislo;
                //while (!double.TryParse(Console.ReadLine(), out cislo))
                //{
                //    Console.Write("Chyba formátu, zadej číslo znovu: ");
                //}

                if (i % 2 == 1) // přičteme jen čísla na sudých pozicích - to je druhé (i = 1), čtvrté (i=3), šesté (i=5)
                    suma += cislo;
            }

            Console.WriteLine($"Součet čísel vložených na sudých pozicích je {suma}.");
        }
    }
}

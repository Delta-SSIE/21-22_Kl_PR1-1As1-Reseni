using System;

namespace _04_For_090_Secti_suda_cisla_z_10_cisel
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
                int cislo = int.Parse(Console.ReadLine());

                /* nebo bezpečný zápis s parsováním - odkomentujte a zakomentujte řádek nad */
                //int cislo;
                //while (!int.TryParse(Console.ReadLine(), out cislo))
                //{
                //    Console.Write("Chyba formátu, zadej číslo znovu: ");
                //}

                if (cislo % 2 == 0) // přičteme jen sudá čísla
                    suma += cislo; 
            }

            Console.WriteLine($"Součet vložených sudých čísel je {suma}.");
        }
    }
}

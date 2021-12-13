using System;

namespace _04_For_080_Sečti_10_cisel
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

                suma += cislo;
            }

            Console.WriteLine($"Součet vložených {pocet} čísel je {suma}.");
        }
    }
}

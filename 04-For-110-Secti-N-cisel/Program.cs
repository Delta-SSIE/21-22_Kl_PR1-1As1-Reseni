using System;

namespace _04_For_110_Secti_N_cisel
{
    class Program
    {
        static void Main(string[] args)
        {
            // až na tento řásek je kód identický se sčítáním N čísel v úloze 080
            Console.WriteLine("Kolik čísel budeme sčítat: ");

            int pocet = int.Parse(Console.ReadLine());
            double suma = 0;

            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Zadej číslo: ");
                double cislo = double.Parse(Console.ReadLine());
                suma += cislo;
            }

            Console.WriteLine($"Součet vložených {pocet} čísel je {suma}.");
        }
    }
}

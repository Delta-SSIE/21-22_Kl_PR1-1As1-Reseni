using System;

namespace _04_For_130_Prumer_z_N_cisel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik čísel budeme průměrovat: ");
            int pocet = int.Parse(Console.ReadLine());

            double suma = 0;

            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Číslo: ");
                double cislo;
                while (!double.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.Write("Chyba formátu, vložte číslo znovu: ");
                }

                suma += cislo;
            }

            Console.WriteLine("Průměrná hodnota čísla byla {0}.", suma / pocet);

        }
    }
}

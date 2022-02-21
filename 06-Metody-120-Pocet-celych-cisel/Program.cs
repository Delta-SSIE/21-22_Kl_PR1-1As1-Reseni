using System;
using System.Linq;

namespace _06_Metody_120_Pocet_celych_cisel
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] cisla = { 1.3, 1.7, 2, 3.1, 0.1, -1 };
            //obsahuje 2 celá čísla, 2 a -1

            Console.WriteLine(
                "Pole  [{0}] obsahuje {1} celých čísel",
                string.Join("; ", cisla),
                //PocetCelych(cisla)
                PocetCelychLinq(cisla)
            );
        }

        public static int PocetCelych(double[] cisla)
        {
            int vysledek = 0;
            foreach (double cislo in cisla)
                if (cislo % 1 == 0)
                    vysledek++;
            return vysledek;
        }
        public static int PocetCelychLinq(double[] cisla)
        {
            return cisla.Where(x => x % 1 == 0).Count();
        }

    }
}

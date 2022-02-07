using System;
using System.Linq;

namespace _05_Pole_100_Minimax_v_poli
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { 1.1, 2.35, -0.57, 4.13, -0.03, 3.14, -1.59, 2.65, -3.59};

            /*
             * Varianta 1 - takto je potřeba umět
             */

            // nastavíme obě proměnné na 1. prvek
            double minimum = cisla[0];
            double maximum = cisla[0];

            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] > maximum)
                    maximum = cisla[i];
                else if (cisla[i] < minimum)
                    minimum = cisla[i];
            }

            Console.WriteLine($"Největší číslo v poli je {maximum} a nejmenší je {minimum}");

            Console.WriteLine();

            /*
             * Varianta 2 - jde to snáze, ale musíme znát možnosti jazyka
             * Zde hlavně LINQ
             */

            Console.WriteLine($"Největší číslo v poli je {cisla.Max()} a nejmenší je {cisla.Min()}");
        }
    }
}

using System;
using System.Linq;

namespace _05_Pole_110_Nadprumerne_hodnoty
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocet = 8;

            Console.WriteLine("Zadej {0} celých čísel:", pocet);

            //vytvořím pole - délku znám
            int[] cisla = new int[pocet];

            //načtu čísla
            for (int i = 0; i < pocet; i++)
            {
                cisla[i] = int.Parse(Console.ReadLine());
            }

            /* Povinný způsob - toto musíme zvládnout naprogramovat */
            //spočtu průměr
            int suma = 0;
            for (int i = 0; i < cisla.Length; i++)
            {
                suma += cisla[i];
            }
            double prumer = (double)suma / pocet;

            //vypíšu nadprůměrná
            Console.WriteLine("Ze zadaných čísel byla nadprůměrná tato:");

            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] > prumer)
                    Console.WriteLine(cisla[i]);
            }


            /* Varianta 2 - nepovinná - s použitím LINQ (jen ukázka pro inspiraci) */
            /* kvůli této variantě je v záhlaví souboru uvedeno using System.Linq */
            double prumer2 = cisla.Average();
            foreach (double num in cisla.Where(x => x > prumer2))
            {
                Console.WriteLine(num);
            }
        }
    }
}

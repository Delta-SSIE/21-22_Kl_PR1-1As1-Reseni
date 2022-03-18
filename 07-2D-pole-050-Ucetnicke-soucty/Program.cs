using System;
using System.Linq;

namespace _07_2D_pole_050_Ucetnicke_soucty
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] cisla = {
            {1, 0, 10, 4, 7},
            {2, 2, 3, 4, 2},
            {6, 5, 4, 3, 2}
        };

            Ucetni(cisla);
        }
        public static void Ucetni(int[,] cisla)
        {
            //nasčítáme řádky, sloupce (šlo by ale dělat i přímo při výpisu)
            int[] radkoveSoucty = new int[cisla.GetLength(0)];
            int[] sloupcoveSoucty = new int[cisla.GetLength(1)];

            for (int y = 0; y < cisla.GetLength(0); y++)
            {
                for (int x = 0; x < cisla.GetLength(1); x++)
                {
                    radkoveSoucty[y] += cisla[y, x];
                    sloupcoveSoucty[x] += cisla[y, x];
                }
            }


            //zjistím celkový součet
            int total = radkoveSoucty.Sum();
            int total2 = sloupcoveSoucty.Sum();

            //vypíšu čísla, oddělím čárkami
            for (int y = 0; y < cisla.GetLength(0); y++)
            {
                for (int x = 0; x < cisla.GetLength(1); x++)
                {
                    Console.Write(cisla[y, x]);
                    if (x < cisla.GetLength(1) - 1) //za posledním čárku nepíšu
                        Console.Write(", ");
                }
                Console.Write(" | ");//za poslední dám oddělovač |
                Console.WriteLine(radkoveSoucty[y]); //a připíšu řádkový součet
            }
            
            Console.WriteLine("".PadRight(sloupcoveSoucty.Length * 3 + 4, '-')); //odhad počtu pomlček podle počtu čísel.

            //výpis sloupcových součtů
            for (int i = 0; i < sloupcoveSoucty.Length; i++)
            {
                Console.Write(sloupcoveSoucty[i]);
                if (i < cisla.GetLength(1) - 1)
                    Console.Write(", ");

            }
            Console.Write(" | ");
            Console.WriteLine( total ); //celkový součet

            Console.Write("".PadRight(sloupcoveSoucty.Length * 3 + 4), " ");//odhad počtu pomlček podle počtu čísel.
            Console.WriteLine(total2); //druhý celkový součet
        }
    }
}

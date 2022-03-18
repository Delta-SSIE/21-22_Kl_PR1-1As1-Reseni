using System;

namespace _07_2D_pole_030_Nacti_z_klavesnice
{
    class Program
    {
        public static void Main(string[] args)
        {
            //do tohoto kódu nezasahujte
            int radky = 4;
            int sloupce = 3;
            int[,] tabulka = Nacti2DPole(radky, sloupce);
            Vypis2DPole(tabulka);
        }

        //sem přijde kód vaší metody
        static int[,] Nacti2DPole(int radky, int sloupce)
        {
            int[,] pole = new int[radky, sloupce];

            for (int x = 0; x < radky; x++)
            {
                for (int y = 0; y < sloupce; y++)
                {
                    Console.Write($"Řádek {x + 1}, sloupec {y + 1} - zadej číslo: ");
                    while (!int.TryParse(Console.ReadLine(), out pole[x, y]))
                    {
                        Console.Write("Neplatný vstup, opakuj: ");
                        pole[x, y] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            return pole;
        }

        //konec vašeho kódu

        public static void Vypis2DPole(int[,] pole)
        {
            //do kódu této metody nezasahujte
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

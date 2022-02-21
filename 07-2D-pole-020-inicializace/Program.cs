using System;

namespace _07_2D_pole_020_inicializace
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] cisla = { 1, 3, 5, 7, 9 };

            int[,] cisla = 
            {
                { 1, 3, 5, 7 },
                { 2, 4, 6, 8 },
                {-1, 0, 1, 0 }
            };

            for (int y = 0; y < cisla.GetLength(0); y++)
            {
                Console.Write("| ");
                for (int x = 0; x < cisla.GetLength(1); x++)
                {
                    Console.Write($"[{x}, {y}] : {cisla[y, x]}  | ");
                }
                Console.WriteLine();
            }

            Vypis2DPole(cisla);
        }

        public static void Vypis2DPole (int[,] pole)
        {
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                Console.Write("| ");
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}

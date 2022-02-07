using System;

namespace _05_Pole_200_Histogram_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hodnoty = { 1, 3, 2, 4, 7, 12, 4 };

            for (int i = 0; i < hodnoty.Length; i++)
            {
                //záhlaví řádku
                Console.Write($"{i}: ");

                //a teď vypíšeme tolik symbolů #, kolik je na aktuální pozici v poli
                for (int j = 0; j < hodnoty[i]; j++)
                {
                    Console.Write("#");
                }

                //a odřádkujeme
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace _04_For_260_Namaluj_trojuhelnik_typu_delta
{
    class Program
    {
        static void Main(string[] args)
        {
            int vyska = 10;
            // int zakladna = 2 * vyska - 1;  //nepoužiju, jen si rozmyslím, jaká je šířka z závislosti na výšce

            for (int y = 0; y < vyska; y++)
            {
                for (int x = 0; x < vyska - y - 1; x++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < 2 * y + 1; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}

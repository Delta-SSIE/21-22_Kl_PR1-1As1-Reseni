using System;

namespace _07_2D_pole_020_Kresleni
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool[,] mapa =
            {
                {  true, false, false,  true, false, false,  true},
                { false,  true, false,  true, false,  true, false},
                { false, false,  true,  true,  true, false, false},
                { false, false, false,  true, false, false, false},
            };

            VykresliPole(mapa, 'X', '-');

        }

        static void VykresliPole(bool[,] mapa, char znakTrue, char znakFalse)
        {
            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    if (mapa[y, x])
                        Console.Write(znakTrue);
                    else
                        Console.Write(znakFalse);
                }
                Console.WriteLine();
            }
        }
    }
}

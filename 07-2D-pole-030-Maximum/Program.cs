using System;

namespace _07_2D_pole_030_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] cisla =
            {
                { 1, 3, 5, 7 },
                { 2, 4, 6, 8 },
                {-1, 0, 1, 0 }
            };

            Console.WriteLine("maximum je " + MaxVPoli(cisla));
        }
        static int MaxVPoli(int[,] pole)
        {
            //vytvořit proměnnou pro uložení
            int maximum = int.MinValue;

            //projít vše
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    if (pole[y, x] > maximum) //kdyuž najdu větší, uložím si
                        maximum = pole[y, x];
                }
            }

            //vrátim největší, co jsem našel
            return maximum;
        }

    }
}

using System;

namespace _04_For_240_Namaluj_trojuhelnik_typu_q
{
    class Program
    {
        static void Main(string[] args)
        {
            int strana = 10;
            for (int y = 0; y < strana; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < strana - y; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}

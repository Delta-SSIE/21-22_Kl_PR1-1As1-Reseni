using System;

namespace _04_For_230_Namaluj_trojúhelnik_typu_p
{
    class Program
    {
        static void Main(string[] args)
        {
            int strana = 10;
            for (int y = 0; y < strana; y++)
            {
                for (int x = 0; x < strana - y; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}

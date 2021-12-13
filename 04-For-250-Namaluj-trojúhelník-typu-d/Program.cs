using System;

namespace _04_For_250_Namaluj_trojúhelník_typu_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int strana = 10;
            for (int y = 0; y < strana; y++)
            {
                for (int x = 0; x < strana - y - 1; x++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < y + 1; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}

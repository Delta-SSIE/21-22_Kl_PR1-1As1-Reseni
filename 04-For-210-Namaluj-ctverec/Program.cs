using System;

namespace _04_For_210_Namaluj_ctverec
{
    class Program
    {
        static void Main(string[] args)
        {
            int delka = 8;
            for (int y = 0; y < delka; y++)
            {
                for (int x = 0; x < delka; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}

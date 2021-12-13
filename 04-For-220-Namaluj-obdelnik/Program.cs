using System;

namespace _04_For_220_Namaluj_obdelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            int vyska = 10;
            int sirka = 6;
            for (int y = 0; y < vyska; y++)
            {
                for (int x = 0; x < sirka; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}

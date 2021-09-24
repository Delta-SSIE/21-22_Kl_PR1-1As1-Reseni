using System;

namespace _020_Nej_skola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Na konci řádků chyběly středníky, které ukončují příkazy
            Console.WriteLine("Jak se jmenuje tvoje škola?");
            string skola = Console.ReadLine();
            Console.WriteLine(skola + " je nejlepší!");
        }
    }
}

using System;

namespace _030_Domaci_vs_hoste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kolem všech řetězců (textů) chyběly uvozovky.
            // Řetězce (datový typ string) vždy uzavíráme do dvojitých uvozovek

            Console.Write("Zadej skore domácích: ");
            string domaci = Console.ReadLine();

            Console.Write("Zadej skore hostů: ");
            string hoste = Console.ReadLine();

            Console.WriteLine("Výsledek zápasu je " + domaci + ":" + hoste);
        }
    }
}

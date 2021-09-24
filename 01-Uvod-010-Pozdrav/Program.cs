using System;

namespace _010_Pozdrav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vlož své jméno :");
            // int jmeno = Console.ReadLine();
            string jmeno = Console.ReadLine(); // z klávesnice načítáme řetězec, nikoliv celé číslo (int)
            Console.WriteLine("Ať žije " + jmeno + "!");
        }
    }
}

using System;

namespace _06_Metody_060_Delsi_slovo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Zadej první slovo: ");
            string slovo1 = Console.ReadLine();

            Console.Write("Zadej druhé slovo: ");
            string slovo2 = Console.ReadLine();

            string delsiSlovo = DelsiSlovo(slovo1, slovo2); // sem přijde zavolání vaší metody, nic jiného zde neměňte
            Console.WriteLine($"Když porovnáme {slovo1} a {slovo2}, pak delší je {delsiSlovo}.");
        }
        public static string DelsiSlovo(string slovo1, string slovo2)
        {
            return slovo1.Length >= slovo2.Length ? slovo1 : slovo2;

            //nebo
            //
            //if (slovo1.Length >= slovo2.Length)
            //    return slovo1;
            //else
            //    return slovo2;
        }
    }
}

using System;

namespace _06_Metody_080_Delka_tri_retezcu
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Zadej 1 slovo: ");
            string slovo1 = Console.ReadLine();

            Console.Write("Zadej 2 slovo: ");
            string slovo2 = Console.ReadLine();

            Console.Write("Zadej 3 slovo: ");
            string slovo3 = Console.ReadLine();

            //zařiďte pomocí vaší statické metody,
            //aby program vypsal text 
            //Celková délka napsaných slov je XYZ znaků.
            Console.WriteLine($"Celková délka napsaných slov je {DelkaTri(slovo1, slovo2, slovo3)} znaků.");
        }

        public static int DelkaTri(string word1, string word2, string word3)
        {
            return word1.Length + word2.Length + word3.Length;
        }
    }
}

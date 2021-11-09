using System;

namespace _03_While_030_Nacti_sude
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vytvořte program, který vyzve uživatele, aby zadal sudé číslo a bude výzvu opakovat tak dlouho, dokud uživatel neuspěje.Pak vypíše nejbližší vyšší liché číslo

            Console.WriteLine("Zadej sudé číslo");
            int cislo = int.Parse(Console.ReadLine());

            while (cislo %2 != 0)
            {
                Console.WriteLine("To není sudé, zkus to znovu:");
                cislo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Zadal jsi {0}", cislo);
        }
    }
}

using System;

namespace _03_While_060_Sude_nad_deset
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vytvořte program, který vyzve uživatele, aby zadal sudé číslo větší než deset a bude výzvu opakovat tak dlouho, dokud uživatel neuspěje. Pak vložené číslo vypíše
            
            int cislo;
            bool poprve = true;            
            
            do
            {
                if (!poprve)
                {
                    Console.WriteLine("To nevyhovuje podmínkám, zkus to znovu:");
                }
                poprve = false;
                Console.WriteLine("Zadej sudé číslo větší než deset");
                cislo = int.Parse(Console.ReadLine());
            } while (cislo % 2 != 0 || cislo < 11);

            Console.WriteLine("Zadal jsi číslo {0}", cislo);
        }
    }
}

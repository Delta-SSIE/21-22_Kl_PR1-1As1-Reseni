using System;

namespace _04_While_040_Nacti_trojciferne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vytvořte program, který vyzve uživatele, aby zadal trojciferné číslo a bude výzvu opakovat tak dlouho, dokud uživatel neuspěje. Pak vložené číslo vypíše

            int cislo;
            bool prvni = true;
            do
            {
                if (!prvni)
                    Console.WriteLine("To není trojciferné, zkus to znovu:");
                Console.WriteLine("Zadej trojciferné číslo");
                cislo = int.Parse(Console.ReadLine());
                prvni = false;
            }
            while (cislo < 100 || cislo > 999);

            Console.WriteLine("Zadal jsi {0}", cislo);
        }
    }
}

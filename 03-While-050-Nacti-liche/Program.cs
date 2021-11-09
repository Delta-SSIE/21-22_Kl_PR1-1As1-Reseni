using System;

namespace _03_While_050_Nacti_liche
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vytvořte program, který vyzve uživatele, aby zadal liché číslo a bude výzvu opakovat tak dlouho, dokud uživatel neuspěje. Pak vypíše nejbližší vyšší násobek deseti

            Console.WriteLine("Zadej liché číslo");
            int cislo = int.Parse(Console.ReadLine());

            while (cislo % 2 == 0)
            {
                Console.WriteLine("To není liché, zkus to znovu:");
                cislo = int.Parse(Console.ReadLine());
            }

            int zbytek = cislo % 10;
            int nasobek10 = cislo - zbytek + 10;
            Console.WriteLine("Nejbližší vyšší násobek deseti k číslu {0} je {1}", cislo, nasobek10);
        }
    }
}

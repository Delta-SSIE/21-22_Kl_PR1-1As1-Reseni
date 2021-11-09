using System;

namespace _03_While_110_Kdy_padne_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //generrátor náhodných čísel
            int cislo; //připravená proměnná pro uložení čísla

            do
            {

                int pocetHodu = 0; // kolikrát jsem musel hodit - zatím ani jednou, proto 0

                do
                {
                    cislo = rnd.Next(1, 7); // hoď si mezi 1 a 6
                                            // pozor, zde nelze napsat int cislo - nebylo by přístupné v podmínce, 
                                            // proměnná vždy patří jen mezi složené závorky, mezi kterými byla deklarována, 
                                            // ven se nedostane

                    pocetHodu++; //zvyš počet hodů
                }
                while (cislo < 6); //dokud nepadne šestka

                Console.WriteLine("Bylo třeba {0} hodů.", pocetHodu);
                Console.Write("Mám to zkusit znovu (A/N): ");
            }
            while (Console.ReadLine().ToLower() != "n"); //dokud nedostanu odpověď N, opakuji vše znovu
        }
    }
}

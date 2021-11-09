using System;

namespace _03_While_150_Minimum_ze_ctvrtych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej přirozená čísla, já zjistím, které bylo nejmenší ze čtvrtého, osmého apod. Vložením 0 nebo záporného čísla sčítání ukončíš");

            //připravím si průběžné minimum
            int minimum = int.MaxValue; // dám tam největší myslitelnou hodnotu

            // a také připravím počitadlo průchodů
            int pocitadlo = 0;

            // připravím proměnnou na načítání a poprvé do ní uložím
            int nacteno = int.Parse(Console.ReadLine());

            while (nacteno > 0) //dokud je to kladné, budu pracovat
            {
                pocitadlo++; //zvýším počitadlo - ve kterém kroku jsem

                //pokud jsem na správné pozici - 4.,8.,12,…, a zároveň je číslo malé
                if (pocitadlo % 4 == 0 && nacteno < minimum) 
                    minimum = nacteno;// uložím si ho jako nové minimum

                nacteno = int.Parse(Console.ReadLine()); // načtu další číslo
            }

            if (pocitadlo > 3)
            {
                Console.WriteLine($"Nejmenší číslo z požadovaných bylo {minimum}.");
            }
            else
            {
                Console.WriteLine($"Nebylo zadáno dost čísel, nemohl jsem si nic uložit.");
            }

        }    
    }
}

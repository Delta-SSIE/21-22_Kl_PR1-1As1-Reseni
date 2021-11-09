using System;

namespace _03_While_120_Pocty_podle_parity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej přirozená čísla, já budu počítat, kolik jich je sudých a lichých. Vložením 0 nebo záporného čísla sčítání ukončíš");

            //připravím si počitadla na čísla
            int sude = 0; 
            int liche = 0;

            // připravím proměnnou na načítání a poprvé do ní uložím
            int nacteno = int.Parse(Console.ReadLine()); 

            while (nacteno > 0) //dokud je to kladné, budu pracovat
            {
                if (nacteno % 2 == 0) //podle zbytku po dělení dvěma zvýším jedno nebo druhé počitadlo
                    sude++; 
                else
                    liche++;

                nacteno = int.Parse(Console.ReadLine()); // načtu další číslo
            }

            Console.WriteLine($"Celkem bylo vloženo {sude} sudých a {liche} lichých čísel.");
        }
    }
}

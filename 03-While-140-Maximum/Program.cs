using System;

namespace _03_While_140_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej přirozená čísla, já zjistím, které bylo největší. Vložením 0 nebo záporného čísla sčítání ukončíš");

            //připravím si průběžné maximum
            int maximum = int.MinValue; // dám tam nejmenší myslitelnou hodnotu

            // připravím proměnnou na načítání a poprvé do ní uložím
            int nacteno = int.Parse(Console.ReadLine());

            while (nacteno > 0) //dokud je to kladné, budu pracovat
            {
                if (nacteno > maximum) // dostal jsme číslo větší, než si pamatuju?
                    maximum = nacteno; // uložím si ho jako nové maximum

                nacteno = int.Parse(Console.ReadLine()); // načtu další číslo
            }

            if (maximum > int.MinValue) // Změnila se hodnota od začátku programu?
            {
                // Pokud ano, je co vypisovat.
                Console.WriteLine($"Nejmenší číslo z požadovaných bylo {maximum}.");
            }
            else
            {
                // Pokud ne, jen oznámím
                Console.WriteLine($"Nebylo zadáno dost čísel, nemohl jsem si nic uložit.");
            }

        }
    }
}

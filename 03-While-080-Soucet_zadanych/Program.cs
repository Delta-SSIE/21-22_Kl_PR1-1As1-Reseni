using System;

namespace _03_While_080_Soucet_zadanych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej čísla, já je budu sčítat. Vložením 0 sčítání ukončíš");
            double suma = 0; //sem budu přičítat
            double nacteno; // připravím proměnnou

            do
            {
                nacteno = double.Parse(Console.ReadLine());
                suma += nacteno; // můžu i pro nulu, nic to nezmění
            }
            while (nacteno != 0); //ukončím při načtení 0

            Console.WriteLine($"Součet zadaných čísel je {suma}");
        }
    }
}

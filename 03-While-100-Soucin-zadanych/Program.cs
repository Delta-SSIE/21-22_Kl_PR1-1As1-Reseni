using System;

namespace _03_While_100_Soucin_zadanych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej čísla, já je budu násobit. Vložením 0 násobení ukončíš");
            
            double soucin = 1; //sem budu dávat součin, začnu s 1, abych jí mohl vynásobit první číslo
            double nacteno = double.Parse(Console.ReadLine()); // připravím proměnnou pro načítání a poprvé ji naplním

            while (nacteno != 0) //ukončím při načtení 0
            {
                soucin *= nacteno; //vynásobím
                nacteno = double.Parse(Console.ReadLine()); // načtu další
            }             

            Console.WriteLine($"Součin zadaných čísel je {soucin}.");
        }
    }
}

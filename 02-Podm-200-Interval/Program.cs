using System;

namespace _02_Podm_200_Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Zadej číslo y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Zadej číslo z, které leží mezi předchozími dvěma: ");
            double z = double.Parse(Console.ReadLine());

            if (x <= y && z < x || y <= x && z < y)
                Console.WriteLine("Zadané číslo je příliš malé.");
            else if ( x <= z && z <= y || y <= z && z <= x)
                Console.WriteLine("Tak je to správně");
            else
                Console.WriteLine("Zadané číslo je příliš velké.");
        }
    }
}

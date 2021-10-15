using System;
using System.Linq;

namespace _02_Podm_290_Nejvetsi_ze_tri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Zadej číslo y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Zadej číslo z: ");
            double z = double.Parse(Console.ReadLine());

            // Příliš komplikované řešení - kolik práce by bylo 
            // rozšířit to na 4 čísla, pět čísel?
            if (x >= y && x >= z)
                Console.WriteLine("Největší je {0}", x);
            else if (y >= x && y >= z)
                Console.WriteLine("Největší je {0}", y);
            else
                Console.WriteLine("Největší je {0}", z);


            double max = x;
            if (y > max)
                max = y;
            if (z > max)
                max = z;

            Console.WriteLine("Největší je {0}", max);

            double[] data = { x, y, z };
            Console.WriteLine(  data.Max()); 

        }
    }
}

using System;

namespace _02_Podm_010_Vyssi_cislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Zadej číslo y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > y)
                Console.WriteLine("Větší je {0}", x);
            else
                Console.WriteLine("Větší je {0}", y);

            // a nebo
            double max = (x > y) ? x : y;
            Console.WriteLine("Větší je {0}", max);
        }
    }
}

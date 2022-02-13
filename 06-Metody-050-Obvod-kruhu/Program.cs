using System;

namespace _06_Metody_050_Obvod_kruhu
{
    class Program
    {
        public static void Main(string[] args)
        {
            double polomer = 3;
            Console.WriteLine($"Obvod kruhu o poloměru {polomer} je {Obvod(polomer)}");
            polomer = 1.5;
            Console.WriteLine($"Obvod kruhu o poloměru {polomer} je {Obvod(polomer)}");
        }

        public static double Obvod(double polomer)
        {
            return 2 * Math.PI * polomer;
        }
    }
}

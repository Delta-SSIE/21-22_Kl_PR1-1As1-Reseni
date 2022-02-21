using System;

namespace _06_Metody_190_Kolik_kbeliku_barvy
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ověřte, že 
            // * pro hodnoty 3, 4, 2.8, 18 bude vráceno 3
            // * pro hodnoty 5, 6, 3.2, 32 bude vráceno 4
            Console.WriteLine(Kbeliky(3, 4, 2.8, 18));
            Console.WriteLine(Kbeliky(5, 6, 3.2, 32));
        }

        public static int Kbeliky(double delka, double sirka, double vyska, double vydatnost)
        {
            double plocha = delka * sirka + 2 * delka * vyska + 2 * sirka * vyska;
            int pocet = (int) Math.Ceiling(plocha / vydatnost);
            return pocet;
        }
    }
}

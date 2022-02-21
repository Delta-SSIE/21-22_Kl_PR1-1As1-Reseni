using System;

namespace _06_Metody_070_Nejvetsi_ze_tri
{
    class Program
    {
        public static void Main(string[] args)
        {
            double cislo1 = 1.3;
            double cislo2 = 4.6;
            double cislo3 = -3.3;
            double maximum = Maximum(cislo1, cislo2, cislo3); //sem doplňte zavolání metody
            Console.WriteLine($"Největší ze zadaných čísel je {maximum}.");
        }
        public static double Maximum(double num1, double num2, double num3)
        {
            double max = num1;
            
            if (num2 > max)
                max = num2;
            if (num3 > max)
                max = num3;

            return max;
        }
    }
}

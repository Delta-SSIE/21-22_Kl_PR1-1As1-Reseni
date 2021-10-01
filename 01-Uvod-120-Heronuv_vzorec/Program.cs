using System;

namespace _120_Heronuv_vzorec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej stranu A: ");
            double stranaA = double.Parse(Console.ReadLine());

            Console.Write("Zadej stranu B: ");
            double stranaB = double.Parse(Console.ReadLine());

            Console.Write("Zadej stranu C: ");
            double stranaC = double.Parse(Console.ReadLine());

            double s = (stranaA + stranaB + stranaC) / 2;
            double obsah = Math.Sqrt(s * (s- stranaA) * (s - stranaB) * (s-stranaC) ) ;

            Console.WriteLine($"Obsah trojúhelníka o stranách {stranaA} , {stranaB} a {stranaC} je {obsah}.");
        }
    }
}

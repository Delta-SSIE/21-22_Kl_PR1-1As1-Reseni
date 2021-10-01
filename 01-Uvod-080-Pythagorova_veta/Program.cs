using System;

namespace _080_Pythagorova_veta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej odvěsnu A: ");
            string zadanoA = Console.ReadLine();
            double odvesnaA = double.Parse(zadanoA);

            Console.Write("Zadej odvěsnu B: ");
            string zadanoB = Console.ReadLine();
            double odvesnaB = double.Parse(zadanoB);

            // odmocninu spočteme jako Math.Sqrt (square root)
            double prepona = Math.Sqrt(odvesnaA * odvesnaA + odvesnaB * odvesnaB);
            
            Console.WriteLine("Délka přepony pravoúhlého trojúhelníka s odvěsnami {0} a {1} je {2}.", odvesnaA, odvesnaB, prepona);
        }
    }
}

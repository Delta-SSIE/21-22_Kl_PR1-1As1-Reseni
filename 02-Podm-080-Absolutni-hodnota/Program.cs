using System;

namespace _02_Podm_080_Absolutni_hodnota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo: ");
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                number = number * -1;
                // což by šlo také zapsat jako 
                // number *= -1; // což znamená vynásob aktuální hodnotu -1
            }

            Console.WriteLine($"Absolutní hodnota vašeho čísla je {number}");
        }
    }
}

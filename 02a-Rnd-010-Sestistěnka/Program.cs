using System;

namespace _02a_Rnd_010_Sestistěnka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int hod = generator.Next(1, 7);
            Console.WriteLine($"Padlo: {hod}");
        }
    }
}

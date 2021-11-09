using System;

namespace _03_While_020_Nacti_zaporne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vlož záporné číslo: ");
            double cislo = double.Parse(Console.ReadLine());

            while (cislo >= 0)
            {
                Console.WriteLine("Řekl jsem záporné! Znova!");
                cislo = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Zadal jsi {0}", cislo);
        }
    }
}

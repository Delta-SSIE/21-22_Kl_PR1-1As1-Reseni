using System;

namespace _02_Podm_020_Kladne_nebo_zaporne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo: ");
            double cislo = double.Parse(Console.ReadLine());

            if (cislo < 0)
                Console.WriteLine("Číslo je záporné");
            else if (cislo == 0)
                Console.WriteLine("Číslo je rovno nule");
            else
                Console.WriteLine("Číslo je kladné");
        }
    }
}

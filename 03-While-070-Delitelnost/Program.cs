using System;

namespace _03_While_070_Delitelnost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jakým číslem se bude dělit: ");
            int delitel = int.Parse(Console.ReadLine());
            int cislo;

            bool poprve = true;
            do
            {
                if (!poprve)
                {
                    Console.WriteLine("To není dělitelné {0}", delitel);
                }
                poprve = false;
                Console.WriteLine("Zadej číslo dělitelné {0}", delitel);
                cislo = int.Parse(Console.ReadLine());
            } while (cislo % delitel != 0);

            Console.WriteLine("{0} / {1} = {2}", cislo, delitel, cislo / delitel);
        }
    }
}

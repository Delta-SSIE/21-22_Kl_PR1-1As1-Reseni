using System;

namespace _05_Pole_090_Najdi_prvek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { -11, 0, 5, -12, 13, 24, 19, 13, -17 };
            
            Console.WriteLine("Jaké číslo hledáš: ");
            int hledane = int.Parse(Console.ReadLine());


            //verze 1

            int pozice = -1;
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] == hledane) //našli jsme
                {
                    pozice = i; //uložíme pozici
                    break;
                }
            }

            if (pozice == -1)
                Console.WriteLine($"Číslo {hledane} se v poli nenachází.");
            else
                Console.WriteLine($"Číslo {hledane} se v poli nachází na indexu {pozice}.");


            //verze 2

            int pozice2 = Array.IndexOf(cisla, hledane);
            if (pozice2 == -1)
                Console.WriteLine($"Číslo {hledane} se v poli nenachází.");
            else
                Console.WriteLine($"Číslo {hledane} se v poli nachází na indexu {pozice2}.");

        }
    }
}

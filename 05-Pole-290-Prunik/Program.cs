using System;
using System.Linq;

namespace _05_Pole_290_Prunik
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole1 = { 1, 3, 24, 7, 0, 14, -3, 8 };
            int[] pole2 = { 24, 6, 12, -1, 1, 8, -4 };

            //projdu celé 1. pole
            for (int i = 0; i < pole1.Length; i++)
            {
                //uložím si aktuální prvek
                int cislo = pole1[i];

                //a budu ho hledat ve 2. poli
                for (int j = 0; j < pole2.Length; j++)
                {
                    //když ho najdu
                    if (pole2[j] == cislo)
                    {
                        //vypíšu ho a skončím prohledávání
                        Console.WriteLine(cislo);
                        break;
                    }
                }
            }

            Console.WriteLine();

            //a nebo s použitím Linq;
            int[] prunik = pole1.Intersect(pole2).ToArray();
            Console.WriteLine(String.Join(", ", prunik));
        }
    }
}

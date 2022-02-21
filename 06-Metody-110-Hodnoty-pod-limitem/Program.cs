using System;
using System.Linq;

namespace _06_Metody_110_Hodnoty_pod_limitem
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] cisla = { -1.3, 2.2, 1.5, 1.4, 2.7 };
            PodLimitem(cisla, 1.5); //vypíše -1.3 a 1.4 
            Console.WriteLine();
            PodLimitemLinq(cisla, 1.6); //vypíše -1.3 , 1.5 a 1.4
        }

        //zde deklarujte vaši metodu
        public static void PodLimitem(double[] cisla, double limit)
        {
            //for (int i = 0; i < cisla.Length; i++)
            //{
            //    if (cisla[i] < limit)
            //        Console.WriteLine(cisla[i]);
            //}

            foreach (double cislo in cisla)
            {
                if (cislo < limit)
                    Console.WriteLine(cislo);
            }

        }
        public static void PodLimitemLinq(double[] cisla, double limit)
        {
            Console.WriteLine(String.Join(";", cisla.Where(x => x < limit)));
        }

    }
}

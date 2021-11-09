using System;

namespace _03_While_010_Mala_nasobilka
{
    class Program
    {
        static void Main(string[] args)
        {
            int zaklad = 7;

            int i = 1;

            while (i < 11)
            {
                int soucin = i * zaklad;
                //Console.WriteLine("{0}x{1}={2}", i, zaklad, soucin);
                //Console.WriteLine(i + "x" + zaklad + "=" + soucin); //je stejne
                Console.WriteLine($"{i}x{zaklad}={soucin}"); //je stejne

                i++;
            }

            
        }
    }
}

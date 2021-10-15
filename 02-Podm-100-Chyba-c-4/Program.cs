using System;

namespace _02_Podm_100_Chyba_c_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napiš číslo: ");
            string nacteno = Console.ReadLine();
            double cislo = double.Parse(nacteno);

            if (cislo < 5)  // chyba byl zde umístěný středník, 
                            // který podmínku ukončil prázdným příkazem a následující 
                            // blok se vykonal vždy
            {
                Console.WriteLine("Číslo je malé");
            }
        }
    }
}

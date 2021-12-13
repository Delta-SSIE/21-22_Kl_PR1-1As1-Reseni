using System;

namespace _04_For_300_Kam_utoci_vez_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kde stojí věž?");
            string odpoved = Console.ReadLine().ToUpper();
            int vezRadek = odpoved[1] - '0';
            char vezSloupec = odpoved[0];

            Console.WriteLine();
            Console.WriteLine("Vež ohrožuje tato pole: ");

            for (int radek = 1; radek < 9; radek++)
            {
                if (radek == vezRadek)
                    continue;

                Console.Write(vezSloupec);
                Console.WriteLine(radek);
            }

            for (char sloupec =  'A'; sloupec < 'I'; sloupec++)
            {
                if (sloupec == vezSloupec)
                    continue;

                Console.Write(sloupec);
                Console.WriteLine(vezRadek);
            }
        }
    }
}

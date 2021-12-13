using System;

namespace _04_For_340_Kam_utoci_strelec_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kde stojí střelec?");
            string odpoved = Console.ReadLine().ToUpper();
            int strelecRadek = odpoved[1] - '0';
            char strelecSloupec = odpoved[0];

            Console.WriteLine();
            Console.WriteLine("Střelec ohrožuje tato pole: ");

            for (int posun = -7; posun < 8; posun++)
            {
                if (posun == 0)
                    continue;

                int radek = strelecRadek + posun;
                char sloupec = (char)(strelecSloupec + posun);

                if (
                    sloupec < 'A'
                    || sloupec > 'H'
                    || radek < 1
                    || radek > 8
                )
                    continue;

                Console.Write(sloupec);
                Console.WriteLine(radek);
            }

            for (int posun = -7; posun < 8; posun++)
            {
                if (posun == 0)
                    continue;

                int radek = strelecRadek - posun;
                char sloupec = (char) (strelecSloupec + posun);

                if (
                    sloupec < 'A'
                    || sloupec > 'H'
                    || radek < 1
                    || radek > 8
                )
                    continue;

                Console.Write(sloupec);
                Console.WriteLine(radek);
            }
        }
    }
}

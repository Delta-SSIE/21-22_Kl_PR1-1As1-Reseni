using System;

namespace _04_For_360_Kam_utoci_dama_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kde stojí dáma?");
            string odpoved = Console.ReadLine().ToUpper();
            int damaRadek = odpoved[1] - '0';
            char damaSloupec = odpoved[0];

            Console.WriteLine();
            Console.WriteLine("Dáma ohrožuje tato pole: ");

            for (int radek = 1; radek < 9; radek++)
            {
                if (radek == damaRadek)
                    continue;

                Console.Write(damaSloupec);
                Console.WriteLine(radek);
            }

            for (char sloupec = 'A'; sloupec < 'I'; sloupec++)
            {
                if (sloupec == damaSloupec)
                    continue;

                Console.Write(sloupec);
                Console.WriteLine(damaRadek);
            }

            for (int posun = -7; posun < 8; posun++)
            {
                if (posun == 0)
                    continue;

                int radek = damaRadek + posun;
                char sloupec = (char)(damaSloupec + posun);

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

                int radek = damaRadek - posun;
                char sloupec = (char)(damaSloupec + posun);

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

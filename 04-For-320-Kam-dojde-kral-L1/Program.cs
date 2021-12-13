using System;

namespace _04_For_320_Kam_dojde_kral_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kde stojí král?");
            string odpoved = Console.ReadLine().ToUpper();
            int kralRadek = odpoved[1] - '0';
            char kralSloupec = odpoved[0];

            Console.WriteLine();
            Console.WriteLine("král může na tato pole: ");

            for (int posunRadek = -1; posunRadek < 2; posunRadek++)
            {
                int radek = kralRadek + posunRadek;
                for (int posunSloupec = -1; posunSloupec < 2; posunSloupec++)
                {
                    char sloupec = (char) (kralSloupec + posunSloupec);

                    if (
                        (sloupec == kralSloupec && radek == kralRadek)
                        || sloupec < 'A'
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
}

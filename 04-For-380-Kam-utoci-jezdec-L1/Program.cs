using System;

namespace _04_For_380_Kam_utoci_jezdec_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pozor - bonusová úloha - používá něco, co jsme neprobírali!
            // Je tu jen jako "ukázka do budoucna"

            Console.WriteLine("Kde stojí jezdec?");
            string odpoved = Console.ReadLine().ToUpper();
            int jezdecRadek = odpoved[1] - '0';
            char jezdecSloupec = odpoved[0];

            int[][] posuny = new int[][]
                {
                    new int[] { -2, -1},
                    new int[] { -2,  1},
                    new int[] { -1, -2},
                    new int[] { -1,  2},
                    new int[] {  1, -2},
                    new int[] {  1,  2},
                    new int[] {  2, -1},
                    new int[] {  2,  1}
                };

            Console.WriteLine();
            Console.WriteLine("Jezdec ohrožuje tato pole: ");

            foreach (int[] posun in posuny)
            {
                if (posun[0] == 0 && posun[1] == 0)
                    continue;

                int radek = jezdecRadek + posun[0];
                char sloupec = (char)(jezdecSloupec + posun[1]);

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

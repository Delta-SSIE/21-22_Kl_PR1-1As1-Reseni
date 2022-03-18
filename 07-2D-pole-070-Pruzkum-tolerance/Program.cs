using System;

namespace _07_2D_pole_070_Pruzkum_tolerance
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] sousedi = { "Mekuřan", "Venušan", "Pozemšťan", "Marťan", "Jupiteřan", "Saturňan", "Uraňan", "Neptuňan" };
            string[] respondenti = { "Alois", "Bedřich", "Cyril", "Dušan", "Emil", "Filip", "Gustav" };

            bool[,] vysledky =
            {
                {  true, false, false, false,  true,  true, true,  true },
                {  true,  true,  true,  true,  true, false, true,  true },
                {  true,  true, false,  true,  true,  true, true, false },
                { false,  true,  true,  true,  true, false, true,  true },
                {  true, false, false,  true, false, false, true, false },
                {  true, false, false,  true,  true, false, true, false },
                {  true, false, false,  true, false, false, true,  true },
            };

            int[] souctySousedu = new int[vysledky.GetLength(1)];
            int[] souctyRespondentu = new int[vysledky.GetLength(0)];

            for (int i = 0; i < vysledky.GetLength(0); i++)
            {
                for (int j = 0; j < vysledky.GetLength(1); j++)
                {
                    if (vysledky[i,j])
                    {
                        souctyRespondentu[i]++;
                        souctySousedu[j]++;
                    }
                }
            }

            int maxSousedu = Maximum(souctySousedu);
            int minSousedu = Minimum(souctySousedu);
            int maxRespondentu = Maximum(souctyRespondentu);
            int minRespondentu = Minimum(souctyRespondentu);

            Console.WriteLine("Oblíbení sousedé:");
            for (int i = 0; i < sousedi.Length; i++)
            {
                if (souctySousedu[i] == maxSousedu)
                    Console.WriteLine(sousedi[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Neoblíbení sousedé:");
            for (int i = 0; i < sousedi.Length; i++)
            {
                if (souctySousedu[i] == minSousedu)
                    Console.WriteLine(sousedi[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Tolerantní respondenti:");
            for (int i = 0; i < respondenti.Length; i++)
            {
                if (souctyRespondentu[i] == maxRespondentu)
                    Console.WriteLine(respondenti[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Netolerantní respondenti:");
            for (int i = 0; i < respondenti.Length; i++)
            {
                if (souctyRespondentu[i] == minRespondentu)
                    Console.WriteLine(respondenti[i]);
            }
            Console.WriteLine();

        }

        static int Maximum(int[] pole)
        {
            int max = pole[0];
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > max)
                    max = pole[i];
            }
            return max;
        }

        static int Minimum(int[] pole)
        {
            int min = pole[0];
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < min)
                    min = pole[i];
            }
            return min;
        }

    }
}

using System;

namespace _07_2D_pole_120_Nahodne_rozmisteni_v_poli
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool[,] mapa = VytvorMapu(8, 12, 30);
            VykresliPole(mapa, '#', ' ');
        }

        static bool[,] VytvorMapu(int vyska, int sirka, int pocetMinci)
        {
            Random rnd = new Random();

            bool[,] mapa = new bool[vyska, sirka];

            int umisteno = 0;

            while (umisteno < pocetMinci)
            {
                int x = rnd.Next(sirka);
                int y = rnd.Next(vyska);
                if (!mapa[y, x])
                { 
                    mapa[y, x] = true;
                    umisteno++;
                }
            }
            return mapa;
        }

        static void VykresliPole(bool[,] mapa, char znakTrue, char znakFalse)
        {
            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    if (mapa[y, x])
                        Console.Write(znakTrue);
                    else
                        Console.Write(znakFalse);
                }
                Console.WriteLine();
            }
        }
    }
}

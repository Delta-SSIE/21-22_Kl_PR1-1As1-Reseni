using System;

namespace _07_2D_pole_110_Mapa_pyramidy
{
    class Program
    {
        static void Main(string[] args)
        {
            VypisPole(Pyramida(8)); //až bude hotovo, odkomentujte
        }

        public static void VypisPole(int[,] pole)
        {
            //do kódu této metody nezasahujte
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static int[,] Pyramida(int vyska)
        {
            int zakladna = 2 * vyska - 1;
            int[,] mapa = new int[zakladna, zakladna];
            int stredX = vyska - 1;
            int stredY = vyska - 1;

            for (int x = 0; x < zakladna; x++)
            {
                for (int y = 0; y < zakladna; y++)
                {
                    //takto spočteme normalni pyramidu

                    int vzdalenostOdStredu = Math.Max(
                        Math.Abs(y - stredY),
                        Math.Abs(x - stredX)
                    );
                    mapa[y, x] = vyska - vzdalenostOdStredu;


                    //takhle uděláme otočenou

                    //int vzdalenostOdStredu = Math.Abs(y - stredY) + Math.Abs(x - stredX);                   
                    //mapa[y, x] = Math.Max(vyska - vzdalenostOdStredu, 0); //kontrola, abych nespadl pod nulu
                }
            }

            return mapa;
        }

        
    }
}

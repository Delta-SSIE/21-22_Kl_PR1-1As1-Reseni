using System;

namespace _07_2D_pole_140_Pocet_sousedu
{
    class Program
    {
        public static void Main(string[] args)
        {

            bool[,] mapa =
            {
            { true,  true,  false, false },
            { false, false, true,  true },
            { false, false, false, true },
            { false, false, true,  true },
        };

            //Console.WriteLine(PocetSousedu(mapa, 0, 0)); //mělo by vypsat 1 - levý horní roh sousedí jen s jednou minou
            //Console.WriteLine(PocetSousedu(mapa, 0, 3)); //mělo by vypsat 0 - levý dolní roh s žádnou minou nesousedí
            Console.WriteLine(PocetSousedu(mapa, 2, 2)); //mělo by vypsat 5

        }

        static int PocetSousedu(bool[,] mapa, int sourX, int sourY)
        {
            int pocet = 0;

            for (int posunX = -1; posunX < 2; posunX++)
            {
                for (int posunY = -1; posunY < 2; posunY++)
                {
                    if (posunX == 0 && posunY == 0)
                        continue;
                    int poziceX = sourX + posunX;
                    int poziceY = sourY + posunY;

                    if (poziceX < 0 || poziceX >= mapa.GetLength(1) || poziceY < 0 || poziceY >= mapa.GetLength(0))
                        continue;

                    if (mapa[poziceY, poziceX])
                        pocet++;
                }
            }

            return pocet;
        }

    }

}

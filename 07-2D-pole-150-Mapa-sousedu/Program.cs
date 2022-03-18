using System;

namespace _07_2D_pole_150_Mapa_sousedu
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool[,] mapa1 =
                {
                { true,  true,  false, false },
                { false, false, true,  true  },
                { false, false, false, true  },
                { false, false, true,  true  },
            };

            VykresliPole(Sousede(mapa1));
            Console.WriteLine();

            bool[,] mapa2 =
                {
                { true,  true,  false, false, true  },
                { false, false, true,  true,  false },
                { false, false, false, true,  false },
            };

            VykresliPole(Sousede(mapa2));
        }

        //sem dejte kód metody Sousede, dle zadání která dostává 2D pole typu bool a vrací 2D pole typu int

        static int[,] Sousede (bool[,] mapa)
        {
            int vyska = mapa.GetLength(0);
            int sirka = mapa.GetLength(1);

            int[,] poleSousedu = new int[vyska, sirka];

            for (int y = 0; y < vyska; y++)
            {
                for (int x = 0; x < sirka; x++)
                {
                    poleSousedu[y, x] = PocetSousedu(mapa, x, y);
                }
            }

            return poleSousedu;

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

        static void VykresliPole(int[,] mapa, int kurzorX = -1, int kurzorY = -1)
        {
            int sirka = mapa.GetLength(1);
            int vyska = mapa.GetLength(0);
            Console.WriteLine(" ╔" + "".PadRight(sirka, '═') + '╗');
            for (int y = 0; y < vyska; y++)
            {
                Console.Write(" ║");
                for (int x = 0; x < sirka; x++)
                {
                    if (x == kurzorX && y == kurzorY)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    
                    Console.Write(mapa[y,x]);
                    
                    if (x == kurzorX && y == kurzorY)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                Console.Write("║");
                Console.WriteLine();
            }
            Console.WriteLine(" ╚" + "".PadRight(sirka, '═') + '╝');
        }

    }
}

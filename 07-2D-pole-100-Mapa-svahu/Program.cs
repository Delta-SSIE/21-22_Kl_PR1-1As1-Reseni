using System;

namespace _07_2D_pole_100_Mapa_svahu
{
    class Program
    {
        static void Main(string[] args)
        {
            Vypis2DPole(Svah(5));
            Console.WriteLine();

            Vypis2DPole(SikmySvah(5));
            Console.WriteLine();

            Console.WriteLine("sever");
            Vypis2DPole(Svah2(5, "sever"));
            Console.WriteLine();

            Console.WriteLine("jih");
            Vypis2DPole(Svah2(5, "jih"));
            Console.WriteLine();

            Console.WriteLine("vychod");
            Vypis2DPole(Svah2(5, "vychod"));
            Console.WriteLine();

            Console.WriteLine("zapad");
            Vypis2DPole(Svah2(5, "zapad"));
            Console.WriteLine();

            foreach (string smer in new string[]{ "sv", "sz", "jv", "jz"})
            {
                Console.WriteLine(smer);
                Vypis2DPole(SikmySvah2(5, smer));
                Console.WriteLine();

            }
        }


        static int[,] Svah(int rozmer)
        {
            int[,] svah = new int[rozmer, rozmer];
            for (int y = 0; y < rozmer; y++)
            {
                for (int x = 0; x < rozmer; x++)
                {
                    svah[y, x] = x;
                }
            }
            return svah;
        }

        static int[,] SikmySvah(int rozmer)
        {
            int[,] svah = new int[rozmer, rozmer];
            for (int y = 0; y < rozmer; y++)
            {
                for (int x = 0; x < rozmer; x++)
                {
                    svah[y, x] = x + y;
                }
            }
            return svah;
        }

        public static void Vypis2DPole(int[,] pole)
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

        static int[,] Svah2(int rozmer, string smer)
        {
            int[,] svah = new int[rozmer, rozmer];
            for (int y = 0; y < rozmer; y++)
            {
                for (int x = 0; x < rozmer; x++)
                {
                    if (smer == "sever")
                    {
                        svah[y, x] = y;
                    }
                    else if (smer == "jih")
                    {
                        svah[y, x] = rozmer - y - 1;
                    }
                    else if (smer == "vychod")
                    {
                        svah[y, x] = rozmer - x - 1;
                    }
                    else if (smer == "zapad")
                    {
                        svah[y, x] = x;
                    }

                }
            }
            return svah;
        }

        static int[,] SikmySvah2(int rozmer, string smer)
        {
            int[,] svah = new int[rozmer, rozmer];
            for (int y = 0; y < rozmer; y++)
            {
                for (int x = 0; x < rozmer; x++)
                {
                    if (smer == "sv")
                    {
                        svah[y, x] = rozmer - x - 1 + y;
                    }
                    else if (smer == "sz")
                    {
                        svah[y, x] = x + y;
                    }
                    else if (smer == "jv")
                    {
                        svah[y, x] = rozmer - x - 1 + rozmer - y - 1;
                    }
                    else if (smer == "jz")
                    {
                        svah[y, x] = x + rozmer - y - 1;
                    }

                }
            }
            return svah;
        }

    }
}

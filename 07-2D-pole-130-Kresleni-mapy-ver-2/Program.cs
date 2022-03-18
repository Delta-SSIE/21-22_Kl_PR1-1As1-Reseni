using System;

namespace _07_2D_pole_130_Kresleni_mapy_ver_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool[,] mapa = VytvorMapu(6, 8, 10);
            VykresliPole(mapa, '#', ' '); // odkomentujte pro krok 1
            VykresliPole2(mapa, 3, 3, '#', ' '); // odkomentujte pro krok 2            
        }
        static bool[,] VytvorMapu(int vyska, int sirka, int pocetMinci)
        {
            Random rnd = new Random();

            bool[,] mapa = new bool[vyska, sirka];
            for (int i = 0; i < pocetMinci; i++)
            {
                int x = rnd.Next(sirka);
                int y = rnd.Next(vyska);
                if (mapa[y, x])
                {
                    i--;
                }
                else
                {
                    mapa[y, x] = true;
                }
            }
            return mapa;
        }

        static void VykresliPole(bool[,] mapa, char znakTrue, char znakFalse)
        {
            int sirka = mapa.GetLength(1);
            int vyska = mapa.GetLength(0);
            Console.WriteLine(" ╔" + "".PadRight(sirka, '═') + '╗');
            for (int y = 0; y < vyska; y++)
            {
                Console.Write(" ║");
                for (int x = 0; x < sirka; x++)
                {
                    if (mapa[y, x])
                        Console.Write(znakTrue);
                    else
                        Console.Write(znakFalse);
                }
                Console.Write("║");
                Console.WriteLine();
            }
            Console.WriteLine(" ╚" + "".PadRight(sirka, '═') + '╝');
        }

        static void VykresliPole2(bool[,] mapa, int kurzorX = -1, int kurzorY = -1, char znakTrue = '#', char znakFalse = ' ')
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
                    if (mapa[y, x])
                        Console.Write(znakTrue);
                    else
                        Console.Write(znakFalse);
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

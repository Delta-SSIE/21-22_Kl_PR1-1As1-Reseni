using System;

namespace _04_For_310_Kam_utoci_vez_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kde stojí věž?");
            string odpoved = Console.ReadLine().ToUpper();
            int vezRadek = odpoved[1] - '0';
            char vezSloupec = odpoved[0];

            for (int radek = 8; radek > 0; radek--)
            {
                bool pristiPoleBile = radek % 2 == 0;

                for (char sloupec = 'A'; sloupec < 'I'; sloupec++)
                {

                    if (pristiPoleBile)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }

                    if (sloupec == vezSloupec && radek == vezRadek)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (sloupec == vezSloupec || radek == vezRadek)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }


                    Console.Write(sloupec);
                    Console.Write(radek);
                    Console.Write(" ");

                    pristiPoleBile = !pristiPoleBile;
                }
                Console.WriteLine();
            }
        }
    }
}

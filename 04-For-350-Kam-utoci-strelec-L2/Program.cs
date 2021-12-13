using System;

namespace _04_For_350_Kam_utoci_strelec_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kde stojí střelec?");
            string odpoved = Console.ReadLine().ToUpper();
            int strelecRadek = odpoved[1] - '0';
            char strelecSloupec = odpoved[0];

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

                    int posunSloupec = sloupec - strelecSloupec;
                    int posunRadek = radek - strelecRadek;

                    if (sloupec == strelecSloupec && radek == strelecRadek)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if ( Math.Abs(posunSloupec) == Math.Abs(posunRadek))
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

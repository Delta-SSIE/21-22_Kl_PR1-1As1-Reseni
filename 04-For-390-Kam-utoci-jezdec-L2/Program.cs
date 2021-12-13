using System;

namespace _04_For_390_Kam_utoci_jezdec_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Kde stojí jezdec?");
                string odpoved = Console.ReadLine().ToUpper();
                int jezdecRadek = odpoved[1] - '0';
                char jezdecSloupec = odpoved[0];

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

                        int posunSloupec = sloupec - jezdecSloupec;
                        int posunRadek = radek - jezdecRadek;

                        if (sloupec == jezdecSloupec && radek == jezdecRadek)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else if (
                            Math.Abs(posunSloupec) == 2 && Math.Abs(posunRadek) == 1
                            || Math.Abs(posunSloupec) == 1 && Math.Abs(posunRadek) == 2
                        )
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
}

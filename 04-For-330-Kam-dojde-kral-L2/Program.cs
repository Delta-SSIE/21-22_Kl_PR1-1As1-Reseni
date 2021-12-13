using System;

namespace _04_For_330_Kam_dojde_kral_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kde stojí král?");
            string odpoved = Console.ReadLine().ToUpper();
            int kralRadek = odpoved[1] - '0';
            char kralSloupec = odpoved[0];

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

                    if (sloupec == kralSloupec && radek == kralRadek)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (
                        Math.Abs(sloupec - kralSloupec) <= 1
                        && Math.Abs(radek - kralRadek) <= 1
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

using System;

namespace _04_For_370_Kam_utoci_dama_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kde stojí dáma?");
            string odpoved = Console.ReadLine().ToUpper();
            int damaRadek = odpoved[1] - '0';
            char damaSloupec = odpoved[0];

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

                    int posunSloupec = sloupec - damaSloupec;
                    int posunRadek = radek - damaRadek;

                    if (sloupec == damaSloupec && radek == damaRadek)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (
                        sloupec == damaSloupec // na stejném sloupci
                        || radek == damaRadek  // na stejném řádku
                        || Math.Abs(posunSloupec) == Math.Abs(posunRadek) // na stejné diagonále
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

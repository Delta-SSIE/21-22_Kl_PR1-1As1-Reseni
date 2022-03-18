using System;

namespace _07_2D_pole_010_Dve_diagonaly
{
    class Program
    {
        public static void Main(string[] args)
        {
            // zde vytvořte proměnnou typu 2D pole řetězců o rozměrech 5 x 5 prvků
            // promennou nazvete diagonaly
            // uložt do všechn prvků pole mezery, jen do diagonál vložte #
            // je mnoho způsobů, jak to provést, vyberte si ten svůj

            string[,] diagonaly =
{
                { "#", " ", " ", " ", "#" },
                { " ", "#", " ", "#", " "},
                { " ", " ", "#", " ", " "},
                { " ", "#", " ", "#", " "},
                { "#", " ", " ", " ", "#" }
            };

            //zde pole vypíšeme - vypisovací metoda už je připravena
            Vypis2DPole(diagonaly);

        }
        public static void Vypis2DPole(string[,] pole)
        {
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}

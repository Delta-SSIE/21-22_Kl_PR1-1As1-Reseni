using System;

namespace _05_Pole_210_Histogram_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hodnoty = { 100, 300, 200, 400, 700, 1200, 400 };
            
            //int delkaRadky = 76;
            
            //v C# lze zjistit aktuální šířku okna konzole tímto způsobem
            int delkaRadky = Console.WindowWidth - 4; 
            //těch - 4 odpovídá úvodním znakům, které vypíšeme na začátek každé řádky


            //Zjistím největší číslo
            int max = 0;
            for (int i = 0; i < hodnoty.Length; i++)
            {
                if (hodnoty[i] > max)
                { 
                    max = hodnoty[i];
                }
            }
            //v proměnné max je teď maximum z pole hodnoty


            for (int i = 0; i < hodnoty.Length; i++)
            {
                //záhlaví řádku
                Console.Write($"{i}: ");

                //Počet symbolů vezmu jako aktuální číslo v poli, ale vydělím max číslem 
                //(to by dalo desetinné číslo mezi 0 a 1) a vynásobím délkou řádky.
                //Říká se tomu normování.
                int pocetSymbolu = hodnoty[i] * delkaRadky / max;

                for (int j = 0; j < pocetSymbolu; j++)
                {
                    Console.Write("#");
                }

                //a odřádkujeme
                Console.WriteLine();
            }
        }
    }
}

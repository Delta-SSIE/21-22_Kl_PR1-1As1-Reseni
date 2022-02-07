using System;

namespace _05_Pole_080_Teploty
{
    class Program
    {
        static void Main(string[] args)
        {
            //V poli jsou uloženy teploty z měření na digitálním teploměru.
            //Měření začalo v 5:30 a pokračovalo každou půlhodinu. Vypište hodnoty 
            //i s časem pod sebe (jakoby do tabulky).

            double[] teploty = { 13.7, 14.2, 14.3, 14.8, 15.2, 16.0, 16.3, 17.1 };

            //verze 1
            int hodiny = 5;
            int minuty = 30;

            Console.WriteLine(" čas  | teplota");
            
            for (int i = 0; i < teploty.Length; i++)
            {
                Console.WriteLine($"{hodiny:00}:{minuty:00} | {teploty[i]:0.0} °C");
                minuty += 30;
                if (minuty > 59) {
                    hodiny += 1;
                    minuty -= 60;
                }
            }

            Console.WriteLine();

            //verze 2
            int minutes = 5 * 60 + 30;
            Console.WriteLine(" čas  | teplota");

            for (int i = 0; i < teploty.Length; i++)
            {
                Console.WriteLine($"{minutes / 60:00}:{minutes % 60:00} | {teploty[i]:0.0} °C");
                minutes += 30;
            }

        }
    }
}

using System;

namespace _04_For_190_Vynechte_mezery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který vynechá ze zadaného řetězce všechny mezery. Ostatní znaky vypíše.
            //Výstupem na obrazovce by tedy mělo být Totojevelicedlouhávěta, kdobysejiobtěžovalčíst.
            //Nápověda: Mezera se dá buď porovnávat přímo, ale pozor, char se píše do jednoduchých 
            //uvozovek ' ', nebo lze využít fakt, že char má v ASCII tabulce hodnotu 32.

            string text = "Toto je velice dlouhá věta, kdoby se ji obtěžoval číst.";

            //níže přijde váš kód
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                    Console.Write(text[i]);
            }
        }
    }
}

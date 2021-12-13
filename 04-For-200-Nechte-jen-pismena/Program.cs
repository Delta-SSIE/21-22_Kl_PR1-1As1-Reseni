using System;

namespace _04_For_200_Nechte_jen_pismena
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který vynechá ze zadaného řetězce všechny znaky kromě písmen anglické abecedy.
            //Odkaz na ASCII tabulku ukáže, že velká písmena mají kódy 65 - 90 a malá 97 - 122.

            string text = "Jean-Luc, you should inform no. 1 and then go and see what happened at 8:30PM!";

            //níže přijde váš kód
            //z původní věty by mělo zbýt
            //"JeanLucyoushouldinformnoandthengoandseewhathappenedatPM"
            string novyText = "";

            for (int i = 0; i < text.Length; i++)
            {
                //int kodZnaku = text[i]; //získám kód znaku prostě tím, že jej uložím do datového typu int
                //if ( ( kodZnaku > 64 && kodZnaku < 91 ) || (kodZnaku > 96 && kodZnaku < 123)) //ověřím, že je to písmeno
                if ((text[i] >= 'A' && text[i] <= 'Z') || (text[i] >= 'a' && text[i] <= 'z')) //nebo přímo
                {
                    novyText += text[i];
                }
            }

            Console.WriteLine(novyText);
        }
    }
}

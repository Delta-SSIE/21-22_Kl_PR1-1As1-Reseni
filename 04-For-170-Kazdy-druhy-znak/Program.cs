using System;

namespace _04_For_170_Kazdy_druhy_znak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který vypíše z předpřipravené proměnné text 
            //každý druhý znak (myšleno první , třetí, pátý… Vypisovat se tedy
            //bude index 0, index 2 index 4 atd. )
            string text = "zadřeš on i co onsemnaí";

            //níže přijde váš kód
            for (int i = 0; i < text.Length; i+=2)
            {
                Console.Write(text[i]);
            }

            Console.WriteLine();
        }
    }
}

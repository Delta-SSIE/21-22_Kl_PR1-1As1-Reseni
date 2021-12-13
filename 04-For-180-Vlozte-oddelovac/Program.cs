using System;

namespace _04_For_180_Vlozte_oddelovac
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který přepíše předpřipravenou proměnnou text do 
            //proměnné novyText tak, že za každý znak vloží symbol lomítka.
            //tedy "Popokatepetl" => "P/o/p/o/k/a/t/e/p/e/t/l/";

            string text = "Popokatepetl";
            string novyText;

            //níže přijde váš kód

            novyText = "";
            for (int i = 0; i < text.Length; i++)
            {
                novyText += text[i];
                if (i != text.Length - 1) 
                    novyText += "/"; //pokud jsem na poslední pozici, oddělovač nepřidám
            }

            Console.WriteLine(novyText);
        }
    }
}

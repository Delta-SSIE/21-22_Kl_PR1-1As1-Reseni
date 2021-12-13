using System;

namespace _04_For_160_Obraceny_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Kobyla má malý bok.";
            string novyText = "";

            //řádek níže je jediný, který budete měnit
            for (int i = text.Length - 1; i >=0; i--) // vysvětlení je stejné jako v předchozím případě
            {
                novyText += text[i]; //vezmu znak na pozici i a přidám k existujícím
            }

            Console.WriteLine(novyText);
        }
    }
}

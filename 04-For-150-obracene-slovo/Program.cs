using System;

namespace _04_For_150_Obracene_slovo
{
    class Program
    {
        static void Main(string[] args)
        {
            string slovo = "pihovatý";

            //řádek níže je jediný, který budete měnit
            for (int i = slovo.Length - 1; i >= 0; i--)
                //začínám posledním znakem i = slovo.Length - 1, 
                //tedy u řetězce délky 6 je počáteční pozice 5, protože poslední bude 0
                //v každém průchodu pozici o 1 snížím a pracuji, dokud neklesnu pod nulu
            {
                Console.WriteLine(slovo[i]);
            }
        }
    }
}

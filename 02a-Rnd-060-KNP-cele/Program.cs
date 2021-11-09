using System;

namespace _02a_Rnd_060_KNP_cele
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            while (true)
            {
                int cislo = generator.Next(0, 3);

                string figuraPC = "";
                switch (cislo)
                {
                    case 0:
                        figuraPC = "kámen";
                        break;
                    case 1:
                        figuraPC = "nůžky";
                        break;
                    case 2:
                        figuraPC = "papír";
                        break;
                }

                Console.Write("Vyber figuru (k/n/p): ");
                string nacteno = Console.ReadLine();
                string figuraHrac;
                switch (nacteno)
                {
                    case "k":
                        figuraHrac = "kámen";
                        break;
                    case "n":
                        figuraHrac = "nůžky";
                        break;
                    case "p":
                        figuraHrac = "papír";
                        break;
                    default:
                        figuraHrac = "";
                        break;
                }
                if (figuraHrac == "")
                { 
                    Console.WriteLine("Chybné zadání");
                    return;
                }

                if (figuraHrac == figuraPC)
                {
                    Console.WriteLine($"Remíza ({figuraPC}:{figuraHrac})");
                }
                else if (
                    (figuraHrac == "kámen" && figuraPC == "nůžky")
                    || (figuraHrac == "nůžky" && figuraPC == "papír")
                    || (figuraHrac == "papír" && figuraPC == "kámen")
                    )
                {
                    Console.WriteLine($"Vyhrál jsi ({figuraPC}:{figuraHrac})");
                }
                else
                {
                    Console.WriteLine($"Vyhrál jsem ({figuraPC}:{figuraHrac})");
                }
            }
        }
    }
}

using System;

namespace _050_Obsah_ctverce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej délku strany čtverce: "); // Vypíšu výzvu
            string zadano = Console.ReadLine(); // Načtu, co uživatel zadal. Bude to řetězec (mohou to být také nesmysly, nejen číslo)
            double strana = double.Parse(zadano); // Pokusím se převést na desetinné číslo a uložím do proměnné strana
            double obsah = strana * strana; // Vypočítám obsah čtverce
            Console.WriteLine("Obsah čtverce o straně " + strana + " je " + obsah + ".");
        }
    }
}

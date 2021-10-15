using System;

namespace _02a_Rnd_020_Hra_v_kostky
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int hodPC = generator.Next(1, 7);

            Console.WriteLine("Hoď si (stiskni ENTER)");
            Console.ReadLine();

            int hodHrac = generator.Next(1, 7);

            string report;
            if (hodHrac > hodPC)
                report = "Vyhrál jsi";
            else if (hodHrac == hodPC)
                report = "Remíza";
            else
                report = "Prohrál jsi";

            Console.WriteLine($"{hodPC}:{hodHrac} ({report})");
        }
    }
}

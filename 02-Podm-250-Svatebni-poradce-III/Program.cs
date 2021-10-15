using System;

namespace _02_Podm_250_Svatebni_poradce_III
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nastavte si proměnné
            bool jeStary = true;
            bool jeHezky = true;
            bool jeChudy = true;

            // tuto podmínku je třeba doplnit
            if ( jeHezky || (jeStary && !jeChudy) )
            // zde končí úpravy
            {
                Console.WriteLine("Vezmi si ho!");
            }
            else
            {
                Console.WriteLine("Toho si neber!");
            }
        }
    }
}

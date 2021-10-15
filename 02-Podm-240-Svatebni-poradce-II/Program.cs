using System;

namespace _02_Podm_240_Svatebni_poradce_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nastavte si proměnné
            bool jeMlady = false;
            bool jeHezky = false;
            bool jeBohaty = true;

            // tuto podmínku je třeba doplnit
            // if (!(jeHezky || (!jeMlady && jeBohaty))) //lze i takto
            if (!jeHezky && (jeMlady || !jeBohaty)) //nebo takto
            // zde končí úpravy
            {
                Console.WriteLine("Toho si neber!");
            }
            else
            {
                Console.WriteLine("Vezmi si ho!");
            }
        }
    }
}

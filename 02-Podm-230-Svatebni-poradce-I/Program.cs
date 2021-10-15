using System;

namespace _02_Podm_230_Svatebni_poradce_I
{
    class Program
    {
        static void Main(string[] args)
        {

            // Nastavte si proměnné
            bool jeMlady = true;
            bool jeHezky = true;
            bool jeBohaty = true;

            // tuto podmínku je třeba doplnit
            if (jeHezky || (!jeMlady && jeBohaty))           
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

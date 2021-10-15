using System;

namespace _02_Podm_140_Chyba_c_5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Nastavíme proměnnou
            bool mamHlad = true;


            // A teď ji otestujeme
            // if (mamHlad = false) // chyba je v jednoduchem rovnitku zde. Chceme porovnat, ne přiřadit
            // if (mamHlad == false) // opravit by šlo takhle
            if (!mamHlad) // takto je to nejčistší
            {
                Console.WriteLine("Nežer, ztloustneš!");
            }
            else
            {
                Console.WriteLine("Je čas se najíst.");
            }
        }
    }
}

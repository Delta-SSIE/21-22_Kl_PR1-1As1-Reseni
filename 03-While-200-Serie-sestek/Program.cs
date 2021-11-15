using System;

namespace _03_While_200_Serie_sestek
{
    class Program
    {
        static void Main(string[] args)
        {
            // generator nahodnych cisel
            Random rnd = new Random();
            // pocet pokusu
            int opakovani = 1000000;

            // aktualni delka sekvence = 0
            int sekvence = 0;

            // nejdelsi sekvence = 0
            int nejdelsi = 0;

            int krok = 0;
            // udelame pokus-krat
            while (krok < opakovani)
            {
                krok++;
                // hodim si
                int hod = rnd.Next(1, 7);


                if (hod == 6)
                {
                    // kdyz je sestka - zvysim si delku aktualni sekvence o 1
                    sekvence++;

                    //Console.Write(hod);
                    //Console.Write(" ");

                    // pokud je aktualni sekvence delsi nez maximum, ulozim nove maximum
                    if (sekvence > nejdelsi)
                        nejdelsi = sekvence;
                } 
                else
                {
                    // kdyz neni sestka
                    // aktualni delka sekvence se resetuje
                    if (sekvence != 0)
                    {
                        //Console.WriteLine();
                        sekvence = 0;
                    }
                }
            }

            Console.WriteLine($"Nejdelší sekvence šestek byla dlouhá {nejdelsi}.");
        }
    }
}

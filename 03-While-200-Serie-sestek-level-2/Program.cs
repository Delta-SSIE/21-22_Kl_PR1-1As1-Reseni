using System;

namespace _03_While_200_Serie_sestek_level_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pozadovanaDelka = 8;

            // generator nahodnych cisel
            Random rnd = new Random();

            // aktualni delka sekvence = 0
            int sekvence = 0;

            int krok = 0;
            // udelame pokus-krat
            while (sekvence < pozadovanaDelka)
            {
                krok++;
                // hodim si
                int hod = rnd.Next(1, 7);

                if (hod == 6)
                {
                    // kdyz je sestka - zvysim si delku aktualni sekvence o 1
                    sekvence++;
                }
                else
                {
                    // kdyz neni sestka
                    // aktualni delka sekvence se resetuje
                    if (sekvence != 0)
                    {
                        sekvence = 0;
                    }
                }
            }

            Console.WriteLine($"Na sekvenci šestek délky {pozadovanaDelka} jsem musel čekat {krok} hodů.");
        }
    }
}

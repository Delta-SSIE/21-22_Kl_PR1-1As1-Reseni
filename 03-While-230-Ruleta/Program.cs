using System;

namespace _03_While_230_Ruleta
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int celkem = 0;
            int uvodniSazka = 11;
            int sazka = 0;
            int padlo;
            int kolo = 0;

            do
            {
                kolo++;

                if (kolo == 1)
                    sazka = uvodniSazka;
                else
                    sazka *= 2; //v dalších kolech dvojnásobím

                celkem += sazka;

                padlo = random.Next(0, 36);

                Console.WriteLine($"{kolo}. kolo: Sázím {sazka}$ na liché, celkem vsazeno {celkem}$. Padlo {padlo}.");

            }
            while (padlo % 2 == 0);

            Console.WriteLine($"Vyhrávám {2 * sazka}$.");

            Console.WriteLine($"K zisku {uvodniSazka}$ bylo třeba vsadit {celkem}$ a hra trvala {kolo} kola.");
        }


    }
}

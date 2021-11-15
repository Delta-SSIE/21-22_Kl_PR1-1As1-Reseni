using System;

namespace _03_While_220_Kamen_Nuzky_Papir
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //generátor náhodných čísel

            //připravím "počítadla"
            int kolo = 0;
            int skoreHrac = 0;
            int skorePC = 0;

            //tento řetězec budu plnit při dotazu na konec hry
            string hratDalsi;

            do
            {
                kolo++; //zvýším kolo o 1

                //vypíšu informace
                Console.WriteLine();
                Console.WriteLine($"{kolo}. kolo: ");
                Console.WriteLine();

                string figuraHrac;
                do
                {
                    //vyzvu hráče k zadání
                    Console.Write("Zvol figuru (k/n/p): ");
                    //převedu na malé písmeno (pro jistotu - nevím, zda dal velké nebo malé)
                    figuraHrac = Console.ReadLine().ToLower();
                }
                while (figuraHrac != "k" && figuraHrac != "n" && figuraHrac != "p");
                //pokud nezadal něco smysluplného, budu načítat znovu

                //vymyslím náhodné číslo v rozmezí 1-3
                int kodFiguryPC = rnd.Next(0, 3);
                //převedu na kód figury jako má hráč
                string figuraPC = (kodFiguryPC == 0) ? "k" :
                                    (kodFiguryPC == 1) ? "n" :
                                    "p";
                //zde by šlo použít if, switch, … , tento ternární operátor není nutný

                //rozhodnu o vítězi a vypíšu
                if (figuraHrac == figuraPC)
                {
                    Console.WriteLine($"Remíza ({figuraHrac}:{figuraPC})");
                }
                else if (
                    (figuraHrac == "k" && figuraPC == "n") ||
                    (figuraHrac == "n" && figuraPC == "p") ||
                    (figuraHrac == "p" && figuraPC == "k")
                )
                {
                    Console.WriteLine($"Vyhrál jsi ({figuraHrac}:{figuraPC})");
                    skoreHrac++;
                }
                else
                {
                    Console.WriteLine($"Vyhrál jsem ({figuraHrac}:{figuraPC})");
                    skorePC++;
                }

                //podám informaci o stavu
                Console.WriteLine($"Průběžné skore Hráč: {skoreHrac} - PC: {skorePC}");

                //zjistím, zda chce skončit
                do
                {
                    Console.Write("Chceš hrát další kolo? (a/n): ");
                    hratDalsi = Console.ReadLine().ToLower();
                }
                while (hratDalsi != "a" && hratDalsi != "n");
                //při neplatné odpovědi se ptám znovu

            }
            while (hratDalsi == "a");
            //dokud chce hrát další, opakuji


            //vypíšu závěrečné informace
            Console.WriteLine();
            Console.WriteLine($"Závěřečné skore po {kolo} kolech - Hráč: {skoreHrac} - PC: {skorePC}");

        }
    }
}

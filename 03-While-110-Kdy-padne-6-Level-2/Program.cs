using System;

namespace _03_While_110_Kdy_padne_6_Level_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //generrátor náhodných čísel
            Console.Write("Kolikrát mám zkusit čekat na šestku: ");

            int kolikrat = int.Parse(Console.ReadLine()); // kdy mám skončit

            int opakovani = 0; //pokolikáté čekám na šestku
            int pocetHoduCelkem = 0; // kolik hodů jsem udělal celkem
            int cislo; //připravená proměnná pro uložení čísla
            int maxDelka = 0; // jak nejdele mi to trvalo

            while (opakovani < kolikrat) { //dokud si házím méně, než je konečná, budu provádět

                int pocetHodu = 0; // kolikrát jsem musel hodit - zatím ani jednou, proto 0

                do
                {
                    cislo = rnd.Next(1, 7); // hoď si mezi 1 a 6
                                            // pozor, zde nelze napsat int cislo - nebylo by přístupné v podmínce, 
                                            // proměnná vždy patří jen mezi složené závorky, mezi kterými byla deklarována, 
                                            // ven se nedostane

                    pocetHodu++; //zvyš počet hodů
                }
                while (cislo < 6); //dokud nepadne šestka

                pocetHoduCelkem += pocetHodu; //připočtu aktuální hody k celkovému počtu
                maxDelka = Math.Max(maxDelka, pocetHodu); // uložím si jako max čekání větší z dvojice 
                                                          // "původní max čekání" a "čekání teď"
                opakovani++; // zvýší si počítadlo opakování

            }

            Console.WriteLine("Bylo průměrně třeba {0} hodů k hození šestky.", (double) pocetHoduCelkem / opakovani);
            Console.WriteLine("Nejdéle bylo třeba hodit {0}-krát", maxDelka);

        }
    }
}

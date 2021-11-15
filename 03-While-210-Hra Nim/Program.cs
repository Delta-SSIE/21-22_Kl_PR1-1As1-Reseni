using System;

namespace _03_While_210_Hra_Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Na stole leží 21 zápalek.Hru hrají dva hráči a každém tahu může hráč odebrat ze společné hromádky 1 až 3 zápalky. Vítězem je ten, kdo vezme poslední.

            //Napište program, který vždy hráčům oznámí, kolik zápalek leží na stole a vyzve je, aby 1 - 3 odebrali.Poté vyhodnotí, zda příslušný hráč vyhrál, nebo bude následovat další kolo.

            //Nezapomeňte kontrolovat neplatné hodnoty vstupu
            //  příliš velká čísla
            //  příliš malá čísla
            //  čísla vedoucí k zápornému počtu sirek.

            //Vypisujte, zda je na tahu hráč 1 nebo 2

            //nastavíme hromádku
            int sirky = 21;

            //ukazatel hráče
            int hrac = 2; //v prvním cyklu se číslo automaticky přehodí na hráče 1

            //dokud je co odebírat
            while (sirky > 0)
            {
                //změníme číslo hráče
                if (hrac == 1)
                {
                    hrac = 2;
                }
                else
                {
                    hrac = 1;
                }

                //popiseme situaci
                string vyzva = $"Na stole je {sirky} zapalek, kolik bere hráč {hrac}: ";
                //dáme výzvu
                Console.Write(vyzva);

                //načteme, zkontrolujeme a kdyžtak vyzveme znovu
                int odebrano;
                while (!int.TryParse(Console.ReadLine(), out odebrano) || odebrano < 1 || odebrano > 3 || odebrano > sirky)
                {
                    Console.WriteLine("To nelze, musíš zvolit číslo 1 - 3 takové, aby na stole nezbyl záporný počet sirek.");
                    Console.Write(vyzva);
                }

                //odebereme z hromádky
                sirky -= odebrano;

            }

            //okomentujeme stav
            Console.WriteLine($"Vítězí hráč {hrac}.");
        }
    }
}

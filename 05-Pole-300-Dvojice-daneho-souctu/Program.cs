using System;

namespace _05_Pole_300_Dvojice_daneho_souctu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pole cisla obsahuje řadu čísel.Vyberte a vypište z nich pomocí 
            //programu ty dvojice, které mají zadný součet. Pokud je dvojic 
            //se stejným součtem více, vypište všechny.

            int[] cisla = { -6, 10, -7, -2, -14, 11, 9 };
            int soucet = 4;

            Console.WriteLine("Hledané dvojice jsou");

            //projdu všechna čísla pole
            for (int i = 0; i < cisla.Length; i++)
            {
                int cislo = cisla[i]; //zapamatuju si číslo
                int hledane = soucet - cislo; //zjistím, kolik chybí do součtu - to hledám

                //projdu zbytek pole (předchozí čísla už jsem procházel), začnu tedy j = na i + 1
                for (int j = i + 1; j < cisla.Length; j++)
                {
                    //když najdu
                    if (cisla[j] == hledane)
                    {                        
                        Console.WriteLine($"{cislo}, {hledane}"); //vypíšu
                        break;//a skončím hledání
                    }
                }
            }
        }
    }
}

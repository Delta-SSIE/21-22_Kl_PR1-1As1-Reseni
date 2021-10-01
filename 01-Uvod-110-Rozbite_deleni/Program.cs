using System;

namespace _110_Rozbite_deleni
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problém je v použití datového typu int - celých čísel.
            // Při celočíselném dělení bude posíl 32 / 3 vypočten jako 10
            // Opravíme použitím datového typu double

            //int citatel = 32;
            //int jmenovatel = 3;
            double citatel = 32;
            double jmenovatel = 3;

            // Zde začíná záhada

            //int podil = citatel / jmenovatel;
            //int vysledekZpatky = podil * jmenovatel;
            double podil = citatel / jmenovatel;
            double vysledekZpatky = podil * jmenovatel;

            // Zde záhada končí

            Console.WriteLine($"{citatel} / {jmenovatel} * {jmenovatel} = {vysledekZpatky}");


        }
    }
}

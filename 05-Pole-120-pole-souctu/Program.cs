using System;
using System.Linq;

namespace _05_Pole_120_pole_souctu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 20, 11, 0, 10, 7, 12, 83, 0, 0, 15 };


            /* Standardní způsob průchodem pole */

            int[] soucty = new int[cisla.Length]; //vytvořím pro součty pole stejně dlouhé

            int suma = 0; //sem si budu součet průběžně ukládat

            for (int i = 0; i < cisla.Length; i++) //projdu celé původní pole
            {
                suma += cisla[i]; //přičtu k součtu aktuální číslo
                soucty[i] = suma; //součet uložím na pozici i do součtového pole
            }

            // a už jen výpis
            for (int i = 0; i < soucty.Length; i++)
            {
                Console.WriteLine($"{i} : {cisla[i]} : {soucty[i]}");
            }

            Console.WriteLine();

            /* Nepovinný způsob - LINQ */

            // Pozor, tento způsob je pomalejší, než první, protože se pokaždé počítá od začátku.
            // U malých polí by se to neprojevilo, ale velká pole, nebo opakované operace by 
            // ukázala výkonový rozdíl.
            int[] soucty2 = cisla.Select((cislo, index) => cisla[0..(index+1)].Sum()).ToArray();

            // a znovu už jen výpis
            for (int i = 0; i < soucty.Length; i++) //výpis
            {
                Console.WriteLine($"{i} : {cisla[i]} : {soucty2[i]}");
            }
        }
    }
}

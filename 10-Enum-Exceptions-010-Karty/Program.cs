using System;

namespace _10_Enum_Exceptions_010_Karty
{
    enum Karta : byte { Sedma = 7, Osma, Devitka, Desitka, Spodek, Svrsek, Filek = Svrsek, Kral, ESO };
    class Program
    {
        static void Main(string[] args)
        {
            Karta karta = Karta.Kral;
            Console.WriteLine(karta);
            karta++;
            Console.WriteLine(karta);

            Console.WriteLine(KdoJeVyssi(Karta.Sedma, Karta.ESO));
        }

        static String KdoJeVyssi(Karta karta1, Karta karta2)
        {
            if (karta1 == karta2)
                return "Mají stejnou hodnotu";
            else if (karta1 > karta2)
                return "Karta1 má vyšší hodnotu než Karta2 (" + karta1 + " > " + karta2 + ").";
            else
                return "Karta2 má vyšší hodnotu než Karta1 (" + karta1 + " < " + karta2 + ").";
        }
    }
}

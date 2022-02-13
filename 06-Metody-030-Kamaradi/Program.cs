using System;

namespace _06_Metody_030_Kamaradi
{
    class Program
    {
        // Vytvořte metodu s názvem Kamaradi, která bude přijímat dva parametry
        //(argumenty), kterým budou řetězce nazvané kamarad1 a kamarad2.

        //Metoda při předání jmen, např. "Karel" a "Anička" vypíše do konzole tento text
        //Moji kamarádi jsou Karel a Anička.

        //Tentokrát už musíte tělo metody zapsat sami, zavolání je připraveno.
        public static void Main(string[] args)
        {
            Kamaradi("Anička", "Karel");
        }

        public static void Kamaradi(string jmeno1, string jmeno2)
        {
            Console.WriteLine($"Moji kamarádi jsou {jmeno1} a {jmeno2}.");
        }
    }
}

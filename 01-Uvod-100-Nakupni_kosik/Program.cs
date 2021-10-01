using System;

namespace _100_Nakupni_kosik
{
    class Program
    {
        static void Main(string[] args)
        {
            string zbozi1 = "Vejce";
            double cena1 = 3.5;

            string zbozi2 = "Rohlík";
            double cena2 = 1.9;

            string zbozi3 = "Chleba";
            double cena3 = 25;

            // Sem přijde váš kód

            Console.Write("{0} ({1} Kč): Kolik kusů chcete? ", zbozi1, cena1); // Vypíšu formátovanou výzvu
            int pocet1 = int.Parse(Console.ReadLine()); // Načtu odpověď a převedu na celé číslo

            Console.Write("{0} ({1} Kč): Kolik kusů chcete? ", zbozi2, cena2); // Vypíšu formátovanou výzvu
            int pocet2 = int.Parse(Console.ReadLine()); // Načtu odpověď a převedu na celé číslo

            Console.Write("{0} ({1} Kč): Kolik kusů chcete? ", zbozi3, cena3); // Vypíšu formátovanou výzvu
            int pocet3 = int.Parse(Console.ReadLine()); // Načtu odpověď a převedu na celé číslo

            double cena = cena1 * pocet1 + cena2 * pocet2 + cena3 * pocet3;

            Console.WriteLine("Celkový nákup bude stát {0} Kč.", cena);

            // Konec prostoru pro kód
        }
    }
}

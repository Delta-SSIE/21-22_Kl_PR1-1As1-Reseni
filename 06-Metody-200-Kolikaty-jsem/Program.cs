using System;

namespace _06_Metody_200_Kolikaty_jsem
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] test = { 12, 15, 11, 4, 11, 13, 12 };
            Console.WriteLine(Kolikaty(test, 2)); //vypíše 5 - na pozici 2 je 11 bodů
            Console.WriteLine(Kolikaty(test, 4)); //vypíše 5 - také je tam 11
            Console.WriteLine(Kolikaty(test, 1)); //vypíše 1 - to je nejvyšší skore
            Console.WriteLine(Kolikaty(test, 7)); //vypíše 0 - zadání nemá smysl pole má jen 7 prvků
            Console.WriteLine(Kolikaty(test, -1)); //vypíše 0 - zadání nemá smysl
        }

        public static int Kolikaty(int[] vysledky, int index)
        {
            if (index < 0 || index >= vysledky.Length)
                return 0;
            
            int skore = vysledky[index];
            
            int poradi = 1;
            for (int i = 0; i < vysledky.Length; i++)
            {
                if (vysledky[i] > skore)
                    poradi++;
            }

            return poradi;
        }
    }
}

using System;

namespace _05_Pole_310_Soucet_nejbliz_nule
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pole cisla obsahuje řadu čísel.Vyberte a vypište z nich pomocí 
            //programu tu dvojici, která má součet nejblíže nule.Pokud je 
            //dvojic se stejným součtem více, stačí první z nich.
            
            int[] cisla = { -6, 10, -7, -2, -14, 11, 9 };

            int minVzdalenost = int.MaxValue;
            int cislo1 = 0;
            int cislo2 = 0;

            for (int i = 0; i < cisla.Length; i++)
            {
                for (int j = i + 1; j < cisla.Length; j++)
                {
                    int vzdalenost = Math.Abs(cisla[i] + cisla[j]);

                    if (vzdalenost < minVzdalenost)
                    {
                        minVzdalenost = vzdalenost;
                        cislo1 = cisla[i];
                        cislo2 = cisla[j];
                    }
                }
            }

            Console.WriteLine($"Hledaná dvojice je {cislo1} a {cislo2}");
        }
    }
}

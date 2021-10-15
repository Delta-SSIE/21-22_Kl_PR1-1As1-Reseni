using System;

namespace _02_Podm_120_Znamkovac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik procent získal žák: ");
            double skore = double.Parse(Console.ReadLine());

            if (skore < 0 || skore > 100)
            {
                Console.WriteLine("Výsledek {0}% neumím vyhodnotit.", skore);
            }
            else
            {
                int znamka;
                string slovo;

                if (skore < 33)
                {
                    znamka = 5;
                    slovo = "nedostatečně";
                } 
                else if (skore < 50)
                {
                    znamka = 4;
                    slovo = "dostatečně";
                }
                else if (skore < 67)
                {
                    znamka = 3;
                    slovo = "dobře";
                }
                else if (skore < 83)
                {
                    znamka = 2;
                    slovo = "chvalitebně";
                }
                else
                {
                    znamka = 1;
                    slovo = "výborně";
                }

                Console.WriteLine($"Za {skore} % mu náleží známka {znamka} ({slovo}).");
            }
        }
    }
}

using System;

namespace _07_2D_pole_090_Tabulka_vzdalenosti
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapa mapa = new Mapa();
            string[] mesta = mapa.Rejstrik;

            //Console.WriteLine(String.Join(", ", mesta));

            //double vzdalenost12 = mapa.Vzdalenost(1, 3);

            //Console.WriteLine($"Vzdálenost {mesta[1]} a {mesta[2]} je {vzdalenost12} km");

            int[,] vzdalenosti = new int[mesta.Length, mesta.Length];

            for (int i = 0; i < mesta.Length; i++)
            {
                for (int j = 0; j < mesta.Length; j++)
                {
                    vzdalenosti[i, j] = (int) Math.Round(mapa.Vzdalenost(i, j));
                }
            }

            VypisTabulku(mesta, vzdalenosti);
        }

        static void VypisTabulku(string[] mesta, int[,]vzdalenosti)
        {
            int[] delky = new int[mesta.Length];
            int maxDelka = 0;
            
            for (int i = 0; i < mesta.Length; i++)
            {
                int delka = mesta[i].Length;
                delky[i] = delka;
                if (maxDelka < delka)
                    maxDelka = delka;
            }

            Console.Write("".PadLeft(maxDelka) + "  ");

            Console.WriteLine(String.Join(" ", mesta));
            for (int i = 0; i < mesta.Length; i++)
            {
                Console.Write(mesta[i].PadLeft(maxDelka) + " ");
                for (int j = 0; j < mesta.Length; j++)
                {
                    Console.Write(vzdalenosti[i,j].ToString().PadLeft(delky[j] + 1, ' ') );
                }
                Console.WriteLine();
            }
        }

    }
}

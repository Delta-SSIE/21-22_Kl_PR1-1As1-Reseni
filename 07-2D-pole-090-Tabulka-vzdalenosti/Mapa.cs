using System;
using System.Collections.Generic;
using System.Text;

namespace _07_2D_pole_090_Tabulka_vzdalenosti
{
    class Mapa
    {
        Dictionary<int, int[]> mesta;
        string[] rejstrik = new string[] { "Aš", "Beroun", "Cvikov", "Dačice", "Evín", "Frýdek", "Goldov" };

        public Mapa()
        {
            mesta = new Dictionary<int, int[]>();
            mesta[0] = new int[] { 0, 0, 0 };
            mesta[1] = new int[] { 3, -4, 1 };
            mesta[2] = new int[] { -5, -3, -1 };
            mesta[3] = new int[] { -2, 5, 4 };
            mesta[4] = new int[] { -1, -4, -1 };
            mesta[5] = new int[] { 4, -4, 1 };
            mesta[6] = new int[] { 2, 1, -2 };
        }

        public string[] Rejstrik
        {
            get
            {
                return (string[])rejstrik.Clone();
            }
        }

        public double Vzdalenost(int mestoA, int mestoB)
        {
            int[] souradniceA = mesta[mestoA];
            int[] souradniceB = mesta[mestoB];
            return Math.Round(Math.Pow(
                    Math.Pow(souradniceA[0] - souradniceB[0], 4) +
                    Math.Pow(souradniceA[1] - souradniceB[1], 4) +
                    Math.Pow(souradniceA[2] - souradniceB[2], 4)
                ,
                1d / 4) * 100
                ) / 10;
        }
    }
}

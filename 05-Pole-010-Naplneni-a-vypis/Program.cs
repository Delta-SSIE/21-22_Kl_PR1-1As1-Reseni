using System;

namespace _05_Pole_010_Naplneni_a_vypis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadání: Deklarujte pole smery, ve kterém budou
            //řetězcové hodnoty "sever", "jih", "východ" a "západ".

            //klasicky takto
            string[] smery = new string[4];
            smery[0] = "sever";
            smery[1] = "jih";
            smery[2] = "východ";
            smery[3] = "západ";

            //nebo přímou deklarací buďto s typem
            string[] smery2 = { "sever", "jih", "východ", "západ" };

            //či bez něj
            string[] smery3 = new string[] { "sever", "jih", "východ", "západ" };

            //Zadání: Pak vypište pod sebe pomocí cyklu všechny cesty takto:

            //     Můžeš jít na sever.
            //     Můžeš jít na jih.
            //     Můžeš jít na východ.
            //     Můžeš jít na západ.

            for (int i = 0; i < smery.Length; i++)
            {
                Console.WriteLine($"Můžeš jít na {smery[i]}.");
            }
        }
    }
}

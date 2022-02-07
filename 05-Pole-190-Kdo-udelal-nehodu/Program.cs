using System;

namespace _05_Pole_190_Kdo_udelal_nehodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jizdy = {
                247,
                135,
                15,
                23,
                428,
                63,
                26,
                7
            };

            string[] ridici = {
                "Petr",
                "Pavel",
                "Jaroslav",
                "Pavel",
                "Jaroslav",
                "Petr",
                "Pavel",
                "Petr"
            };


            int prestupek = 401;
            string ridic = "";

            //budeme si počítat, kolik kdo ujel
            int ujeto = 0;
            for (int i = 0; i < jizdy.Length; i++)
            {
                //připočítám, kolik ujel aktuální řidič
                ujeto += jizdy[i];

                //pokud se dostal za hranici přestupku
                if (ujeto > prestupek)
                {
                    //zapamatuji si ho
                    ridic = ridici[i];
                    //a skončím
                    break;
                }
            }

            if (ridic == "")
            {
                Console.WriteLine("Přestupek nastal až po skončení knihy jízd.");
            }
            else
            {
                Console.WriteLine($"Přestupek má na svědomí {ridic}.");
            }
        }
    }
}

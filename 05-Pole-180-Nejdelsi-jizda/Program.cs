using System;

namespace _05_Pole_180_Nejdelsi_jizda
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

            //najdeme maximum v jízdách a zapamatujeme si, který index ho ujel
            int max = 0;
            int maxIndex = -1;

            for (int i = 0; i < jizdy.Length; i++)
            {
                //když najdu větší než zapamatované číslo
                if (jizdy[i] > max)
                {
                    max = jizdy[i]; //zapamatuju si nové maximum
                    maxIndex = i; //a také to, kde jsem ho našel
                }
            }

            Console.WriteLine($"Nejdelší jízdu vykonal {ridici[maxIndex]}.");
        }
    }
}

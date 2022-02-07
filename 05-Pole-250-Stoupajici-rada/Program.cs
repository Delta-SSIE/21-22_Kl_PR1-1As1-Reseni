using System;

namespace _05_Pole_250_Stoupajici_rada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který z pole cisla vypíše sekvenci stoupajících čísel -
            //tedy začne od prvního a vždycky pokud by další číslo bylo nižší či
            //stejné jako poslední vypsané, bude přeskočeno.

            int[] cisla = { -6, -7, -1, 3, 0, 1, 3, 5, 9, 8, 10 };

            int max = cisla[0] - 1; //začnu na čísle menším, než je první, aby se první vypsalo
                                    //také bych mohl začít s int.MinValue

            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] > max)
                {
                    max = cisla[i];
                    Console.WriteLine(max);
                }

            }

        }
    }
}

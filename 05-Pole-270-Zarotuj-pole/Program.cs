using System;

namespace _05_Pole_270_Zarotuj_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Level 1
            //Napište progam, který posune celé pole o 1 prvek vpřed 
            //a první prvek umístí na konec, např. tedy z pole
            //int[] cisla = { -6, -7, -1, 3, 0, 1, 5, 9, 8, 10 };
            //vytvoří pole
            //{ -7, -1, 3, 0, 1, 5, 9, 8, 10, -6 };

            int[] cisla = { -6, -7, -1, 3, 0, 1, 5, 9, 8, 10 };
            int naKonec = cisla[0]; //zapamatuju si první
            for (int i = 1; i < cisla.Length; i++) //pozor, začínám od 1
            {
                cisla[i - 1] = cisla[i]; // umístím dopředu
            }
            cisla[cisla.Length - 1] = naKonec; //dám původně první číslo na konec

            Console.WriteLine(String.Join(", ", cisla)); //vypíšu
        }
    }
}

using System;

namespace _02_Podm_310_Serazeni_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {

            // toto je alespoň nějaké řešení, i tak by se ale rozšiřovalo špatně
            // na třízení většího počtu prvků budeme muset jít jinak, s pomocí cyklů

            Console.Write("Zadej 1. číslo: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Zadej 2. číslo: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Zadej 3. číslo: ");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Zadej 4. číslo: ");
            int D = int.Parse(Console.ReadLine());

            int tmp;

            if (A > B)
            {
                tmp = B;
                B = A;
                A = tmp;
            }

            if (A > C)
            {
                tmp = C;
                C = B;
                B = A;
                A = tmp;
            }
            else if (B > C)
            {
                tmp = C;
                C = B;
                B = tmp;
            }

            if (A > D)
            {
                tmp = D;
                D = C;
                C = B;
                B = A;
                A = tmp;
            }
            else if (B > D)
            {
                tmp = D;
                D = C;
                C = B;
                B = tmp;
            }
            else if (C > D)
            {
                tmp = D;
                D = C;
                C = tmp;
            }

            Console.WriteLine($"Seřazená čísla: {A}, {B}, {C}, {D}.");
        }
    }
}

using System;

namespace _02_Podm_270_Prijmout_kandidata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej procenta úspěšnosti z matematiky: ");
            double matematika = double.Parse(Console.ReadLine());
            Console.Write("Zadej procenta úspěšnosti z fyziky: ");
            double fyzika = double.Parse(Console.ReadLine());
            Console.Write("Zadej procenta úspěšnosti z chemie: ");
            double chemie = double.Parse(Console.ReadLine());

            if (
                   matematika + fyzika >= 140
                || matematika + chemie >= 140
                || 
                (
                       matematika >= 65
                    && fyzika >= 55
                    && chemie >= 50
                    && matematika + fyzika + chemie >= 180
                )
            )
                Console.WriteLine("Přijmout.");
            else
                Console.WriteLine("Nepřijmout.");


            // Pro lepší čistelnost lze také
            bool mPlus1Staci = matematika + fyzika >= 140 || matematika + chemie >= 140;
            bool jednotliveDost = matematika >= 65 & fyzika >= 55 && chemie >= 50;
            bool celkemDost = matematika + fyzika + chemie >= 180;
            
            if (mPlus1Staci || jednotliveDost && celkemDost)
                Console.WriteLine("Přijmout.");
            else
                Console.WriteLine("Nepřijmout.");

        }
    }
}

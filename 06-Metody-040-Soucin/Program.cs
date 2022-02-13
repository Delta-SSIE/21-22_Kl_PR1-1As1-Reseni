using System;

namespace _06_Metody_040_Soucin
{
    class Program
    {
        //Vytvořte metodu s názvem Soucin, která bude přijímat dva parametry 
        //(argumenty), kterým budou desetinná čísla nazvaná cislo1 a cislo2.
        //Metoda při předání dvou čísel vrátí jejich součin a nebude nic vypisovat.
        //Tělo metody musíte zapsat sami, zavolání je připraveno, do něj nezasahujte.
        public static void Main(string[] args)
        {
            double num1 = 5.5;
            double num2 = 3.3;
            double vysledek = Soucin(num1, num2);
            Console.WriteLine($"Součin čísel {num1} a {num2} je {vysledek}.");

            num1 = 0;
            num2 = 6.2;
            vysledek = Soucin(num1, num2);
            Console.WriteLine($"Součin čísel {num1} a {num2} je {vysledek}.");

        }
        public static double Soucin(double num1, double num2)
        {
            //double vysledek = num1 * num2;
            //return vysledek;
            return vysledek = num1 * num2;
        }

    }
}

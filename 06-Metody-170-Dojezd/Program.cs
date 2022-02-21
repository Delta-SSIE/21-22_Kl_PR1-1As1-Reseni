using System;

namespace _06_Metody_170_Dojezd
{
    class Program
    {
        public static void Main(string[] args)
        {
            double nadrz = 52;
            double spotreba = 7.2;

            Console.WriteLine(
                "Automobil s {0} litry benzínu a spotřebou {1} dojede nejvýše {2:0.0} kilometrů.",
                nadrz,
                spotreba,
                Dojezd(nadrz, spotreba)
            );
            //mělo by vypsat "Automobil s 52 litry benzínu a spotřebou 7.2 dojede nejvýše 722.2 kilometrů."
        }
        public static double Dojezd(double nadrz, double spotreba)
        {
            return nadrz / spotreba * 100;
        }

    }
}

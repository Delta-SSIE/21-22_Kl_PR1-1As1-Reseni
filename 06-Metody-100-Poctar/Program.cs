using System;

namespace _06_Metody_100_Poctar
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Poctar(1, -7.5, "+")); // -6.5
            Console.WriteLine(Poctar(-2, -4, "-")); // 2
            Console.WriteLine(Poctar(1, 5, "*")); // 5
            Console.WriteLine(Poctar(8, 3, "/")); // 2.666666667
            Console.WriteLine(Poctar(8, 3, "%")); // 2
            Console.WriteLine(Poctar(8, 3, "^"));
        }

        public static double Poctar(double cislo1, double cislo2, string operace)
        {
            switch (operace)
            {
                case "+": return cislo1 + cislo2;
                case "-": return cislo1 - cislo2;
                case "*": return cislo1 * cislo2;
                case "/": return cislo1 / cislo2;
                case "%": return cislo1 % cislo2;
                case "^": return Math.Pow(cislo1, cislo2);
                default: return 0;
            }

        }
    }
}
}

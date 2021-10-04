using System;

namespace _02_podm_040_Suda_nebo_licha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo: ");
            int number = int.Parse(Console.ReadLine());
            //int proto, že u desetinných nedává smysl bavit se o sudé a liché

            if (number % 2 == 0)
                Console.WriteLine("Číslo {0} je sudé.", number);
            else
                Console.WriteLine("Číslo {0} je liché.", number);

            // a nebo
            Console.WriteLine("Číslo {0} je {1}", number, number %2 == 0 ? "sudé" : "liché" );
        }
    }
}

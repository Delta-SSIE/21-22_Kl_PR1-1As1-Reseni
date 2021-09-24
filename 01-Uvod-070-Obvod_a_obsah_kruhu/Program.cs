using System;

namespace _070_Obvod_a_obsah_kruhu
{
    class Program
    {
        static void Main(string[] args)
        {
            // načtení je stejné jako v předchozích případech
            Console.Write("Zadej poloměr kružnice: ");
            string nacteno = Console.ReadLine();
            double polomer = double.Parse(nacteno);


            double obvod = 2 * Math.PI * polomer; // číslo π je uloženo ve jmenném prostoru Math jako Math.PI
            double obsah = Math.PI * polomer * polomer;

            Console.WriteLine("Kruh o poloměru {0} má obvod {1} a obsah {2}.", polomer, obvod, obsah);
        }
    }
}

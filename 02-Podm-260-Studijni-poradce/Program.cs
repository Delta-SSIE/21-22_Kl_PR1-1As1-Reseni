using System;

namespace _02_Podm_260_Studijni_poradce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej procenta úspěšnosti z matematického testu: ");
            double matematika = double.Parse(Console.ReadLine());
            Console.Write("Zadej procenta úspěšnosti z jazykového testu: ");
            double jazyk = double.Parse(Console.ReadLine());

            if (matematika <= 66 || jazyk <= 66)
                Console.WriteLine("Doporučuje se vyučit řemeslo.");
            else if (matematika >= jazyk)
                Console.WriteLine("Doporučuje se studovat technický obor.");
            else
                Console.WriteLine("Doporučuje se studovat humanitní obor.");
        }
    }
}

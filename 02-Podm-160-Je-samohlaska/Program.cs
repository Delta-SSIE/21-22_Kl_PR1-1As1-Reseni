using System;

namespace _02_Podm_160_Je_samohlaska
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Stiskni klávesu: ");
            char znak = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Sem přijde váš kód

            if (znak == 'a' || znak == 'e' || znak == 'i' || znak == 'o' || znak == 'u' || znak == 'y')
                Console.WriteLine($"{znak} je samohláska");
            else
                Console.WriteLine($"{znak} není samohláska");

            // a nebo
            switch (znak)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    Console.WriteLine($"{znak} je samohláska");
                    break;
                default:
                    Console.WriteLine($"{znak} není samohláska");
                    break;
            }

            // Konec vašeho kódu
        }
    }
}

using System;

namespace _05_Pole_220_Pravdepodobnost_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;

            Random rnd = new Random();

            int[] pocty = new int[6]; //potřebuju šest políček na "čárky", které si budu dělat

            for (int i = 0; i < n; i++)
            {
                //hodím si 1 - 6
                int cislo = rnd.Next(1, 7);
                
                //a udělám u příslušného čísla čárku - ale v poli mám indexy 0 - 5, proto o 1 zmenším
                pocty[cislo - 1]++;
            }

            for (int i = 0; i < pocty.Length; i++)
            {
                Console.WriteLine($"{i+1}: {(double) pocty[i] / n}"); //pozor na přetypování z INTu, jinak samé nuly
            }

        }
    }
}

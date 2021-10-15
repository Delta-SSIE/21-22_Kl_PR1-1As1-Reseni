using System;

namespace _02a_Rnd_030_Ruznostenka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik stěn má kostka: ");
            int steny = int.Parse(Console.ReadLine());
            
            Random generator = new Random();
            int hod1 = generator.Next(1, steny + 1);
            int hod2 = generator.Next(1, steny + 1);
            int hod3 = generator.Next(1, steny + 1);

            Console.WriteLine("{0}, {1}, {2}", hod1, hod2, hod3);

            Console.WriteLine("Průměr je {0}", (hod1 + hod2 + hod3) / 3d); 
            //3d znamená "chápej jako desetinné"

        }
    }
}

using System;

namespace _03_While_195_Zebriky_a_hadi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int tah = 0;
            int pozice = 1;

            Console.WriteLine($"Start: Pozice {pozice}");

            do
            {
                tah++;
                int hod = rnd.Next(1, 7);
                pozice += hod;

                pozice = Math.Min(pozice, 100);

                Console.WriteLine($"Tah: {tah}, Hod {hod}, Pozice {pozice}");

                if (pozice % 11 == 0)
                {
                    pozice += 10;
                    Console.WriteLine($"+ Žebřík: Pozice {pozice}");
                }
                else if (pozice % 13 == 0)
                {
                    pozice -= 12;
                    Console.WriteLine($"- Had: Pozice {pozice}");
                }
            }
            while (pozice < 100);

            Console.WriteLine($"Konec ve {tah}. tahu");
        }
    }
}

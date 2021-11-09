using System;

namespace _02a_Rnd_040_KNP_uvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int cislo = generator.Next(0, 3);
            
            string figura = "";
            switch (cislo)
            {
                case 0:
                    figura = "kámen";
                    break;
                case 1:
                    figura = "nůžky";
                    break;
                case 2:
                    figura = "papír";
                    break;
            }

            Console.WriteLine("Dávám {0}", figura);
        }
    }
}

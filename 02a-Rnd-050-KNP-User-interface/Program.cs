using System;

namespace _02a_Rnd_050_KNP_User_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyber figuru (k/n/p): ");
            string nacteno = Console.ReadLine();
            string figura = "";
            switch (nacteno)
            {
                case "k":
                    figura = "kámen";
                    break;
                case "n":
                    figura = "nůžky";
                    break;
                case "p":
                    figura = "papír";
                    break;
            }
            if (figura != "")
                Console.WriteLine("Dáváš {0}", figura);
            else
                Console.WriteLine("Chybné zadání");

        }
    }
}

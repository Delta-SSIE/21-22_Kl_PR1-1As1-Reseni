using System;

namespace _06_Metody_020_Kdo_prijde_II
{
    class Program
    {
        public static void Main(string[] args)
        {
            string slovo = "polivka";
            int pocet = 3;


            //Console.WriteLine("Účet: {0} - {1:00.0}x", slovo, pocet);
            //Console.WriteLine($"Účet: {slovo} - {pocet}x");

            string text = Prijde("Karel"); //zde uložím návratovou hodnotu do proměnné
            Console.WriteLine(text);
        }
        public static string Prijde(string jmeno)
        {
            //return $"Přijde také {jmeno}.";
            return String.Format("Přijde také {0}.", jmeno);
        }
    }
}

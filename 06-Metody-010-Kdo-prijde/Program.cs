using System;

namespace _06_Metody_010_Kdo_prijde
{
    class Program
    {
        public static void Main(string[] args)
        {
            Prijde("Karel");
        }
        public static void Prijde(string jmeno)
        {
            Console.WriteLine($"Přijde také {jmeno}.");
        }
    }
}

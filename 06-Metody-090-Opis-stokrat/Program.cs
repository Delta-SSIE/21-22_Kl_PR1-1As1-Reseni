using System;

namespace _06_Metody_090_Opis_stokrat
{
    class Program
    {
        static void Main(string[] args)
        {
            OpisNKrat("Nebudu paní školnici krást šňůru na prádlo a vázat ji kočce na ocas.", 35);
        }

        public static void OpisNKrat(string veta, int pocet)
        {
            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine(veta);
            }
        }
    }
}

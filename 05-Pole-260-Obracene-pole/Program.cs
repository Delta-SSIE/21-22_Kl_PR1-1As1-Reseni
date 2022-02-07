using System;
using System.Linq;

namespace _05_Pole_260_Obracene_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který naplní pole obracene hodnotami z pole 
            //cisla v obráceném pořadí.

            int[] cisla = { 4, 17, -6, 14, 23, -1, 9 };
            int[] obracene = new int[cisla.Length];

            for (int i = 0; i < cisla.Length; i++)
            {
                int protiIndex = obracene.Length - 1 - i; // k prvnímu číslu patří poslední, k druhému předposlední…
                obracene[protiIndex] = cisla[i];
            }

            for (int i = 0; i < obracene.Length; i++)
            {
                Console.WriteLine(obracene[i]);
            }

            Console.WriteLine();
            //a nebo by stačilo s použitím System.Linq
            int[] obracene2 = cisla.Reverse().ToArray();

            for (int i = 0; i < obracene2.Length; i++)
            {
                Console.WriteLine(obracene2[i]);
            }
        }
    }
}

using System;
using System.Linq;

namespace _05_Pole_160_Druha_pismena
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Statný valach ojnici zničil. Révou zhrdla žena ostrovana Claudia Pompeia. Ozvučení hnědé místnosti okamžitě zvýraznit! Běžný statkář to zvládne. Japonec Anihito rád označoval čárami. Asi sto pět kravských žaludků";

            //vytvoříme pole slov tak, že původní text necháme rozdělit mezerami
            string[] slova = text.Split(" ");

            //projdeme pole slov
            for (int i = 0; i < slova.Length; i++)
            {
                string slovo = slova[i];
                //z každého slova vypíšeme druhé písmeno, to je na pozici 1
                Console.Write(slovo[1]);
            }

            Console.WriteLine();
            Console.WriteLine();

            //jiné řešení pomocí LINQ
            Console.WriteLine(String.Join("", text.Split(" ").Select(x => x[1]).ToArray()));
            
        }
    }
}

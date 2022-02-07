using System;

namespace _05_Pole_030_Chyba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prisady = { "kokos", "povidla", "tvaroh", "ořechy", "mák" };

            //chyba byla v rovnítku zde navíc - i  začíná nulo, musí proto být menší než délka pole
            for (int i = 0; i < prisady.Length; i++) 
            {
                Console.WriteLine("Na pečení se hodí také {0}.", prisady[i]);
            }
        }
    }
}

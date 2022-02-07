using System;

namespace _05_Pole_050_Chyba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarace pole našich nejvyšších hor - tu neměňte
            string[] hory = {
                            "Sněžka",
                            "Luční hora",
                            "Studniční hora",
                            "Vysoké kolo",
                            "Praděd",
                            "Stříbrný hřbet",
                            "Vysoká pláň",
                            "Violík",
                            "Vysoká hole",
                            "Petrovy kameny"
                        };

            Console.WriteLine("Seznam 10 nejvyšších hor ve vzestupném pořadí:");

            //odsud níže je třeba opravovat
            for (int i = hory.Length; i > 0; i--)
            {
                //Console.WriteLine("{0}. nejvyšší je {1}", i, hory[i]); //chybu opravíme tak, že budeme brát i o 1 menší
                Console.WriteLine("{0}. nejvyšší je {1}", i, hory[i - 1]);
            }


            Console.WriteLine();

            //nebo
            //změníme meze ve výpisu
            for (int i = hory.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}. nejvyšší je {1}", i + 1, hory[i]);
            }

        }
    }
}

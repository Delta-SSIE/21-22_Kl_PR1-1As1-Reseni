using System;
using System.Security.Cryptography;

namespace _03_While_190_Hadej_kolik_myslim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který si vymyslí náhodné číslo mezi 1 a 100 a pak se bude ptát hráče na jeho odhad.
            //Podle odhadu oznámí, zda má hráč přidat, ubrat nebo uhodl.

            //vytvoř náhodné číslo
            Random rnd = new Random();
            int hledane = rnd.Next(1, 101);

            int kolo = 0;
            Console.WriteLine("Tipuj mezi 1 a 100.");

            int nejblizsiNizsiTip = 0;
            int nejblizsiVyssiTip = 101;

            //dokud neuhodl
            while (true)
            {
                kolo++;
                //zeptat se na číslo
                Console.Write($"{kolo}. kolo - tvůj tip: ");
                
                int tip;
                while (!int.TryParse(Console.ReadLine(), out tip) || tip < 1 || tip > 100)
                {
                    Console.WriteLine("Zadej skutečné celé číslo mezi 1 a 100");
                }

                //porovnat a poradit
                if (tip > hledane)
                {
                    Console.WriteLine("To je moc.");
                    if (tip >= nejblizsiVyssiTip)
                    {
                        Console.WriteLine($"A přemýšlej u toho, už víš, že i {nejblizsiVyssiTip} je moc!");
                    }
                    else
                    {
                        nejblizsiVyssiTip = tip;
                    }
                }
                else if (tip < hledane)
                {
                    Console.WriteLine("To je málo.");
                    if (tip <= nejblizsiNizsiTip)
                    {
                        Console.WriteLine($"A přemýšlej u toho, už víš, že i {nejblizsiNizsiTip} je málo!");
                    }
                    else
                    {
                        nejblizsiNizsiTip = tip;
                    }
                }
                else
                {
                    break;
                }

            }

            //pogratulovat
            Console.WriteLine($"To je ono, myslel jsem si {hledane}, uhodl jsi v {kolo} kole.");

            //Level 1.5
            //vypisujte, kolikáté kolo hráč hraje a v kolikátém uhodl

            //Level 2
            //pokud hráč hraje nelogicky, program ho pokárá
        }
    }
}

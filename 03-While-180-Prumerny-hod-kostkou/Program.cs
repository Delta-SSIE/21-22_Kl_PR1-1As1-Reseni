using System;

namespace _03_While_180_Prumerny_hod_kostkou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolikrát si mám hodit: ");
            int kolikrat;

            // opakuj dokud se nepovede načíst a parsovat celé číslo a toto číslo není větší než 1
            while (!int.TryParse(Console.ReadLine(), out kolikrat) || kolikrat < 1)
            {
                Console.Write("Vlož celé kladné číslo: ");
            }


            Console.Write("Kolik má kostka stěn: ");
            int steny;
            while (!int.TryParse(Console.ReadLine(), out steny) || steny < 1)
            {
                Console.Write("Vlož celé kladné číslo: ");
            }

            
            int suma = 0;
            int pokus = 0;
            Random rnd = new Random();

            // opakuju daný počet pokusů
            while(pokus < kolikrat)
            {
                pokus++; //zvyšuju počitadlo
                int hod = rnd.Next(1, steny + 1); //znovu si házím
                suma += hod; //přidávám do součtu
            }

            //průměr musí být destinné číslo, nezapomenu přetypovat sumu na desetinné,
            //jinak by došlo k celočíselnému dělení
            double prumer = ((double)suma) / kolikrat;

            Console.WriteLine("Průměrná hodnota jednoho hodu je {0}.", prumer);

        }
    }
}

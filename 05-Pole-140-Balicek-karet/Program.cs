using System;

namespace _05_Pole_140_Balicek_karet
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vytvořte pole o 32 prvcích - balíček karet.Půjde o pole řetězců ve tvaru "Kule - Sedma", "Žaludy - Eso" atd.

            //Balíček nevytvářejte ručně, ale použijte dvě jiná pole - jedno s barvami, druhé s výškami, které budete procházet, kombinovat a ukládat do třetího pole. 
            //Nápověda: potřebujete dva vnořené for-cykly.Aktuální index, kam se má ukládat, si pak vždy vypočítáte z obou iteračních proměnných těch vnořených for-cyklů, nebo si uděláte průběžné počitadlo.

            string[] barvy = { "srdce", "žaludy", "listy", "kule" };
            string[] vysky = { "sedma", "osma", "devvítka", "desítka", "spodek", "svršek", "král", "eso" };

            string[] balicek = new string[barvy.Length * vysky.Length]; 
            //v balíčku bude třeba mít místo pro 4 * 8 = 32 karet
            //kdybychom ale dělali jiné karty, bude tento zápis obecnější

            for (int i = 0; i < barvy.Length; i++)
            {
                for (int j = 0; j < vysky.Length; j++)
                {
                    int index = i * vysky.Length + j; //obvykle třeba 3 * 8 + 1
                    balicek[index] = barvy[i] + " " + vysky[j];
                }
            }


            //Potom celý balíček vypište.
            for (int i = 0; i < balicek.Length; i++)
            {
                Console.WriteLine(balicek[i]);
            }

            //teď vybereme náhodnou kartu
            Random rnd = new Random();
            Console.WriteLine();
            Console.Write("Náhodná karta: ");
            Console.WriteLine(balicek[rnd.Next(0, balicek.Length)]); //promyslete si že délka balíčku je přesně správný horní mez pro random
        }
    }
}

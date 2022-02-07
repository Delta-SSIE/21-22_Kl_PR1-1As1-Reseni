using System;

namespace _05_Pole_240_Pravdepodobnost_3__Bonus_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 500000;
            int k = 4;
            int pocetSten = 6;

            int delkaRadky = 65;

            //v C# lze zjistit aktuální šířku okna konzole tímto způsobem
            //int delkaRadky = Console.WindowWidth - 15; 
            //těch - 15 odpovídá úvodním znakům, které vypíšeme na začátek každé řádky

            int minSoucet = k;
            int maxSoucet = k * pocetSten;

            Random rnd = new Random();

            //vytvořím počítadlo, kolikrát nám vyšel ten který součet
            //nejvyšší index je roven maxmiálnímu možnému součtu
            int[] pocty = new int[maxSoucet + 1];
            //prvních k indexů nebudu používat, tam zbudou nuly 
            //- takové číslo nemůže padnout, třeba při třech hodech kostkou 
            //nepadne součet 0, 1 a 2


            //Takto bych počítadlo vynuloval - v C# není nutné
            //for (int i = 0; i < pocty.Length; i++)
            //{
            //    pocty[i] = 0;
            //}

            //n pokusů o hod
            for (int i = 0; i < n; i++)
            {
                //sečtu k-hodů kostkami
                int soucetHodu = 0; //začnu na nule

                for (int j = 0; j < k; j++)
                {
                    //jeden hod naší kostkou přidám k aktuálnímu součtu
                    soucetHodu += rnd.Next(1, pocetSten + 1);
                }

                pocty[soucetHodu]++;//po doběhnutí "si udělám čárku" v počítadle u součtu, který nám vyšel
            }            
            //Teď jsou v poli pocty skutečné počty, kolikrát co padlo


            //Zjistím největší dosažený počet
            int maxPocet = 0;
            for (int i = minSoucet; i < pocty.Length; i++)
            {
                if (pocty[i] > maxPocet)
                    maxPocet = pocty[i];
            }
            
            //Projdu pole od nejmenší možné hodnoty a budu ho vypisovat
            for (int i = minSoucet; i < pocty.Length; i++)
            {
                double pravdepodobnost = ((double) pocty[i]) / n; //pozor - double, jinak celočíselné dělení
                Console.Write($"{i:00}: ({pravdepodobnost:0.0000}): "); //záhlaví řádky

                int pocetSymbolu = pocty[i] * delkaRadky / maxPocet; // normování počtu symbolů, abych nedělal stovky křížků
                for (int j = 0; j < pocetSymbolu; j++) //vypíšu na řádek symboly histogramu
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}

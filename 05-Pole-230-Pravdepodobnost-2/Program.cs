using System;

namespace _05_Pole_230_Pravdepodobnost_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000; //vyzkoušejte i jiné možnosti
            int k = 2; //vyzkoušejte i jiné možnosti       

            int minSoucet = k;
            int maxSoucet = k * 6;

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
                    soucetHodu += rnd.Next(1, 7);
                }

                pocty[soucetHodu]++;//po doběhnutí "si udělám čárku" v počítadle u součtu, který nám vyšel
            }
            //Teď jsou v poli pocty skutečné počty, kolikrát co padlo


            //Projdu pole od nejmenší možné hodnoty a budu ho vypisovat
            for (int i = minSoucet; i < pocty.Length; i++)
            {
                double pravdepodobnost = (double) pocty[i] / n; //pozor - double, jinak celočíselné dělení
                Console.WriteLine($"{i:00}:  {pocty[i]}x - {pravdepodobnost:0.0000}");
            }

        }
    }
}

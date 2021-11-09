using System;

namespace _03_While_130_Pocty_podle_velikosti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej přirozená čísla, já počítat, kolik bylo jak velkých. Vložením 0 nebo záporného čísla sčítání ukončíš");

            //připravím si počitadla na čísla
            int jednociferna = 0;
            int dvojciferna = 0;
            int trojciferna = 0;
            int vetsi = 0;

            // připravím proměnnou na načítání a poprvé do ní uložím
            int nacteno = int.Parse(Console.ReadLine());

            while (nacteno > 0) //dokud je to kladné, budu pracovat
            {
                if (nacteno < 10) //podle velikosti zvýším některé počitadlo
                    jednociferna++;
                else if (nacteno < 100)
                    dvojciferna++;
                else if (nacteno < 1000)
                    trojciferna++;
                else
                    vetsi++;

                nacteno = int.Parse(Console.ReadLine()); // načtu další číslo
            }

            Console.WriteLine($"Celkem bylo vloženo {jednociferna} jednociferných, {dvojciferna} dvojciferných, {trojciferna} trojciferných a {vetsi} větších čísel.");
        }
    }
}

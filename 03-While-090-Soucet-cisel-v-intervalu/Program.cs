using System;

namespace _03_While_090_Soucet_cisel_v_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sečtu všechna čísla v zadaných mezích.");
            
            Console.Write("Zadej jeden kraj intervalu: ");
            int mez1 = int.Parse(Console.ReadLine());

            Console.Write("Zadej druhý kraj intervalu: ");
            int mez2 = int.Parse(Console.ReadLine());

            if (mez2 < mez1) // to jen kdyby uživatel popletl horní a dolní, tak přehodím
            {
                int tmp = mez2;
                mez2 = mez1;
                mez1 = tmp; 
            }

            int suma = 0; // sem budu sčítat
            int cislo = mez1; // budu si posouvat ukazatel oz začátku
            while (cislo <= mez2)
            {
                suma += cislo; // přičtu aktuální pozici
                cislo++; // a posunu si ji
            }

            Console.WriteLine($"Součet všech čísel od {mez1} do {mez2} je {suma}.");
        }
    }
}

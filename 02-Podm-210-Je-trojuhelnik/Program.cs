using System;

namespace _02_Podm_210_Je_trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            string nacteno;

            Console.Write("Zadej stranu A: ");
            nacteno = Console.ReadLine();
            double stranaA = double.Parse(nacteno);

            Console.Write("Zadej stranu B: ");
            nacteno = Console.ReadLine();
            double stranaB = double.Parse(nacteno);

            Console.Write("Zadej stranu C: ");
            nacteno = Console.ReadLine();
            double stranaC = double.Parse(nacteno);

            // Sem přijde váš kód
            if (
                stranaA + stranaB > stranaC 
                && stranaB + stranaC > stranaA 
                && stranaA + stranaC > stranaB
            )
                Console.WriteLine("Lze sestrojit.");
            else
                Console.WriteLine("Nelze sestrojit.");

            if (
                stranaA + stranaB <= stranaC
                || stranaB + stranaC <= stranaA
                || stranaA + stranaC <= stranaB
            )
                Console.WriteLine("Nelze sestrojit.");
            else
                Console.WriteLine("Lze sestrojit.");

            // s pomocnou logickou
            bool lzeSestavit = stranaA + stranaB > stranaC && stranaB + stranaC > stranaA && stranaA + stranaC > stranaB;
            Console.WriteLine("{0} sestrojit", lzeSestavit ? "Lze" : "Nelze");
        }
    }
}

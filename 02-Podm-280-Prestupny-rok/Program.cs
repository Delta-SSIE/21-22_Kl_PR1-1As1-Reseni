using System;

namespace _02_Podm_280_Prestupny_rok
{
    class Program
    {
        static void Main(string[] args)
        {
            // sem přijde váš kód      
            int rok = 2004;
            if (rok % 4 == 0)
            {
                if (rok % 100 == 0)
                {
                    if (rok % 400 == 0)
                    {
                        Console.WriteLine($"Rok {rok} je přestupný");
                    }
                    else
                    {
                        Console.WriteLine($"Rok {rok} není přestupný");
                    }
                }
                else
                {
                    Console.WriteLine($"Rok {rok} je přestupný");
                }
            }
            else
            {
                Console.WriteLine($"Rok {rok} není přestupný");
            }

            // a nebo najednou 

            if ((rok % 4 == 0) && ((rok % 100 != 0) || (rok % 400 == 0)))
            {
                Console.WriteLine($"Rok {rok} je přestupný");
            }
            else
            {
                Console.WriteLine($"Rok {rok} není přestupný");
            }
        }
    }
}

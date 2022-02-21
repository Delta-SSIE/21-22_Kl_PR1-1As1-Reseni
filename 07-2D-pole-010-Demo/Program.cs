using System;

namespace _07_2D_pole_010_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1D pole
            int[] beznePole = new int[10];

            //2D pole
            int[,] dvojrozmernePole = new int[2, 7];
            dvojrozmernePole[0, 1] = 10;
            dvojrozmernePole[1, 2] = 12;
            dvojrozmernePole[0, 0] = -5;

            Console.WriteLine("Length: " + dvojrozmernePole.Length);
            Console.WriteLine();

            //výpis
            for (int i = 0; i < dvojrozmernePole.GetLength(0); i++)
            {
                for (int j = 0; j < dvojrozmernePole.GetLength(1); j++)
                {
                    Console.WriteLine($"Na pozici [{i}, {j}] je hodnota {dvojrozmernePole[i, j]}");
                }
            }

            Console.WriteLine();
            for (int i = 0; i < dvojrozmernePole.GetLength(0); i++)
            {
                for (int j = 0; j < dvojrozmernePole.GetLength(1); j++)
                {
                    Console.Write( string.Format("{0:00}", dvojrozmernePole[i, j]) + " | ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < dvojrozmernePole.GetLength(0); i++)
            {
                Console.Write(" | ");
                for (int j = 0; j < dvojrozmernePole.GetLength(1); j++)
                {
                    Console.Write(dvojrozmernePole[i, j].ToString().PadLeft(3, ' ') + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}

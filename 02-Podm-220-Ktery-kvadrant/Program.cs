using System;

namespace _02_Podm_220_Ktery_kvadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej souřadnici x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Zadej souřadnici y: ");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 || y == 0)
                Console.WriteLine("Leží na souřadné ose.");
            else if (x > 0 && y > 0)
                Console.WriteLine("Leží v 1. kvadrantu.");
            else if (x < 0 && y > 0)
                Console.WriteLine("Leží v 2. kvadrantu.");
            else if (x < 0 && y < 0)
                Console.WriteLine("Leží v 3. kvadrantu.");
            else 
                Console.WriteLine("Leží v 4. kvadrantu.");


            // nebo
            if (x == 0 || y == 0)
                Console.WriteLine("Leží na souřadné ose.");
            else if (x > 0)
            {
                if (y > 0)
                    Console.WriteLine("Leží v 1. kvadrantu.");
                else
                    Console.WriteLine("Leží v 4. kvadrantu.");
            }
            else
            {
                if (y > 0)
                    Console.WriteLine("Leží v 2. kvadrantu.");
                else
                    Console.WriteLine("Leží v 3. kvadrantu.");
            }
        }
    }
}

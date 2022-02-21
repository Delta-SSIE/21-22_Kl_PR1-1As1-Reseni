using System;

namespace _06_Metody_140_Je_v_norme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(JeVNorme(35.1, 33, 3.5)); //true
            Console.WriteLine(JeVNorme(35.1, 33, 1.5)); //false
            Console.WriteLine(JeVNorme(11.8, 13, 1.3)); //true
        }

        //zde napište vaši metodu
        public static bool JeVNorme(double realne, double spravne, double tolerance) 
        {
            return Math.Abs(realne - spravne) < tolerance;

            //double rozdil;
            //if (realne > spravne)
            //    rozdil = realne - spravne;
            //else
            //    rozdil = spravne - realne;

            //return rozdil < tolerance;
        }
    }
}

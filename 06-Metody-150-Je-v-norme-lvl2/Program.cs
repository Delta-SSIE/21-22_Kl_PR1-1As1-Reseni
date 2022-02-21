using System;

namespace _06_Metody_150_Je_v_norme_lvl2
{
    class Program
    {
        //tuto metodu neměňte
        public static void Main(string[] args)
        {
            Console.WriteLine(JeVNorme(52.1, 50, 10)); //true
            Console.WriteLine(JeVNorme(55.1, 50, 10)); //false
            Console.WriteLine(JeVNorme(128.3, 130, 1.5)); //true
            Console.WriteLine(JeVNorme(128, 130, 1.5)); //false
        }

        //zde pište váš kód
        public static bool JeVNorme(double skutecne, double spravne, double tolerance)
        {
            double rozdil = Math.Abs(spravne - skutecne);
            return rozdil / spravne * 100 < tolerance;
        }
    }
}

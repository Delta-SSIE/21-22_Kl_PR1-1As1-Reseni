using System;

namespace _06_Metody_160_Je_prestupny
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(JePrestupnyJinak(2011)); //false - není dělitelný 4
            Console.WriteLine(JePrestupnyJinak(1996)); //true - je dělitelný 4 a není 100
            Console.WriteLine(JePrestupnyJinak(1900)); //false - je sice dělitelný 4, ale zároveň i 100
            Console.WriteLine(JePrestupnyJinak(2000)); //true - je dělitelný 100, ale i 400
        }

        public static bool JePrestupny(int rok)
        {
            if (rok % 4 != 0)
                return false;
            else if (rok % 100 != 0)
                return true;
            else if (rok % 400 != 0)
                return false;
            else
                return true;
        }
        //a nebo
        public static bool JePrestupnyJinak(int rok)
        {            
            return rok % 4 == 0 && (rok % 100 != 0 || rok % 400 == 0);
        }
    }
}

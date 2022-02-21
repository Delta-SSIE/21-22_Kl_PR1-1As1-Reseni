using System;

namespace _06_Metody_180_Je_heslo_podle_vzoru_zakladni
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hesla = { "heslo", "ncc-1701", "Ncc-1701", "a1b2C3" };
            for (int i = 0; i < hesla.Length; i++)
            {
                Console.WriteLine("Heslo {0} {1} platné", hesla[i], ValidujHeslo(hesla[i]) ? "je" : "není");
            }
        }
        public static bool ValidujHeslo(string heslo)
        {
            //heslo musí být alespoň 8 znaků dlouhé
            //heslo musí obsahovat alespoň 1 velké písmeno
            //heslo musí obsahovat alepsoň 1 malé písmeno
            //heslo musí obsahovat alepsoň 1 číslici


            bool velke = false;
            bool male = false;
            bool cislo = false;

            if (heslo.Length < 8)
            {
                return false;
            }
            for (int i = 0; i < heslo.Length; i++)
            {

                if (heslo[i] >= 'A' && heslo[i] <= 'Z')
                    velke = true;

                else if (heslo[i] >= 'a' && heslo[i] <= 'z')
                    male = true;

                else if (heslo[i] >= '0' && heslo[i] <= '9')
                    cislo = true;
            }


            return velke && male && cislo;
        }

    }
}

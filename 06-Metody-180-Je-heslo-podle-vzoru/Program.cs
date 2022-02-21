using System;

namespace _06_Metody_180_Je_heslo_podle_vzoru
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

            return (heslo.Length >= 8)
                && ObsahujeZnakZIntervalu(heslo, 'A', 'Z')
                && ObsahujeZnakZIntervalu(heslo, 'a', 'z')
                && ObsahujeZnakZIntervalu(heslo, '0', '9');
        }

        public static bool ObsahujeZnakZIntervalu(string slovo, char zacatekIntervalu, char konecIntervalu)
        {
            for (int i = 0; i < slovo.Length; i++)
            {
                char znak = slovo[i];
                if (znak >= zacatekIntervalu && znak <= konecIntervalu)
                    return true;
            }
            return false;
        }

        //šlo by i takhle
        //public static bool MaVelke(string slovo)
        //{
        //    return ObsahujeZnakZIntervalu(slovo, 'A', 'Z');
        //}
    }
}

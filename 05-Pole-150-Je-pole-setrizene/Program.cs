using System;

namespace _05_Pole_150_Je_pole_setrizene
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] cisla = { -5, 4.3, 2.7, 6.41, 12 }; //není
            //double[] cisla = { -5, 2.7, 4.3, 6.41, 12 }; //je
            double[] cisla = { -5, 2.7, 2.7, 4.3, 6.41, 12 }; //je

            //proměnná "setrizeno" zanamená, že zatím je vše v pořádku
            bool setrizeno = true; //na začátku jsem ještě nenarazil na žádnou chybu, proto si zapíšu true

            //projdu celé pole
            //budu ale pracovat se dvěma indexy - porovnávat - proto musím skončit 
            //o 1 dřív, než obvykle
            for (int i = 0; i < cisla.Length - 1; i++)
            {
                double totoCislo = cisla[i];
                double pristiCislo = cisla[i + 1];
                
                //pokud je příští číslo menší než aktuální, není to setřízeno
                if (pristiCislo < totoCislo)
                {
                    //proto si poznačím chybu třízení
                    setrizeno = false;
                    //a skončím prohledávání, dál není třeba
                    break;
                }
            }

            //pokud jsem sem došel s tím, že vše bylo setřízeno, pak je setřízeno vše
            Console.WriteLine("Pole {0} setřízené.", setrizeno ? "je" : "není");
        }
    }
}

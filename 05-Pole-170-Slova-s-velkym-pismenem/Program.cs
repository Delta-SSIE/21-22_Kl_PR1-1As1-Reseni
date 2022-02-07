using System;

namespace _05_Pole_170_Slova_s_velkym_pismenem
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Aspoň trochu ovsa, Karlíku, tomu koni dej. Copak nevidíš, že mu Eva zapomněla nasypat a Zdeněk tu dnes není. Ani Čeněk nedělá, co by měl. Nevím proč vás Evelína nevyhnala. Všichni byste Evelíně měli poděkovat. Třeba Řehoř a Iva, taky se pořád někde potulují. Dejvice, Emauzy, Strašnice, Ejpovice, ale být doma, to ne. To bych toho po vás chtěl moc.";

            //vytvoříme pole slov rozdělením textu v polohách mezer
            string[] slova = text.Split(" ");
            
            //pole projdeme
            for (int i = 0; i < slova.Length; i++)
            {
                string slovo = slova[i];

                //zjistíme, že je první písmeno (slovo[0]) velké pomocí metody Char.IsUpper()
                if (Char.IsUpper(slovo[0]))
                    Console.WriteLine(slovo);

                //také by to šlo tak, že bychom celé slovo snížili na malé a porovnali s původním, zda se neliší
                //if (slovo.ToLower() != slovo) 
            }
        }
    }
}

using System;

namespace _02_Podm_190_IQ_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který položí uživateli následující 3 otázky:

            //Kolik je 2 + 4 ?
            Console.Write("Kolik je 2 + 4: ");
            int soucet = int.Parse(Console.ReadLine());

            //Které písmeno je první v abecedě?
            Console.Write("Které písmeno je první v abecedě: ");
            string pismeno = Console.ReadLine();

            //Je číslo 13 sudé(A / N) ?
            Console.WriteLine("Je číslo 13 sudé (A / N)?: ");
            string odpoved = Console.ReadLine();

            int skore = 0;
            if (soucet == 6)
                skore += 5; //Za každou správně zodpovězenou otázku uživatel dostane 5 bodů
            else
                skore -= 3; //Za každou špatnou odpověď přijde o 3 body.
            
            if (pismeno.ToUpper() == "A")
                skore += 5;
            else
                skore -= 3;

            if (odpoved.ToUpper() == "N")
                skore += 5;
            else
                skore -= 3;

            //Nakonec program vypíše celkové skóre.
            Console.WriteLine($"Celkové skore je {skore}.");
        }
    }
}

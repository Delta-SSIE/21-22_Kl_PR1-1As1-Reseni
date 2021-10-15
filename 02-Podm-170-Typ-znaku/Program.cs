using System;

namespace _02_Podm_170_Typ_znaku
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Stiskni klávesu: ");
            char znak = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Sem přijde váš kód

            string typKlavesy;
            if ((znak > 64 && znak < 91) || (znak > 96 && znak < 123))
                typKlavesy = "písmeno";
            else if (znak > 47 && znak < 58)
                typKlavesy = "číslo";
            else
                typKlavesy = "speciální znak";

            Console.WriteLine($"Stisknutá klávesa představuje {typKlavesy}.");

            // Konec vašeho kódu

            //druhá možnost - použití char jako čísla
            if ((znak >= 'A' && znak <= 'Z') || (znak >= 'a' && znak <= 'z'))
                typKlavesy = "písmeno";
            else if (znak >= '0' && znak <= '9')
                typKlavesy = "číslo";
            else
                typKlavesy = "speciální znak";

        }
    }
}

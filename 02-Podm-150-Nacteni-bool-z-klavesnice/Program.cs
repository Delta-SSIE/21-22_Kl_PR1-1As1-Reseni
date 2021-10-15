using System;

namespace _02_Podm_150_Nacteni_bool_z_klavesnice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sem přijde váš kód
            // uvnitř tohoto kódu musí vzniknout proměnné jeHezky a chciVen 

            Console.Write("Je venku hezky? (A/N): ");
            string odpoved = Console.ReadLine();
            bool jeHezky;
            if (odpoved == "a" || odpoved == "A")
                jeHezky = true;
            else
                jeHezky = false;

            Console.Write("Chce se ti ven? (A/N): ");
            odpoved = Console.ReadLine(); // už nepíšu string - proměnná už existuje, já ji znovupoužívám
            //bool chciVen;
            //if (odpoved == "a" || odpoved == "A")
            //    jeHezky = true;
            //else
            //    jeHezky = false;

            // nebo to zkrátíme
            
            bool chciVen = odpoved.ToUpper() == "A";

            // Konec vašeho kódu

            if (jeHezky || chciVen)
            {
                Console.WriteLine("Je čas jít ven.");
            }
            else
            {
                Console.WriteLine("Zůstaň radši doma.");
            }
        }
    }
}

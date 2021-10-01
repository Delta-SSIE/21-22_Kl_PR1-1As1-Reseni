using System;

namespace _090_Vymena_karet
{
    class Program
    {
        static void Main(string[] args)
        {

            string Pavel = "Červená sedma";
            string Petr = "Kulový spodek";

            // Sem přijde váš kód, je zakázáno použít uvozovky
            // Uvažujme nad tím podobně, jako bychom chtěli vyměnit obsah dvou hrnečků
            // - musíme použít třetí, dočasný (anglicky temporary)

            string temp = Pavel; // Odložím si, co držel Pavel
            Pavel = Petr; // Dám Pavlovi do ruky kopii(!) toho, co má Petr. Teď mají oba to stejné.
            Petr = temp;  // Dám Petrovi do ruky to, co je v dočasném a původně měl Pavel. (Opět jde o kopii.)

            // Konec prostoru pro kód

            Console.WriteLine("Pavel má v ruce: " + Pavel); //mělo by vypsat "Kulový spodek"
            Console.WriteLine("Petr má v ruce: " + Petr);  //mělo by vypsat "Červená sedma"

        }
    }
}

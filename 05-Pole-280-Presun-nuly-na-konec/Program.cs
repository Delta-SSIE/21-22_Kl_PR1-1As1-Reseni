using System;

namespace _05_Pole_280_Presun_nuly_na_konec
{
    class Program
    {
        static void Main(string[] args)
        {

            //Napište program, který překopíruje hodnoty z pole cisla do pole cisla2 
            //tak, že nulové hodnoty umístí až na konec, tedy z pole
            //int[] cisla = { 1, -5, 0, 4, 0, 7, 12, 0, 4 };
            //bude vytvořeno pole cisla2 s těmito hodnotami
            //{ 1, -5, 4, 7, 12, 4, 0, 0, 0 }
            //Následně bude pole cisla2 vypsáno.

            int[] cisla = { 1, -5, 0, 4, 0, 7, 12, 0, 4 };
            //zde pokračujte
            //vytvořte proměnnou cisla2 a do ní uložte dle předpisu v zadání

            int[] cisla2 = new int[cisla.Length]; //vytvořím stejně velké pole

            int kam = 0; //proměnná "kam" mi bude říkat, kam se umístí příští nenulový prvek

            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] != 0)
                {
                    cisla2[kam] = cisla[i]; //uložím do nového pole na správnou pozici
                    kam++; //posunu si ukazatel, kam ukládat příště
                }
            }

            //a teď vynuluju všechny následující pozice (v C# není úplně nutné, 
            //pole se "narodí" se samými nulami) tak, že začnu na "kam" a dojedu do konce
            for (int i = kam; i < cisla.Length; i++)
            {
                cisla2[i] = 0;
            }

            //zde končí váš kód
            Console.WriteLine(String.Join(", ", cisla2));
            
        }
    }
}

using System;

namespace _05_Pole_130_Rohy_obdelnika
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] levyHorni = { -1, 2 }; //souřadníce rohu
            int[] rozmery = { 2, 3 }; //délky stran x a y

            // doplňte

            int[] pravyHorni = { levyHorni[0] + rozmery[0], levyHorni[1] }; //je součty souřadnic a délek - pravý horní má stejné y jako levý horní, ale k x je třeba přičíst délku strany
            int[] levyDolni = { levyHorni[0], levyHorni[1] + rozmery[1] }; //apod.
            int[] pravyDolni = { levyHorni[0] + rozmery[0], levyHorni[1] + rozmery[1] };

            // vypište
            Console.WriteLine($"Obdélník s levým horním rohem na pozici [{levyHorni[0]}, {levyHorni[1]}] má další rohy [{levyDolni[0]}, {levyDolni[1]}], [{pravyHorni[0]}, {pravyHorni[1]}] a [{pravyDolni[0]}, {pravyDolni[1]}].");
        }
    }
}

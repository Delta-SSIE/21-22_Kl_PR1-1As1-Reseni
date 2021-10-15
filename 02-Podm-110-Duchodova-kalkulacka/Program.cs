using System;

namespace _02_Podm_110_Duchodova_kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej rok narozeni: ");
            int narozen = int.Parse(Console.ReadLine());

            int duchod;

            //if (narozen < 1936 || narozen > 2005)
            //{
            //    duchod = 0; // nula označí chybu
            //} 
            //else if (narozen < 1941)
            //{
            //    duchod = 60;
            //}
            //else if (narozen < 1947)
            //{
            //    duchod = 61;
            //}
            //else if (narozen < 1953)
            //{
            //    duchod = 62;
            //}
            //else if (narozen < 1959)
            //{
            //    duchod = 63;
            //}
            //else if (narozen < 1965)
            //{
            //    duchod = 64;
            //}
            //else if (narozen < 1971)
            //{
            //    duchod = 65;
            //}
            //else if (narozen < 1977)
            //{
            //    duchod = 66;
            //}
            //else if (narozen < 1983)
            //{
            //    duchod = 67;
            //}
            //else if (narozen < 1989)
            //{
            //    duchod = 68;
            //}
            //else if (narozen < 1995)
            //{
            //    duchod = 69;
            //}
            //else if (narozen < 2001)
            //{
            //    duchod = 70;
            //} 
            //else
            //{
            //    duchod = 71;
            //}

            // jiný zápis téhož
            //switch (narozen)
            //{
            //    case 1936:
            //    case 1937:
            //    case 1938:
            //    case 1939:
            //    case 1940:
            //        duchod = 60;
            //        break;
                
            //    // ...
            //    // a tak dále až po
            //    // ...

            //    default:
            //        duchod = 0;
            //        break;
            //}

            // a ještě jiný zápis
            duchod = narozen < 1936 || narozen > 2005 ? 0 : (narozen - 1935) / 6 + 60;

            if (duchod != 0) // nulou jsme si označili chybu
            {
                Console.WriteLine($"Věk odchodu do důchodu je stanoven na {duchod} let, tedy na rok {narozen + duchod}.");
            }
            else
            {
                Console.WriteLine("Pro váš rok narození neumím vypočítat");
            }

        }
    }
}

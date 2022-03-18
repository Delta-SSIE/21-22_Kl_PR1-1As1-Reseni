using System;

namespace _07_2D_pole_040_Vypis_do_tabulky
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] cisla = {
            {1, 0, 10, 4, 7},
            {-2, 2, 3, 4, 2},
            {6, 5, 4, 3, 205}
        };

            VypisTabulku(cisla);

            VypisTabulkuLepe(cisla);
        }

        //zde vložte kód metody
        static void VypisTabulku(int[,] cisla)
        {
            //budu predpokladat 1 cislici na cislo (to zjevně není pravda)
            for (int y = 0; y < cisla.GetLength(0); y++)
            {
                for (int i = 0; i < cisla.GetLength(1) * 2 + 1; i++)
                {
                    Console.Write("-"); // pomlčky nad řádkem - je jich potřeba 2x tolik, co číslic (číslice + oddělovač) + 1 (oddělovač na konci)
                }
                Console.WriteLine(); //odřádkuju

                for (int x = 0; x < cisla.GetLength(1); x++)
                {
                    Console.Write("|" + cisla[y, x]); //výpis čísel s oddělovači
                }
                Console.WriteLine("|"); ///oddělovač na konci řádky a odřádkování

            }

            for (int i = 0; i < cisla.GetLength(1) * 2 + 1; i++)
            {
                Console.Write("-"); // koncové pomlčky 
            }
            Console.WriteLine(); //odřádkuju

        }

        /// <summary>
        /// Vypíše 2D pole do konzole do tabulky
        /// </summary>
        /// <param name="cisla"></param>
        static void VypisTabulkuLepe(int[,] cisla)
        {
            int[] maxDelky = MaxDelky(cisla);
            int delkaRadky = SoucetPole(maxDelky) + cisla.GetLength(1) + 1; //délka řádky je součet všech délek čísel + všech oddělovačů

            for (int y = 0; y < cisla.GetLength(0); y++)
            {
                Console.WriteLine("".PadRight(delkaRadky, '-')); //nad každým řádkem pomlčky - vygeneruju pomocí "doplň prázdný řetezec na délku"
                for (int x = 0; x < cisla.GetLength(1); x++)
                {
                    Console.Write('|');
                    Console.Write(FormatujCislo(cisla[y, x], maxDelky[x]));
                }
                Console.WriteLine('|');
            }
            Console.WriteLine("".PadRight(delkaRadky, '-')); //za posledním řádkem pomlčky - vygeneruju pomocí "doplň prázdný řetezec
        }

        /// <summary>
        /// Spočte a vrátí největší délky čísla v každém sloupci v poli cisla indexovaného jako [radek, sloupec]
        /// </summary>
        /// <param name="cisla">2D pole čísel</param>
        /// <returns>1D pole s délkami nejdelších čísel v každém sloupci</returns>
        static int[] MaxDelky(int[,] cisla)
        {
            int[] maxDelky = new int[cisla.GetLength(1)]; // ke každému sloupci vrátím nejdelší číslo

            for (int y = 0; y < cisla.GetLength(0); y++)
            {
                for (int x = 0; x < cisla.GetLength(1); x++)
                {
                    int delka = cisla[y, x].ToString().Length; //zjistím délku čísla po převedení na řetězec
                    if (delka > maxDelky[x])
                        maxDelky[x] = delka; //pokud je delší, než maximum pro tento sloupec (určuje x), zapamatuju si
                }
            }

            return maxDelky;
        }

        /// <summary>
        /// Formátuje číslo na zadanou délku - doplní jej mezerami zleva
        /// </summary>
        /// <param name="cislo"></param>
        /// <param name="delka"></param>
        /// <returns>Formátované číslo</returns>
        static string FormatujCislo(int cislo, int delka)
        {
            string retezec = cislo.ToString();
            retezec = retezec.PadLeft(delka, ' '); //pad znamená vyplň - doplní řetězec na zadanou délku předanáým znakem
            return retezec;
        }

        /// <summary>
        /// Sečte všechny prvky v poli
        /// </summary>
        /// <param name="pole"></param>
        /// <returns>Součet</returns>
        static int SoucetPole(int[] pole)
        {
            int sum = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                sum += pole[i];
            }
            return sum;
        }

    }
}

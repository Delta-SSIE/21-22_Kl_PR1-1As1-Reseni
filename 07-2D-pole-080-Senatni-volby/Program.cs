using System;

namespace _07_2D_pole_080_Senatni_volby
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kandidati = { "Alena", "Božena", "Cecílie", "Dana", "Eva", "Filoména", "Gertruda", "Hildegarda" };
            int[,] hlasy =
            {
                {0,2,1,0,0,0,1,1},
                {0,0,1,1,2,0,0,0},
                {0,0,1,0,2,1,0,0},
                {1,1,0,2,0,1,0,0},
                {0,0,1,2,1,0,0,1},
                {0,2,1,0,1,1,0,0},
                {0,1,1,1,0,1,2,1},
                {0,0,1,0,0,2,0,0},
                {0,0,0,0,2,1,0,0},
                {0,0,1,1,0,1,2,0},
                {1,0,2,0,0,1,1,1},
                {1,2,1,1,0,0,0,1},
                {0,0,2,1,0,1,0,0},
                {0,0,0,0,0,0,0,2},
                {2,0,1,0,0,1,0,0},
                {1,0,0,0,0,2,0,0},
                {0,0,0,1,2,0,0,0},
                {0,1,1,0,2,0,0,1},
                {1,2,1,0,1,1,1,0},
                {0,1,2,1,0,1,0,0},
                {1,1,1,2,0,0,0,1},
                {0,0,1,2,0,1,1,1},
                {0,2,1,0,1,1,0,0},
                {0,1,2,0,1,1,0,0},
                {0,2,1,0,1,0,0,0},
                {0,2,0,0,1,1,1,0},
                {0,2,0,1,0,1,0,1},
                {0,2,1,0,0,0,0,0},
                {0,0,2,1,1,0,0,1},
                {0,0,1,2,0,1,0,0},
                {0,0,1,1,0,2,0,0},
                {0,1,1,1,1,0,0,2},
                {0,1,1,2,1,1,0,0},
                {2,1,0,1,0,1,0,0},
                {0,1,1,1,0,1,1,2},
            };

            int[] prvniKolo = new int[kandidati.Length];
            for (int i = 0; i < hlasy.GetLength(0); i++)
            {
                for (int j = 0; j < hlasy.GetLength(1); j++)
                {
                    if (hlasy[i, j] == 2)
                        prvniKolo[j]++;
                }
            }

            Console.WriteLine(string.Join(',', prvniKolo));

            int vitez1 = 0;
            int vitez1Index = -1;


            for (int i = 0; i < prvniKolo.Length; i++)
            {
                if (prvniKolo[i] > vitez1)
                {
                    vitez1 = prvniKolo[i];
                    vitez1Index = i;
                }
            }

            int druhy1 = 0;
            int druhy1Index = -1;

            for (int i = 0; i < prvniKolo.Length; i++)
            {
                if (i == vitez1Index) //přeskočím maximum
                    continue;

                if (prvniKolo[i] > druhy1)
                {
                    druhy1 = prvniKolo[i];
                    druhy1Index = i;
                }
            }

            Console.WriteLine(
                "V prvním kole vítezí {0} ({2} hlasů), postupuje ještě {1} ({3} hlasů).", 
                kandidati[vitez1Index],
                kandidati[druhy1Index],
                vitez1,
                druhy1
            );

            int kolo2Vitez1 = 0;
            int kolo2Druhy1 = 0;
            for (int i = 0; i < hlasy.GetLength(0); i++)
            {
                if (hlasy[i, vitez1Index] == 2)
                    kolo2Vitez1++;
                else if (hlasy[i, druhy1Index] == 2)
                    kolo2Druhy1++;
                else if (hlasy[i, vitez1Index] == 1 && hlasy[i, druhy1Index] == 0)
                    kolo2Vitez1++;
                else if (hlasy[i, vitez1Index] == 0 && hlasy[i, druhy1Index] == 1)
                    kolo2Druhy1++;
            }

            string vitez = "";
            string druhy = "";
            int hlasyVitez = 0;
            int hlasyDruhy = 0;


            if (kolo2Vitez1 > kolo2Druhy1)
            {
                vitez = kandidati[vitez1Index];
                hlasyVitez = kolo2Vitez1;
                druhy = kandidati[druhy1Index];
                hlasyDruhy = kolo2Druhy1;
            }
            else if (kolo2Vitez1 < kolo2Druhy1)
            {
                vitez = kandidati[druhy1Index];
                hlasyVitez = kolo2Druhy1;
                druhy = kandidati[vitez1Index]; 
                hlasyDruhy = kolo2Vitez1; 
            }
           
            if (kolo2Vitez1 == kolo2Druhy1)
            {
                Console.WriteLine(
                    "V 2. kole rovnost počtu hlasů: {0} ({2}) - {1} ({3}), rozhodne los.",
                    kandidati[vitez1Index],
                    kandidati[druhy1Index],
                    kolo2Vitez1,
                    kolo2Druhy1
                );
            }
            else
            {
                Console.WriteLine(
                    "V druhém kole vítězí {0} ({2} hlasů), na 2. místě {1} ({3} hlasů).",
                    vitez,
                    druhy,
                    hlasyVitez,
                    hlasyDruhy
                );

            }

        }
    }
}

using System;

namespace _04_For_280_Algebrogram_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //  SEND
            //+ MORE
            //------ -
            // MONEY

            for (int S = 1; S < 10; S++)
            {
                for (int E = 0; E < 10; E++)
                {
                    if (E == S)
                        continue;
                    for (int N = 0; N < 10; N++)
                    {
                        if (N == S || N == E)
                            continue;
                        for (int D = 0; D < 10; D++)
                        {
                            if (D == S || D == E || D == N)
                                continue;
                            for (int M = 1; M < 10; M++)
                            {
                                if (M == S || M == E || M == N || M == D)
                                    continue;
                                for (int O = 0; O < 10; O++)
                                {
                                    if (O == S || O == E || O == N || O == D || O == M)
                                        continue;
                                    for (int R = 0; R < 10; R++)
                                    {
                                        if (R == S || R == E || R == N || R == D || R == M || R == M)
                                            continue;

                                        for (int Y = 0; Y < 10; Y++)
                                        {
                                            if (Y == S || Y == E || Y == N || Y == D || Y == M || Y == M || Y == R)
                                                continue;

                                            if (S * 1000 + E * 100 + N * 10 + D + M * 1000 + O * 100 + R * 10 + E == M * 10000 + O * 1000 + N * 100 + E * 10 + Y)
                                            {
                                                Console.WriteLine($" {S}{E}{N}{D}");
                                                Console.WriteLine($"+{M}{O}{R}{E}");
                                                Console.WriteLine($"{M}{O}{N}{E}{Y}");
                                            }

                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

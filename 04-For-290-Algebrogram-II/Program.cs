using System;

namespace _04_For_290_Algebrogram_II
{
    class Program
    {
        static void Main(string[] args)
        {         
            for (int O = 1; O < 10; O++)
            {
                for (int E = 0; E < 10; E++)
                {
                    if (E == O)
                        continue;
                    for (int L = 1; L < 10; L++)
                    {
                        if (L == O || L == E)
                            continue;
                        for (int P = 1; P < 10; P++)
                        {
                            if (P == O || P == E || P == L)
                                continue;
                            for (int A = 1; A < 10; A++)
                            {
                                if (A == O || A == E || A == L || A == P)
                                    continue;
                                for (int I = 0; I < 10; I++)
                                {
                                    if (I == O || I == E || I == L || I == P || I == A)
                                        continue;
                                    for (int S = 0; S < 10; S++)
                                    {
                                        if (S == O || S == E || S == L || S == P || S == A || S == A)
                                            continue;

                                        for (int R = 1; R < 9; R++)
                                        {
                                            if (R == O || R == E || R == L || R == P || R == A || R == A || R == S)
                                                continue;
                                            for (int T = 0; T < 9; T++)
                                            {
                                                if (T == O || T == E || T == L || T == P || T == A || T == A || T == S || T == R)
                                                    continue;
                                                for (int U = 0; U < 9; U++)
                                                {
                                                    if (U == O || U == E || U == L || U == P || U == A || U == A || U == S || U == R || U == T)
                                                        continue;

                                                    //OOEL :  PO =  LAI
                                                    //   -     x      +
                                                    //PLSR -  AL = PSTE
                                                    //-----------------
                                                    //LPIP + RAO = PPLU   
                                                    int OOEL = O * 1000 + O * 100 + E * 10 + L;
                                                    int PO = P * 10 + O;
                                                    int LAI = L * 100 + A * 10 + I;
                                                    int PLSR = P * 1000 + L * 100 + S * 10 + R;
                                                    int AL = A * 10 + L;
                                                    int PSTE = P * 1000 + S * 100 + T * 10 + E;
                                                    int LPIP = L * 1000 + P * 100 + I * 10 + P;
                                                    int RAO = R * 100 + A * 10 + O;
                                                    int PPLU = P * 1000 + P * 100 + L * 10 + U;
                                                    if (
                                                        OOEL / PO == LAI
                                                        && PLSR - AL == PSTE
                                                        && LPIP + RAO == PPLU
                                                        && OOEL - PLSR == LPIP
                                                        && PO * AL == RAO
                                                        && LAI + PSTE == PPLU
                                                        )
                                                    {
                                                        Console.WriteLine($"{O}{O}{E}{L} :  {P}{O} =  {L}{A}{I}");
                                                        Console.WriteLine("   -     x      +");
                                                        Console.WriteLine($"{P}{L}{S}{R} -  {A}{L} = {P}{S}{T}{E}");
                                                        Console.WriteLine("-----------------");
                                                        Console.WriteLine($"{L}{P}{I}{P} + {R}{A}{O} = {P}{P}{L}{U}");   
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
    }
}

namespace _04_For_07_algebrogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   SEND
            // + MORE
            //  MONEY

            int S, E, N, D, M, O, R, Y;

            for (S = 1; S < 10; S++)  //od 1 - na začátku nesmí být 0
            {
                for (E = 0; E < 9; E++)
                {
                    if (E == S) continue; //přeskoč, protože číslo už je použité
                    
                    for (N = 0; N < 9; N++)
                    {
                        if (N == S || N == E) continue;

                        for (D = 0; D < 9; D++)
                        {
                            if (D == S || D == E || D == N) continue;

                            for (M = 1; M < 9; M++)
                            {
                                if (M == S || M == E || M == N || M == D) continue;

                                for (O = 0; O < 9; O++)
                                {
                                    if (O == S || O == E || O == N || O == D || O == M) continue;

                                    for (R = 0; R < 9; R++)
                                    {
                                        if (R == S || R == E || R == N || R == D || R == M || R == 0) continue;

                                        for (Y = 0; Y < 9; Y++)
                                        {
                                            if (Y == S || Y == E || Y == N || Y == D || Y == M || Y == 0 || Y == R) continue;

                                            if (
                                                                S * 1_000 + E * 100 + N * 10 + D
                                                              + M * 1_000 + O * 100 + R * 10 + E
                                                == M * 10_000 + O * 1_000 + N * 100 + E * 10 + Y
                                                )
                                            {
                                                Console.WriteLine($"   {S}{E}{N}{D}");
                                                Console.WriteLine($" + {M}{O}{R}{E}");
                                                Console.WriteLine($"= {M}{O}{N}{E}{Y}");
                                                Console.WriteLine("-------");
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

namespace _06_Metody_070_Mnozinove_operace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { 0, 1, -2, 1, 3, 0, -1 };

            int[] poleA = OdstranDuplicity(pole); // {0, 1, -2, 3, -1}
            Console.WriteLine(PoleNaRetezec(pole) + " => " + PoleNaRetezec(poleA));
        }
        public static string PoleNaRetezec(int[] pole)
        {
            return "{" + string.Join(", ", pole) + "}";
        }
        static int[] OdstranDuplicity(int[] pole)
        {
            //vytvorim pole pro vysledek - stejne velke jako puvodni
            int[] vysledek = new int[pole.Length];

            //zapamatuju si, kolik hodnot jsem do nej uz dal
            int pocet = 0;

            //projdu puvodni pole
            for (int i = 0; i < pole.Length; i++)
            {
                int prvek = pole[i];
                //kouknu, jestli prvek nebyl driv

                if (!PoleObsahuje(pole, prvek, i))
                {
                    // a kdyz nebyl, pridam
                    vysledek[pocet] = prvek;
                    pocet++;
                }

            }

            //"zmensim"
            return Podpole(vysledek, pocet);
        }

        /// <summary>
        /// Metoda vrátí pole zkrácené na `pocet` prvků
        /// </summary>
        /// <param name="pole"></param>
        /// <param name="pocet"></param>
        /// <returns>zkrácené pole</returns>
        private static int[] Podpole(int[] pole, int pocet)
        {
            int[] zmenseno = new int[pocet];
            for (int i = 0; i < pocet; i++)
            {
                zmenseno[i] = pole[i];
            }
            return zmenseno;
        }

        /// <summary>
        /// Odpovídá, zda se na prvních `limit` pozicích pole nachází hledaný prvek
        /// </summary>
        /// <param name="pole">pole k prohledání</param>
        /// <param name="prvek">hledaný prvek</param>
        /// <param name="limit">počet prohledávaných prvků</param>
        /// <returns>true, pokud najde, jinak false</returns>
        static bool PoleObsahuje(int[] pole, int prvek, int limit)
        {           
            limit = Math.Min(pole.Length, limit);

            for (int i = 0; i < limit; i++)
            {
                if (pole[i] == prvek)
                    return true;
            }
            return false;
        }

        static int[] Sjednoceni(int[] pole1, int[] pole2)
        {
            int[] vysledek = new int[pole1.Length + pole2.Length];
            int pocet;

            //nakopíruju celé první
            for (int i = 0; i < pole1.Length; i++)
            {
                vysledek[i] = pole1[i];
            }
            pocet = pole1.Length;

            //když je třeba, přidám prvky z druhého
            for (int i = 0; i < pole2.Length; i++)
            {
                int prvek = pole2[i];
                if (!PoleObsahuje(pole1, prvek, pole1.Length))
                {
                    vysledek[pocet] = prvek;
                    pocet++;
                }
            }

            return Podpole(vysledek, pocet);
        }
    }
}

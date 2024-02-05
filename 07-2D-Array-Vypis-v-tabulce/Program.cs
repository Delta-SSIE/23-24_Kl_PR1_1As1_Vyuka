

namespace _07_2D_Array_Vypis_v_tabulce
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] cisla = {
            {1, 0, 10, 4, 7},
            {2, 2, 3, 4, 2},
            {6, 5, 4, 3, 2}
        };

            VypisTabulku(cisla);

            Console.WriteLine();

            int[,] cisla2 = {
            {1, 0, 10, 4},
            {2, 2, 3, 4},
            {6, 5, 4, 3},
            {12, 0, 0, -1}
        };

            VypisTabulku(cisla2);
        }

        private static void VypisTabulku(int[,] cisla)
        {
            //umět spočítat "délku" čísla
            //najít v každém sloupci nejdelší

            //sem si budu psát maxima
            int[] maxDelky = new int[cisla.GetLength(1)];

            //projedu všechny sloupce,
            for (int x = 0; x < cisla.GetLength(1); x++)
            {
                int maxDelka = 0;
                //ke každému sloupci všechny řádky
                for (int y = 0; y < cisla.GetLength(0); y++)
                {
                    int delka = DelkaCisla(cisla[y, x]);
                    if (delka > maxDelka)
                        maxDelka = delka;
                }
                maxDelky[x] = maxDelka;
            }

            //při výpisu kždé číslo doplnit na správnou délku
            int delkaTabulky = SoucetPole(maxDelky) + cisla.GetLength(1) + 1;
            Console.WriteLine("".PadLeft(delkaTabulky, '-'));
            for (int y = 0; y < cisla.GetLength(0); y++)
            {
                Console.Write('|');
                for (int x = 0; x < cisla.GetLength(1); x++)
                {
                    Console.Write(DoplnCisloNaDelku(cisla[y,x], maxDelky[x]));
                    Console.Write('|');
                }
                Console.WriteLine();
                Console.WriteLine("".PadLeft(delkaTabulky, '-'));

            }


        }

        private static string DoplnCisloNaDelku(int cislo, int delka)
        {
            return cislo.ToString().PadLeft(delka);
            //int delkaCisla = DelkaCisla(cislo);
            //string doplneno = "";
            //for (int i = 0; i < delka - delkaCisla; i++)
            //{
            //    doplneno += ' ';
            //}
            //return doplneno + cislo;
        }

        static int DelkaCisla(int cislo)
        {
            return cislo.ToString().Length;
            //int delka = 0;
            //if (cislo < 0) { 
            //    delka = 1;
            //    cislo = -cislo;
            //}

            //do
            //{
            //    cislo /= 10;
            //    delka++;
            //} while (cislo != 0);
            
            //return delka;
        }

        static int SoucetPole(int[] pole)
        {
            int soucet = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                soucet += pole[i];
            }
            return soucet;
        }
    }
}

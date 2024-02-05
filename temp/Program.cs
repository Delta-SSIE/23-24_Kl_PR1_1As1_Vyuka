namespace temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] skoky = { 1, 3, 4 };
            //Console.WriteLine(pocetSkokuRekurze(50, skoky));
            Console.WriteLine(pocetSkoku(60, skoky));
        }

        static ulong pocetSkoku(int vzdalenost, int[] skoky)
        {
            ulong[] pocty = new ulong[vzdalenost + 1];
            pocty[0] = 1;
            for (int i = 0; i < pocty.Length; i++)
            {
                ulong pocetSem = pocty[i];
                for (int j = 0; j < skoky.Length; j++)
                {
                    int kdeJsem = i;
                    int delkaSkoku = skoky[j];
                    if (kdeJsem + delkaSkoku <= vzdalenost)
                        pocty[kdeJsem + delkaSkoku] += pocetSem;
                }
            }
            return pocty[vzdalenost];
        }

        static int pocetSkokuRekurze(int vzdalenost, int[] skoky)
        {
            if (vzdalenost == 0)
                return 1;

            int pocet = 0;
            for (int i = 0; i < skoky.Length; i++)
            {
                int skok = skoky[i];
                if (skok <= vzdalenost)
                    pocet += pocetSkokuRekurze(vzdalenost - skok, skoky);
            }
            return pocet;
        }
    }
}

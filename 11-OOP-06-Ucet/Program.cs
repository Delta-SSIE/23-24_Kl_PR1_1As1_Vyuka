namespace _11_OOP_06_Ucet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double urokovaMira = 3;

            Ucet ucet = new Ucet();
            ucet.Uloz(1000);

            int n = 0;
            while(ucet.Zustatek < 2000)
            {
                n++;
                ucet.Urokuj(urokovaMira);
                Console.WriteLine($"{n}. rok - zůstatek {ucet.Zustatek}");
            }


            Ucet hypoteka = new Ucet();
            ucet.Uloz(7_000_000);

            double ulozka = 40_000 * 12;
            double urokovaMira2 = 6;

            n = 0;
            while (ucet.Vyber(ulozka))
            {
                n++;
                ucet.Urokuj(urokovaMira2);
                Console.WriteLine($"{n}. rok - zůstatek {ucet.Zustatek}");
            }

            Console.WriteLine($"celkem zaplaceno {n * ulozka}");


        }
    }
}

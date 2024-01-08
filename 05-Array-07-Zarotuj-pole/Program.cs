namespace _05_Array_07_Zarotuj_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { -6, -7, -1, 3, 0, 1, 3, 5, 9, 8, 10 };
            int posun = 3;

            int pocet = cisla.Length;
            int[] posunuto = new int[pocet];
            for (int odkud = 0; odkud < pocet; odkud++)
            {
                int kam = odkud - posun;
                if (kam < 0)
                    kam += pocet;
                posunuto[kam] = cisla[odkud];
            }

            Console.WriteLine(string.Join(' ', posunuto));
        }
    }
}

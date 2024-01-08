namespace _05_Array_08_Presun_nuly_na_konec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 1, -5, 0, 4, 0, 7, 12, 0, 4 };
            int[] cisla2 = new int[cisla.Length];

            int kam = 0;
            for (int odkud = 0; odkud < cisla.Length; odkud++)
            {
                int cislo = cisla[odkud];
                if (cislo != 0)
                {
                    cisla2[kam] = cislo;
                    kam++;
                }
            }

            Console.WriteLine(string.Join(", ", cisla2));

        }
    }
}

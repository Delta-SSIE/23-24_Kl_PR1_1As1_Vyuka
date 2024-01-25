namespace _05_Array_09_Spojeni_poli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole1 = [1, 2, 3, 4, 5];
            int[] pole2 = [6, 7, 8, 9, 10, 11, 12];

            int[] vysledek = new int[pole1.Length + pole2.Length];
            for (int i = 0, kam = 0; i < Math.Max(pole1.Length, pole2.Length); i++)
            {
                if (i < pole1.Length)
                {
                    vysledek[kam] = pole1[i];
                    kam++;
                }
                if (i < pole2.Length)
                {
                    vysledek[kam] = pole2[i];
                    kam++;
                }
            }
            Console.WriteLine(string.Join(", ", vysledek));

            //nebo

            int[] vysledek2 = new int[pole1.Length + pole2.Length];
            int kratsiDelka = Math.Min(pole1.Length, pole2.Length);
            int vetsiDelka = Math.Max(pole1.Length, pole2.Length);

            for(int i = 0; i < kratsiDelka; i++)
            {
                vysledek2[2*i] = pole1[i];
                vysledek2[2*i + 1] = pole2[i];
            }

            int[] delsiPole = pole1.Length > pole2.Length ? pole1 : pole2;

            for (int i = 0; i < vetsiDelka - kratsiDelka; i++)
            {
                vysledek2[2 * kratsiDelka + i] = delsiPole[kratsiDelka + i];
            }
            Console.WriteLine(string.Join(", ", vysledek2));

        }
    }
}

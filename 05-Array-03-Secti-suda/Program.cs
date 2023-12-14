namespace _05_Array_03_Secti_suda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 4, 0, 0, 7, 5, 0, 1, 2, 0, 3, 1 };

            int vysledek = 0;
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] % 2 == 0)
                    vysledek += cisla[i];
            }
            Console.WriteLine($"Součet sudých v poli je {vysledek}.");
        }
    }
}

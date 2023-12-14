namespace _05_Array_04_Secti_na_sudych_pozicich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 4, 0, 0, 7, 5, 0, 1, 2, 0, 3, 1 };

            //int vysledek = 0;
            //for (int i = 0; i < cisla.Length; i++)
            //{
            //    if (i % 2 == 0)
            //        vysledek += cisla[i];
            //}
            //Console.WriteLine($"Součet na sudých pozicích v poli je {vysledek}.");

            int vysledek = 0;
            for (int i = 0; i < cisla.Length; i+=2)
            {
                vysledek += cisla[i];
            }
            Console.WriteLine($"Součet na sudých pozicích v poli je {vysledek}.");
        }
    }
}

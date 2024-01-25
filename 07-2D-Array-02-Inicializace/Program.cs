namespace _07_2D_Array_02_Inicializace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = [1, 3, 5, 7, 9, 12];

            int[,] tabulka = {
                {0, 1},
                {7, 6},
                {3, 5}
            };

            for (int y = 0; y < tabulka.GetLength(0); y++)
            {
                for (int x = 0; x < tabulka.GetLength(1); x++)
                {
                    Console.Write(tabulka[y, x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

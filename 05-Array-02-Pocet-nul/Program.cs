namespace _05_Array_02_Pocet_nul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 4, 0, 0, 7, 5, 0, 1 , 2, 0, 3, 1};

            int nuly = 0;
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] == 0)
                    nuly++;
            }
            Console.WriteLine($"Celkem je v poli {nuly} nul.");
        }
    }
}

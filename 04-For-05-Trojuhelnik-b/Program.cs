namespace _04_For_05_Trojuhelnik_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vyska = 5;
            char znak = '@';

            for (int y = 0; y < vyska; y++)
            {
                for (int x = 0; x < y + 1; x++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
        }
    }
}

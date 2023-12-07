namespace _04_For_15_Domino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int leva = 0; leva < 7; leva++)
            {
                for (int prava = 0; prava <= leva; prava++)
                {
                    Console.Write($"{leva} | {prava}   ");
                }
                Console.WriteLine();
            }
        }
    }
}

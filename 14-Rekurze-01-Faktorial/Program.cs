namespace _14_Rekurze_01_Faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (ulong i = 0; i < 30; i++)
            {
                Console.WriteLine($"{i}: {Factorial(i)}");
            }
        }

        static ulong Factorial(ulong n)
        {
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}

namespace _05_Array_05_PST_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10000;
            int[] pocty = new int[7];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int hod = rnd.Next(1, 7);
                pocty[hod]++;
            }

            for (int i = 1; i <= 6; i++)
            {
                double pst = Convert.ToDouble(pocty[i]) / n;
                Console.WriteLine($"{i}: {pst}");
            }
        }
    }
}

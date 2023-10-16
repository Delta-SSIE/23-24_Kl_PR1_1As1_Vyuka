namespace _02a_Random_02_Mince
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int hod = random.Next(0, 2);
            if (hod == 0)
                Console.WriteLine("Panna");
            else
                Console.WriteLine("Vorel");

        }
    }
}

namespace _03_While_06_Jak_dlouho_nepadne_sestka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int delka = 1;

            int hod = random.Next(1, 7);

            while(hod != 6)
            {
                hod = random.Next(1, 7);
                delka++;
            }

            Console.WriteLine($"Trvalo to {delka} hodů.");
        }
    }
}

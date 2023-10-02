namespace _02_Podminky_04_Suda_a_licha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 15;

            if (cislo % 2 == 1) // % je zbytek po dělení
            {
                Console.WriteLine($"Číslo {cislo} je liché");
            }
            else
            {
                Console.WriteLine($"Číslo {cislo} je sudé");
            }
        }
    }
}

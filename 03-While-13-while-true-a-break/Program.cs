namespace _03_While_13_while_true_a_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while(true)
            //{
            //    Console.WriteLine("A jede se dokola");
            //}

            //načítám čísla, dokud uživatel nezadá X

            int soucet = 0;
            while(true)
            {
                Console.Write("Zadej další číslo: ");
                string vstup = Console.ReadLine();
                if (vstup.ToUpper() == "X")
                    break;

                if (int.TryParse(vstup, out int cislo))
                {
                    soucet += cislo;
                }
                else
                {
                    Console.WriteLine("Neplatný vstup, zadej číslo nebo 'X'");
                }
            }

            Console.WriteLine($"Součet všech čísel byl {soucet}");
        }
    }
}

namespace _03_While_11_Prumerny_hod_kostkou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik má kostka stěn?");
            string vstup = Console.ReadLine();
            
            int steny;
            while (!int.TryParse(vstup, out steny))
            {
                Console.WriteLine("Chyba vstupu, kolik má kostka stěn?");
                vstup = Console.ReadLine();
            }


            Console.WriteLine("Kolikrát si mám hodit?");
            vstup = Console.ReadLine();

            int hody;
            while (!int.TryParse(vstup, out hody))
            {
                Console.WriteLine("Chyba vstupu, Kolikrát si mám hodit?");
                vstup = Console.ReadLine();
            }

            int pocet = 0;
            int soucet = 0;
            Random rnd = new Random();

            while(pocet < hody)
            {
                int hod = rnd.Next(1, steny + 1);
                soucet += hod;
                pocet++;
            }

            double prumer = ((double)soucet) / pocet;
            Console.WriteLine($"Průměrný hod je {prumer}");
        }
    }
}

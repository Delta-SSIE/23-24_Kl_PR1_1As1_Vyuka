namespace _03_While_15_Serie_sestek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetHodu = 1000;
            int nejdelsiSerie = 0;
            int delkaTetoSerie = 0;
            Random rnd = new Random();

            int i = 0;
            while(i < pocetHodu)
            {
                int cislo = rnd.Next(1, 7);
                if (cislo == 6)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Write(cislo);
                
                if (cislo == 6)
                    delkaTetoSerie++;
                else               
                    delkaTetoSerie = 0;                

                if (nejdelsiSerie < delkaTetoSerie)
                    nejdelsiSerie = delkaTetoSerie;
                
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Nejdelsi serie sestek mela delku " + nejdelsiSerie);
        }
    }
}

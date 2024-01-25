namespace _06_Metody_010_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pozdrav();

            //for (int i = 0; i < 5; i++)
            //{
            //    Pozdrav();
            //}

            //PozdravNekoho("Jene");
            //PozdravNekoho("Karle");
            //PozdravNekoho("Jiřino");

            //string[] koho = { "Jene", "Karle", "Jiřino" };
            //for (int i = 0; i < koho.Length; i++)
            //{
            //    PozdravNekoho(koho[i]);
            //}

            //PozdravVickrat("Karle", 3);
            //PozdravVickrat("Ludmilo", 4);

            int soucet1 = Secti(2, 3);
            Console.WriteLine(soucet1);

            int soucet2 = Secti(Secti(1, 2), Secti(4, 7));
            Console.WriteLine(soucet2);
        }
        static void Pozdrav()
        {
            Console.WriteLine("Nazdar!");
        }
        static void PozdravNekoho(string koho)
        {
            Console.WriteLine($"Ahoj {koho}!");
        }

        static void PozdravVickrat(string koho, int pocet)
        {
            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine($"Ahoj {koho}!");
            }
        }

        static int Secti(int cislo1, int cislo2)
        {
            return cislo1 + cislo2;
        }
    }
}

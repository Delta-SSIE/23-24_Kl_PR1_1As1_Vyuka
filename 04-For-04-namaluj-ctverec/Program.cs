namespace _04_For_04_namaluj_ctverec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Jaká bude strana čtverce?");

            //int strana;
            //while (!int.TryParse(Console.ReadLine(), out strana) || strana < 0)
            //{
            //    Console.WriteLine("Zadej kladné celé číslo");
            //}

            //for (int y = 0; y < strana; y++)
            //{
            //    for (int x = 0; x < strana; x++)
            //    {
            //        Console.Write('#');
            //    }
            //    Console.WriteLine();
            //}

            int sirka = 3;
            int vyska = 5;
            char znak = '#';
           

            for (int y = 0; y < vyska; y++)
            {
                for (int x = 0; x < sirka; x++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
        }
    }
}

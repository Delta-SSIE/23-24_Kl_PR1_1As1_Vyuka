namespace _07_2D_Array_06_Nahodne_rozmisteni
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool[,] mapa = VytvorMapu(4, 4, 12);
            VykresliPole(mapa, 0, 2, '#', ' ');
        }

        static bool[,] VytvorMapu(int vyska, int sirka, int pocetMinci)
        {
            //připrav pole spravne velikosti
            bool[,] mapa = new bool[vyska, sirka];

            //kdyby bylo třeba, dej všude false - ale v C# je tam "by default"

            //připrav random
            Random rnd = new Random();

            //postupně zkoušej umisťovat a odpočítávej si, kolik se už povedlo
            int umistit = pocetMinci;

            while(umistit > 0)
            {
                int x = rnd.Next(sirka);
                int y = rnd.Next(vyska);
                if (!mapa[y,x])
                {
                    mapa[y, x] = true;
                    umistit--;
                }
            }

            return mapa;
        }

        static void VykresliPole(bool[,] mapa, int cursorX, int cursorY, char znakTrue, char znakFalse)
        {
            //Console.WriteLine("╔" + new string('═', mapa.GetLength(1)) + "╗");
            Console.WriteLine("╔" + string.Empty.PadRight(mapa.GetLength(1), '═') + "╗");

            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                Console.Write('║');
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    if (y == cursorY && x == cursorX)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    if (mapa[y, x])
                        Console.Write(znakTrue);
                    else
                        Console.Write(znakFalse);

                    if (y == cursorY && x == cursorX)
                    {
                        Console.ResetColor();
                    }
                }
                Console.WriteLine('║');
            }

            Console.WriteLine("╚" + new string('═', mapa.GetLength(1)) + "╝");
        }
    }
}

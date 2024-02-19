namespace _07_2D_Array_07_Pocty_Sousedu
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            bool[,] mapa =
            {
            { true,  true,  false, false },
            { false, false, true,  true },
            { false, false, false, true },
            { false, false, true,  true },
        };

            //Console.WriteLine(PocetSousedu(mapa, 0, 0)); //mělo by vypsat 1 - levý horní roh sousedí jen s jednou minou
            //Console.WriteLine(PocetSousedu(mapa, 0, 3)); //mělo by vypsat 0 - levý dolní roh s žádnou minou nesousedí
            //Console.WriteLine(PocetSousedu(mapa, 2, 2)); //mělo by vypsat 5

            VypisSousedy(mapa, -1, -1);
            VykresliPole(mapa);
        }

        static int PocetSousedu(bool[,] mapa, int sourX, int sourY)
        {
            int pocet = 0;

            for (int posunY = -1; posunY <= 1; posunY++)
            {
                for (int posunX = -1; posunX <= 1; posunX++)
                {
                    int sousedX = sourX + posunX;
                    int sousedY = sourY + posunY;

                    if
                    (
                        sousedX >= 0 && sousedX < mapa.GetLength(1) //x je v pořádku
                        && sousedY >= 0 && sousedY < mapa.GetLength(0) //y je v pořádku
                        && (posunX != 0 || posunY != 0)
                        && mapa[sousedY, sousedX] == true
                    )
                    {
                        pocet++;
                    }
                }
            }

            return pocet;
        }

        static void VypisSousedy(bool[,] mapa, int cursorX, int cursorY)
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

                    Console.Write(PocetSousedu(mapa, x, y));

                    if (y == cursorY && x == cursorX)
                    {
                        Console.ResetColor();
                    }
                }
                Console.WriteLine('║');
            }

            Console.WriteLine("╚" + new string('═', mapa.GetLength(1)) + "╝");
        }


        static void VykresliPole(bool[,] mapa, int cursorX = -1, int cursorY = -1, char znakTrue = '#', char znakFalse = ' ')
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

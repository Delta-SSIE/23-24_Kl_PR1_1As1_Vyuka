namespace _08_Proj_01_GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] population = Initialize();

            //herní smyčka - zde nekonečná 
            while (true)
            {
                //pauza
                _ = Console.ReadKey(true);

                //population = NextGen(population);
                Render(population);                
            }
        }
        
        static bool[,] Initialize()
        {
            bool[,] population =
            {
                { true, true, false, true, false },
                { true, false, false, false, false },
                { true, false, false, false, true },
                { false, true, true, true, false },
                { false, true, false, false, false },
            };

            return population;
        }

        static bool[,] NextGen(bool[,] currentGen)
        {
            //připrav pole pro příští populaci
            bool[,] next = new bool[currentGen.GetLength(0),currentGen.GetLength(1)];

            //procházej po buňkách
            for (int y = 0; y < currentGen.GetLength(0); y++)
            {
                for (int x = 0; x < currentGen.GetLength(1); x++)
                {
                    //ke každé spočítej sousedy


                    //aplikuj pravidla a zapiš do příští
                }

            }

            //vrať
            return next;
        }

        static void Render
        (
            bool[,] mapa, 
            char znakTrue = '#', 
            char znakFalse = ' ', 
            int cursorX = -1, 
            int cursorY = -1
        )
        {
            Console.Clear();

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

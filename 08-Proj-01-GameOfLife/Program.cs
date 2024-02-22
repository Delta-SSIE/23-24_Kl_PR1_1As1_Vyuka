using System.Runtime.InteropServices;

namespace _08_Proj_01_GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sleep = 500; //milisekundy

            //bool[,] population = Initialize();
            bool[,] population = LoadFile("cells.txt");
            //bool[,] population = LoadFile("corner.txt");
            //bool[,] population = LoadFile("glider.txt");

            InteractiveEdit(population); //pozor, mění se pole tzv. in-place

            //herní smyčka - zde nekonečná 
            while (true)
            {

                System.Threading.Thread.Sleep(sleep);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                        InteractiveEdit(population);
                }

                population = NextGen(population);
                Render(population);
            }
        }

        private static void InteractiveEdit(bool[,] population)
        {
            int cursorX = population.GetLength(1) / 2;
            int cursorY = population.GetLength(0) / 2;

            //smyčka, ve které se načítá, dokud nepřijde příkaz "konec"
            while (true)
            {
                Render(population, cursorX, cursorY);

                //načti klávesu
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    cursorX--;
                    if (cursorX < 0)
                        cursorX += population.GetLength(1);
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    cursorX++;
                    if (cursorX >= population.GetLength(1))
                        cursorX -= population.GetLength(1);

                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    cursorY--;
                    if (cursorY < 0)
                        cursorY += population.GetLength(0);

                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    cursorY++;
                    if (cursorY >= population.GetLength(0))
                        cursorY -= population.GetLength(0);
                }
                else if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    //přehodit bool na souřadnicích kurzoru
                    population[cursorY, cursorX] = !population[cursorY, cursorX];
                }
                else if (keyInfo.Key == ConsoleKey.Q)
                {
                    //skonči s editací
                    break;
                }

            }
        }

        static bool[,] Initialize()
        {
            bool[,] population =
            {
                //{ true, true, false, true, false },
                //{ true, false, false, false, false },
                //{ true, false, false, false, true },
                //{ false, true, true, true, false },
                //{ false, true, false, false, false },
                { false, false, false, false, false },
                { false, false, false, false, false },
                { false, true, true, true, false },
                { false, false, false, false, false },
                { false, false, false, false, false },

            };

            return population;
        }

        static bool[,] LoadFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            int height = lines.Length; //počet řádků = výška

            int width = lines[0].Length; //počet sloupců = počet znaků v prvním řádku = šířka

            bool[,] population = new bool[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    char letter = lines[y][x];
                    population[y, x] = (letter == '#'); 
                }
            }

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
                    int neighbours = GetNeighbours(currentGen, x, y);

                    //aplikuj pravidla a zapiš do příští
                    bool isAlive = NextCellState(currentGen, y, x, neighbours);

                    next[y, x] = isAlive;
                }
            }

            //vrať
            return next;
        }

        private static bool NextCellState(bool[,] currentGen, int y, int x, int neighbours)
        {
            bool isAlive;
            if (currentGen[y, x] == true) //teď je živá
            {
                isAlive = neighbours == 2 || neighbours == 3; //bude živá pro 2 nebo tři sousedy
            }
            else
            {
                isAlive = neighbours == 3; //obživne pro právě 3 sousedy
            }

            return isAlive;
        }
        static void Render
        (
            bool[,] mapa,
            int cursorX = -1,
            int cursorY = -1,
            char znakTrue = '#',
            char znakFalse = ' '
        )
        {
            //místo Console.Clear();
            Console.SetCursorPosition(0, 0);
            
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

        static int GetNeighbours(bool[,] population, int coordX, int coordY)
        {
            int pocet = 0;

            for (int posunY = -1; posunY <= 1; posunY++)
            {
                for (int posunX = -1; posunX <= 1; posunX++)
                {
                    int sousedX = coordX + posunX;
                    int sousedY = coordY + posunY;

                    if (sousedX < 0)
                        sousedX += population.GetLength(1); //zleva se posunu na pravý kraj
                    else if (sousedX >= population.GetLength(1))
                        sousedX -= population.GetLength(1); //zprava se posunu doleva

                    if (sousedY < 0)
                        sousedY += population.GetLength(0); //zdola nahoru a naopak
                    else if (sousedY >= population.GetLength(0))
                        sousedY -= population.GetLength(0);

                    if
                    (
                        (posunX != 0 || posunY != 0) //nejsem sám na sobě
                        && population[sousedY, sousedX] == true
                    )
                    {
                        pocet++;
                    }
                }
            }

            return pocet;
        }

        //static int GetNeighbours(bool[,] population, int coordX, int coordY)
        //{
        //    int pocet = 0;

        //    for (int posunY = -1; posunY <= 1; posunY++)
        //    {
        //        for (int posunX = -1; posunX <= 1; posunX++)
        //        {
        //            int sousedX = coordX + posunX;
        //            int sousedY = coordY + posunY;

        //            if
        //            (
        //                sousedX >= 0 && sousedX < population.GetLength(1) //x je v pořádku
        //                && sousedY >= 0 && sousedY < population.GetLength(0) //y je v pořádku
        //                && (posunX != 0 || posunY != 0)
        //                && population[sousedY, sousedX] == true
        //            )
        //            {
        //                pocet++;
        //            }
        //        }
        //    }

        //    return pocet;
        //}
    }
}

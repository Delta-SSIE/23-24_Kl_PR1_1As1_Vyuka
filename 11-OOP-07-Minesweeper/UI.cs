using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_07_Minesweeper
{
    internal class UI
    {
        private int _width;
        private int _height;

        private const char _flagChar = 'P';
        private const char _mineChar = '*';
        private const char _coveredChar = '#';
        private const char _zeroChar = ' ';



        public Coords Cursor { get; private set; }

        public UI(int width, int height)
        {
            _width = width;
            _height = height;
            Cursor = new Coords ( width / 2,  height / 2 );
        }

        public void Render(Tile[,] tiles)
        {
            Console.Clear();

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    Tile tile = tiles[y, x];
                    RenderTile(tile);
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(Cursor.X, Cursor.Y);
        }

        private void RenderTile(Tile tile)
        {
            if (tile.IsUncovered)
            {
                if (tile.IsMine)
                    Console.Write(_mineChar);
                else if (tile.Neighbours > 0)
                    Console.Write(tile.Neighbours);
                else
                    Console.Write(_zeroChar);
            }
            else if (tile.HasFlag)
            {
                Console.Write(_flagChar);
            }
            else
            {
                Console.Write(_coveredChar);
            }
        }

        public UserAction GetUserAction()
        {
            while (true)
            {
                int newX = 0, newY = 0;
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Spacebar:
                        return UserAction.Uncover;

                    case ConsoleKey.P:
                        return UserAction.ToggleFlag;

                    case ConsoleKey.DownArrow:
                        newY = Cursor.Y + 1;
                        if (newY >= _height)
                            newY = 0;
                        Cursor = new Coords(Cursor.X, newY);
                        break;

                    case ConsoleKey.UpArrow:
                        newY = Cursor.Y - 1;
                        if (newY < 0)
                            newY = _height - 1;
                        Cursor = new Coords(Cursor.X, newY);
                        break;

                    case ConsoleKey.LeftArrow:
                        newX = Cursor.X - 1;
                        if (newX < 0)
                            newX = _width - 1;
                        Cursor = new Coords(newX, Cursor.Y);
                        break;

                    case ConsoleKey.RightArrow:
                        newX = Cursor.X + 1;
                        if (newX >= _width)
                            newX = 0;
                        Cursor = new Coords(newX, Cursor.Y);
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_07_Minesweeper
{
    internal class Game
    {
        private int _width;
        private int _height;
        private int _mineCnt;

        private UI _userInterface;

        private Tile[,] _board;

        public Game(int width, int height, int mineCnt)
        {
            //inicializace hry
            _width = width;
            _height = height;
            _mineCnt = mineCnt;

            _userInterface = new UI(_width, _height);

            MakeBoard();
            CountAllNeighbours();
        }

        /// <summary>
        /// Projde celý herní plán a ke každé mině zapíše, kolik má sousedů
        /// </summary>        
        private void CountAllNeighbours()
        {
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    CountTileNeighbours(x, y);
                }
            }
        }

        private void CountTileNeighbours(int x, int y)
        {
            int neighbourX, neighbourY;
            int count = 0;

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0)
                        continue;

                    neighbourX = x + dx;
                    neighbourY = y + dy;

                    if 
                    (
                        neighbourX >= 0
                        && neighbourY >= 0
                        && neighbourX < _width
                        && neighbourY < _height
                        && _board[neighbourY, neighbourX].IsMine
                    )
                        count++;
                }
            }

            _board[y,x].Neighbours = count;
        }

        private void MakeBoard()
        {
            Random random = new Random();
            _board = new Tile[_height, _width];

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    _board[y, x] = new Tile(false); //na začátku nikde mina
                }
            }

            int minesToPlace = _mineCnt; //kolik min ještě umístit?
            while (minesToPlace > 0)
            {
                int y = random.Next(_height);
                int x = random.Next(_width);
                
                if (!_board[y, x].IsMine) //když tam není mina
                {
                    _board[y, x] = new Tile(true); //tak ji tam dám
                    minesToPlace--;
                }
            }
        }

        public void GameLoop()
        {
            Tile tile;
            VictoryState state = GetState();
            
            //kresli
            _userInterface.Render(_board);

            while (state == VictoryState.Undefined)
            {
                //načti akci
                UserAction action = _userInterface.GetUserAction();

                //proveď
                tile = _board[_userInterface.Cursor.Y, _userInterface.Cursor.X];

                switch (action)
                {
                    case UserAction.ToggleFlag:
                        tile.ToggleFlag();
                        break;
                    case UserAction.Uncover:
                        tile.Uncover();
                        break;
                }

                //kresli
                _userInterface.Render(_board);

                //kontroluj
                state = GetState();
            }

            //reportuj výsledek
            _userInterface.ReportResult(state);
        }

        //projde všechna políčka a zjistí, jaký je stav hry
        private VictoryState GetState()
        {
            //celkový stav
            VictoryState overallState = VictoryState.Win;
            VictoryState tileState;

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    tileState = _board[y, x].State; //stav dlaždice
                    if (tileState == VictoryState.Loose)
                    {
                        return VictoryState.Loose;
                    }
                    else if (tileState == VictoryState.Undefined)
                    {
                        overallState = VictoryState.Undefined;
                    }
                }
            }

            return overallState; //buď výhra, když nebylo žádné pole s chybou, nebo nerozhodnuto
        }
    }
}

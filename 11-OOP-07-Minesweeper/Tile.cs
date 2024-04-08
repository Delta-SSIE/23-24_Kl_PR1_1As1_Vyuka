using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_07_Minesweeper
{
    internal class Tile
    {
        public bool IsMine { get; private set; }
        public bool HasFlag { get; private set; }
        public bool IsUncovered { get; private set; }
        public int Neighbours { get; set; }

        public VictoryState State { 
            get 
            {
                if (IsUncovered && IsMine)
                    return VictoryState.Loose;

                else if (IsMine && HasFlag)
                    return VictoryState.Win;

                else if (!IsMine && !HasFlag)
                    return VictoryState.Win;

                else
                    return VictoryState.Undefined;
            } 
        }

        public Tile(bool isMine)
        {
            IsMine = isMine;
        }

        public void ToggleFlag ()
        {
            if (IsUncovered) //na odkryté mině se praporek nedá měnit
                return;

            HasFlag = !HasFlag;
        }

        public void Uncover()
        {
            if (IsUncovered || HasFlag) //odkryté a opraporkované neodkryjeme
                return;

            IsUncovered = true;
        }
    }
}

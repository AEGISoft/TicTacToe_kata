using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal class BottomRow:WinningCondition
    {
        public BottomRow()
        {


            S1 = Square.SouthWest;  S2 = Square.South;  S3 = Square.SouthEast;
        }
    }
}
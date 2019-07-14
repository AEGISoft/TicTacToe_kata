using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal class TopRow:WinningCondition
    {
        public TopRow()
        {                                                   
            S1 = Square.NorthWest;  S2 = Square.North;      S3 = Square.NorthEast;


        }
    }
}
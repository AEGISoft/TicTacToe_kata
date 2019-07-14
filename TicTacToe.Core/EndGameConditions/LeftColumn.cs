using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal class LeftColumn:WinningCondition
    {
        public LeftColumn()
        {
            S1 = Square.NorthWest;
            S2 = Square.West;
            S3 = Square.SouthWest;
        }
    }
}
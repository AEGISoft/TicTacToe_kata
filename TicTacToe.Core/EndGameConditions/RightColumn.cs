using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal class RightColumn:WinningCondition
    {
        public RightColumn()
        {
                                                            S1 = Square.NorthEast;
                                                            S2 = Square.East;
                                                            S3 = Square.SouthEast;
        }
    }
}
using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal class CenterColumn:WinningCondition
    {
        public CenterColumn()
        {
                                    S1 = Square.North;
                                    S2 = Square.Center;
                                    S3 = Square.South;
        }
    }
}
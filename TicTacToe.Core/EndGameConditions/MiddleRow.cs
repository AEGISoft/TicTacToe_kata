using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal class MiddleRow:WinningCondition
    {
        public MiddleRow()
        {
                                                            
            S1 = Square.West;       S2 = Square.Center;     S3 = Square.East;

        }
    }
}
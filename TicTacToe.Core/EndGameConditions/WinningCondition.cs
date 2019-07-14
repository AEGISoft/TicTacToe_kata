using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal class WinningCondition
    {
        protected Square S1, S2, S3;

        public bool AppearsIn(MarkedSquares markedSquares)
        {
            return markedSquares.Contains(S1)
                   && markedSquares.Contains(S2)
                   && markedSquares.Contains(S3);
        }
    }
}
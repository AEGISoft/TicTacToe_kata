using System.Collections.Generic;
using System.Linq;
using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal static class WinningConditions
    {
        public static bool AppearIn(MarkedSquares markedSquares)
        {
            return AllWinningConditions.Any(winningCondition => winningCondition.AppearsIn(markedSquares));
        }

        private static IEnumerable<WinningCondition> AllWinningConditions => new List<WinningCondition>
        {                                                   
            new TopRow(),
            new MiddleRow(),
            new BottomRow(),

            new LeftColumn(),
            new CenterColumn(),
            new RightColumn(),

            new ForwardDiagonal(),
            new BackwardDiagonal()
        };
    }
}
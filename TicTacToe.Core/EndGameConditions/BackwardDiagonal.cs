using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal class BackwardDiagonal:WinningCondition
    {
        public BackwardDiagonal()
        {
            S1 = Square.NorthWest;
                                    S2 = Square.Center;
                                                            S3 = Square.SouthEast;
        }
    }
}
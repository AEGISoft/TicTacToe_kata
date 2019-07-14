using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.EndGameConditions
{
    internal class ForwardDiagonal:WinningCondition
    {
        public ForwardDiagonal()
        {
                                                            S3 = Square.NorthEast;
                                    S2 = Square.Center;
            S1 = Square.SouthWest;
        }
    }
}
using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.GameStates
{
    public interface IGameState
    {
        Board Mark(Square square);
    }
}
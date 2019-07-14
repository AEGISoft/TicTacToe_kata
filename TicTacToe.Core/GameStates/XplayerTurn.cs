using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.GameStates
{
    public class XplayerTurn : IGameState
    {
        #region construction
        private readonly Board _board;

        internal XplayerTurn(Board board)
        {
            _board = board;
        }
        #endregion

        #region GameState implementation
        public Board Mark(Square square)
        {
            return _board.Having_marked_x_on(square);
        }
        #endregion
    }
}
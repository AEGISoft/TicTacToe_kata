using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.GameStates
{
    public class OplayerTurn : IGameState
    {
        #region construction
        private readonly Board _board;

        internal OplayerTurn(Board board)
        {
            _board = board;
        }
        #endregion

        #region GameState implementation
        public Board Mark(Square square)
        {
            return _board.Having_marked_o_on(square);
        }
        #endregion
    }
}
using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core.GameStates
{
    public class GameEnded : IGameState
    {
        #region construction
        private readonly Board _board;

        public GameEnded(Board board)
        {
            _board = board;
        }
        #endregion

        #region GameState implementation
        public Board Mark(Square square)
        {
            return _board;
        }
        #endregion
    }

    public class GameEndedWithXasWinner : GameEnded
    {
        internal GameEndedWithXasWinner(Board board) : base(board) { }
    }
    public class GameEndedWithOasWinner : GameEnded
    {
        internal GameEndedWithOasWinner(Board board) : base(board) { }
    }
    public class GameEndedInDraw : GameEnded
    {
        internal GameEndedInDraw(Board board) : base(board) { }
    }
}
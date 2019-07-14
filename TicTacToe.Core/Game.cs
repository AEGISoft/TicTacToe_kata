using TicTacToe.Core.BoardElements;
using TicTacToe.Core.GameStates;

namespace TicTacToe.Core
{
    public class Game
    {
        #region construction
        private readonly IGameState _gameState;

        public Game():this(new Board(), new BoardHistory()) { }
        private Game(Board board, BoardHistory history)
        {
            History = history;

            History.Add(board);
            _gameState = board.DeriveGameState();
        }
        #endregion

        public BoardHistory History { get; }

        public Game Play(Square square)
        {
            return new Game(_gameState.Mark(square), History);
        }
    }
}
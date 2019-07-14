using TicTacToe.Core.GameStates;
using TicTacToe.Core.EndGameConditions;

namespace TicTacToe.Core.BoardElements
{
    public class Board
    {
        #region construction
        private readonly MarkedSquares _squaresMarkedWithX;
        private readonly MarkedSquares _squaresMarkedWithO;

        public Board()
        {
            _squaresMarkedWithX = new MarkedSquares();
            _squaresMarkedWithO = new MarkedSquares();
        }

        private Board(MarkedSquares xs, MarkedSquares os)
        {
            _squaresMarkedWithX = xs;
            _squaresMarkedWithO = os;
        }

        private static Board NewBoardWithXMarkedSquaresHavingAdded(Square square, Board board)
        {
            return new Board(board._squaresMarkedWithX.HavingAdded(square), board._squaresMarkedWithO);
        }
        private static Board NewBoardWithOMarkedSquaresHavingAdded(Square square, Board board)
        {
            return new Board(board._squaresMarkedWithX, board._squaresMarkedWithO.HavingAdded(square));
        }
        #endregion

        public Board Having_marked_x_on(Square square)
        {
            if (IllegalMoveOn(square)) return this;

            return NewBoardWithXMarkedSquaresHavingAdded(square, this);
        }

        public Board Having_marked_o_on(Square square)
        {
            if (IllegalMoveOn(square)) return this;

            return NewBoardWithOMarkedSquaresHavingAdded(square, this);
        }

        public IGameState DeriveGameState()
        {
            if (WinningConditions.AppearIn(_squaresMarkedWithX)) return new GameEndedWithXasWinner(this);
            if (WinningConditions.AppearIn(_squaresMarkedWithO)) return new GameEndedWithOasWinner(this);
            if (IsFull) return new GameEndedInDraw(this);
            if (Has_as_many_x_as_o_marks) return new XplayerTurn(this);

            return new OplayerTurn(this);
        }

        public bool IsEqualTo(Board other)
        {
            if (ReferenceEquals(this, other)) return true;

            if (ReferenceEquals(null, other)) return false;
            if (!_squaresMarkedWithX.IsEqualTo(other._squaresMarkedWithX)) return false;
            if (!_squaresMarkedWithO.IsEqualTo(other._squaresMarkedWithO)) return false;

            return true;
        }

        #region private parts

        private bool IllegalMoveOn(Square square)
        {
            if (_squaresMarkedWithX.Contains(square)) return true;
            if (_squaresMarkedWithO.Contains(square)) return true;

            return false;
        }

        private bool IsFull => _squaresMarkedWithX.Count == 5;

        private bool Has_as_many_x_as_o_marks => _squaresMarkedWithX.Count 
                                              == _squaresMarkedWithO.Count;
        #endregion
    }
} 
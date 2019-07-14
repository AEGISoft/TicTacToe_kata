using System.Collections.Generic;

namespace TicTacToe.Core.BoardElements
{
    internal class MarkedSquares
    {
        #region construction
        private readonly List<Square> _markedSquares;

        public MarkedSquares()
        {
            _markedSquares = new List<Square>();
        }

        private MarkedSquares(List<Square> squares)
        {
            _markedSquares = squares;
        }
        #endregion

        public int Count => _markedSquares.Count;

        public MarkedSquares HavingAdded(Square square)
        {
            return new MarkedSquares(new List<Square>(_markedSquares) {square});
        }

        public bool Contains(Square square)
        {
            return _markedSquares.Contains(square);
        }

        public bool IsEqualTo(MarkedSquares other)
        {
            if (ReferenceEquals(this, other)) return true;

            if (ReferenceEquals(null, other)) return false;
            foreach (var markedSquare in _markedSquares)
            {
                if (!other._markedSquares.Contains((markedSquare))) return false;
            }
            return true;
        }
    }
}
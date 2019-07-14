using System.Collections.Generic;
using System.Linq;
using TicTacToe.Core.BoardElements;

namespace TicTacToe.Core
{
    public class BoardHistory
    {
        #region construction
        private readonly List<Board> _boards;

        public BoardHistory()
        {
            _boards = new List<Board>();
        }

        #endregion

        public Board LastBoard => _boards.Last();

        public void Add(Board board)
        {
            _boards.Add(board);
        }
    }
}
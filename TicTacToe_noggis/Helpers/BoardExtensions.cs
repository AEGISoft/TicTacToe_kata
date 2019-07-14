using TicTacToe.Core.BoardElements;

namespace TicTacToe.CoreTests.Helpers
{
    public static class BoardExtensions
    {
        public static BoardAssertions Should(this Board instance)
        {
            return new BoardAssertions(instance);
        }
    }
}
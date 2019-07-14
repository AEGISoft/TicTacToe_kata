using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using TicTacToe.Core.BoardElements;

namespace TicTacToe.CoreTests.Helpers
{
    public class BoardAssertions : ReferenceTypeAssertions<Board, BoardAssertions>
    {
        public BoardAssertions(Board instance)
        {
            Subject = instance;
        }

        protected override string Identifier => "board";

        public void Be(Board expected)
        {
            Execute.Assertion
                .Given(()=> Subject)
                .ForCondition(b => b.IsEqualTo(expected))
                .FailWith($"Expected {expected} but found {Subject}");
        }
    }
}
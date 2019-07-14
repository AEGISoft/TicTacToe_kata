using TicTacToe.Core;
using TicTacToe.Core.BoardElements;
using TicTacToe.CoreTests.Helpers;
using Xunit;

namespace TicTacToe.CoreTests
{
    public class When_first_player_opens
    {

        [Theory]
        [InlineData(Square.NorthWest)]
        [InlineData(Square.North)]
        [InlineData(Square.NorthEast)]

        [InlineData(Square.West)]
        [InlineData(Square.Center)]
        [InlineData(Square.East)]

        [InlineData(Square.SouthWest)]
        [InlineData(Square.South)]
        [InlineData(Square.SouthEast)]
        public void Board_should_mark_that_square_with_an_x(Square square)
        {
            //Arrange
            var game = new Game();

            //Act
            game
                .Play(square);

            //Assert
            game.History.LastBoard.Should().Be
            (new Board()
                    .Having_marked_x_on(square)
            );
        }
    }
}
using TicTacToe.Core;
using TicTacToe.Core.BoardElements;
using TicTacToe.CoreTests.Helpers;
using Xunit;

namespace TicTacToe.CoreTests
{
    public class When_first_player_plays_again_on_an_unmarked_square
    {
        [Fact]
        public void Board_should_mark_that_square_with_an_X()
        {
            //Arrange
            var game = new Game()
                .Play(Square.NorthWest)
                .Play(Square.South);

            //Act
            game
                .Play(Square.North);

            //Assert
            game.History.LastBoard.Should().Be
            (new Board()
                    .Having_marked_x_on(Square.NorthWest)
                    .Having_marked_o_on(Square.South)
                    .Having_marked_x_on(Square.North)
            );
        }

    }
}
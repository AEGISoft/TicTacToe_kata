using TicTacToe.Core;
using TicTacToe.Core.BoardElements;
using TicTacToe.Core.GameStates;
using TicTacToe.CoreTests.Helpers;
using Xunit;

namespace TicTacToe.CoreTests
{
    public class When_second_player_plays_an_unmarked_square
    {
        [Fact]
        public void Board_should_mark_that_square_with_an_O()
        {
            //Arrange
            var game = new Game()
                .Play(Square.NorthWest);

            //Act
            game.Play(Square.South);

            //Assert
            game.History.LastBoard.Should().Be
            (new Board()
                    .Having_marked_x_on(Square.NorthWest)
                    .Having_marked_o_on(Square.South)
                );
            game.History.LastBoard.DeriveGameState().Should().BeOfType<XplayerTurn>();
        }
    }
}
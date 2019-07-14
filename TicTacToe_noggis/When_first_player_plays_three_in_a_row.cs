using TicTacToe.Core;
using TicTacToe.Core.BoardElements;
using TicTacToe.Core.GameStates;
using TicTacToe.CoreTests.Helpers;
using Xunit;

namespace TicTacToe.CoreTests
{
    public class When_first_player_plays_three_in_a_row
    {
        [Theory]
        [InlineData(Square.NorthWest, Square.North, Square.NorthEast, Square.SouthWest, Square.South)]
        [InlineData(Square.West, Square.Center, Square.East, Square.SouthWest, Square.South)]
        [InlineData(Square.SouthWest, Square.South, Square.SouthEast, Square.West, Square.Center)]

        [InlineData(Square.NorthWest, Square.West, Square.SouthWest, Square.East, Square.SouthEast)]
        [InlineData(Square.North, Square.Center, Square.South, Square.East, Square.SouthEast)]
        [InlineData(Square.NorthEast, Square.East, Square.SouthEast, Square.West, Square.SouthWest)]

        [InlineData(Square.NorthWest, Square.Center, Square.SouthEast, Square.West, Square.East)]
        [InlineData(Square.NorthEast, Square.Center, Square.SouthWest, Square.West, Square.East)]
        public void He_is_the_winner(Square x1, Square x2, Square x3, Square o1, Square o2)
        {
            //Arrange
            var game = new Game()
                .Play(x1)     .Play(o1)
                .Play(x2)     .Play(o2);

            //Act
            game
                .Play(x3);

            //Assert
            game.History.LastBoard.DeriveGameState().Should().BeOfType<GameEndedWithXasWinner>();
        }

    }
}
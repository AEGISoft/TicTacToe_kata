using TicTacToe.Core;
using TicTacToe.Core.BoardElements;
using TicTacToe.Core.GameStates;
using TicTacToe.CoreTests.Helpers;
using Xunit;

namespace TicTacToe.CoreTests
{
    public class When_second_player_plays_three_in_a_row
    {
        [Theory]
        [InlineData(Square.South, Square.SouthWest, Square.West, Square.NorthWest, Square.North, Square.NorthEast)]
        [InlineData(Square.South, Square.SouthWest, Square.North, Square.West, Square.Center, Square.East)]
        [InlineData(Square.North, Square.NorthWest, Square.West, Square.SouthWest, Square.South, Square.SouthEast)]

        [InlineData(Square.South, Square.SouthEast, Square.East, Square.NorthWest, Square.West, Square.SouthWest)]
        [InlineData(Square.West, Square.SouthEast, Square.East, Square.North, Square.Center, Square.South)]
        [InlineData(Square.North, Square.NorthWest, Square.West, Square.NorthEast, Square.East, Square.SouthEast)]

        [InlineData(Square.West, Square.SouthWest, Square.South, Square.NorthWest, Square.Center, Square.SouthEast)]
        [InlineData(Square.South, Square.SouthEast, Square.East, Square.NorthEast, Square.Center, Square.SouthWest)]
        public void He_is_the_winner(Square x1, Square x2, Square x3, Square o1, Square o2, Square o3)
        {
            //Arrange
            var game = new Game()
                .Play(x1)     .Play(o1)
                .Play(x2)     .Play(o2)
                .Play(x3);

            //Act
            game
                .Play(o3);

            //Assert
            game.History.LastBoard.DeriveGameState().Should().BeOfType<GameEndedWithOasWinner>();
        }
    }
    public class When_board_is_full_and_no_player_has_three_in_a_row
    {
        [Theory]
        [InlineData(
            Square.SouthWest, Square.West, Square.North, Square.East, Square.SouthEast, 
            Square.NorthWest, Square.NorthEast, Square.Center, Square.South)]
        public void Game_ends_in_a_draw(Square x1, Square x2, Square x3, Square x4, Square x5, Square o1, Square o2, Square o3, Square o4)
        {
            //Arrange
            var game = new Game()
                .Play(x1)     .Play(o1)
                .Play(x2)     .Play(o2)
                .Play(x3)     .Play(o3)
                .Play(x4)     .Play(o4);

            //Act
            game
                .Play(x5);

            //Assert
            game.History.LastBoard.DeriveGameState().Should().BeOfType<GameEndedInDraw>();
        }
    }
}
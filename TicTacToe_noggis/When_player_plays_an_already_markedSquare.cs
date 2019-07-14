using TicTacToe.Core;
using TicTacToe.Core.BoardElements;
using TicTacToe.CoreTests.Helpers;
using Xunit;

namespace TicTacToe.CoreTests
{
    public class When_player_plays_an_already_markedSquare
    {
        [Theory]
        [InlineData(Square.South, Square.South)]
        [InlineData(Square.NorthWest, Square.South, Square.South)]
        public void Board_should_ignore_this(params Square[] squaresTriedToPlay)
        {
            //Arrange
            var game = new Game();
            var nrOfSquaresTriedToPlay = squaresTriedToPlay.Length -1;
            for (var i = 0; i < nrOfSquaresTriedToPlay; i++)
            {
                game.Play(squaresTriedToPlay[i]);
            }

            var previousBoard = game.History.LastBoard;
            var previousGameState = previousBoard.DeriveGameState();

            //Act
            game.Play(squaresTriedToPlay[nrOfSquaresTriedToPlay]);

            //Assert
            game.History.LastBoard.Should().Be(previousBoard);
            game.History.LastBoard.DeriveGameState().Should().Be(previousGameState);
        }
    }
}
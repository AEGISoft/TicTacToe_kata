using TicTacToe.Core.GameStates;

namespace TicTacToe.CoreTests.Helpers
{
    public static class GameStateExtensions
    {
        public static GameStateAssertions Should(this IGameState instance)
        {
            return new GameStateAssertions(instance);
        }
    }
}
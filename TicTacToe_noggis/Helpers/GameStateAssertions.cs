using System;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using TicTacToe.Core.GameStates;

namespace TicTacToe.CoreTests.Helpers
{
    public class GameStateAssertions: ReferenceTypeAssertions<IGameState, GameStateAssertions>
    {
        public GameStateAssertions(IGameState instance)
        {
            Subject = instance;
        }

        protected override string Identifier => "GameState";

        public void BeOfType<T>()
        {
            Execute.Assertion
                .Given(() => Subject)
                .ForCondition(b => b.GetType() == typeof(T))
                .FailWith($"Expected '{typeof(T).Name}'{Environment.NewLine} " +
                          $"              but found '{Subject.GetType().Name}'");
        }

        public void Be(IGameState expected)
        {
            Execute.Assertion
                .Given(() => Subject)
                .ForCondition(b => b.GetType() == expected.GetType())
                .FailWith($"Expected '{Subject.GetType().Name}'{Environment.NewLine} " + 
                  $"              but found '{expected.GetType().Name}'");
        }
    }
}
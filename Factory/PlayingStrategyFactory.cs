using System;
using TicTacToe.Constants;
using TicTacToe.Strategies;

namespace TicTacToe.Factory
{
    public class PlayingStrategyFactory
    {
         

        internal static PlayingStragegy GetPlayingDifficulty(DifficultyLevel difficultyLevel)
        {
            if(difficultyLevel == DifficultyLevel.EASY)
            {
                return new EasyPlayingStrategy();
            }
            return new EasyPlayingStrategy();
        }
    }
}
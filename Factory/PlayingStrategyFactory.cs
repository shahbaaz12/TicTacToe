using System;
using TicTacToe.Constants;
using TicTacToe.Strategies;

namespace TicTacToe.Factory
{
    public class PlayingStrategyFactory
    {
         

        internal static PlayingStragegy GetPlayingDifficulty(DIFFICULTY_LEVEL difficultyLevel)
        {
            if(difficultyLevel == DIFFICULTY_LEVEL.EASY)
            {
                return new EasyPlayingStrategy();
            }
            else if(difficultyLevel == DIFFICULTY_LEVEL.MED)
            {
                return  new MediumPlayingStrategy();
            }
            return new EasyPlayingStrategy();
        }
    }
}
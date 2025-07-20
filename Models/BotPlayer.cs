using System;
using TicTacToe.Constants;
using TicTacToe.Controllers;
using TicTacToe.Factory;
using TicTacToe.Strategies;

namespace TicTacToe.Models
{
    public class BotPlayer : Player
    {
        private PlayingStragegy playingStrategy;
        private DifficultyLevel difficultyLevel;

        public BotPlayer(int id, string name, PLAYER_TYPES pt, Symbol sym, DifficultyLevel dff) : base(id, name, pt, sym)
        {

            playingStrategy = PlayingStrategyFactory.GetPlayingDifficulty(difficultyLevel);
            this.difficultyLevel = dff;

        }

        public override Move MakeMove(Board board)
        {
            Console.WriteLine($"Player {Name}, make your move:");

            var move =  this.playingStrategy.MakeMove(board);
            move.Player = this;
            move.Cell.Symbol = this.symbol;
            return move;
        }
    }
}
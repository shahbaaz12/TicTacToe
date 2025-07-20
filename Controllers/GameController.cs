using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Constants;
using TicTacToe.Factory;
using TicTacToe.Models;
using TicTacToe.Strategies;

namespace TicTacToe.Controllers
{
    internal class GameController
    {
        internal Game CreateGame()
        {
            Console.WriteLine("--- TIC TAC TOE ---");
            Console.WriteLine("Enter Player 1 Name:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter Player 2 Name:");
            string name2 = Console.ReadLine();

            var p1 =   PlayerBuilder.Create()
                .SetId(1)
                .SetName(name1)
                .SetPlayerType(PLAYER_TYPES.HUMAN)
                 .SetPlayerSymbol(SYMBOLS.CROSS)
                .Build();

            var p2 =  PlayerBuilder.Create()
                .SetId(2)
                .SetName(name2)
                .SetPlayerType(PLAYER_TYPES.BOT)
                .SetPlayerSymbol(SYMBOLS.ZERO)
                .SetDifficultyIfBot(DIFFICULTY_LEVEL.MED)
                .Build();

            var players = new List<Player> { p1, p2 };

            var game = Game.GameBuilder.Create()
                .SetBoardSize(3)
                .SetPlayers(players)
                .SetWinningStrategies(new List<Strategies.WinningStrategy>{ new RowWinningStrategy(), new ColWinningStrategy() })
                .Build();

            return game;
        }

        public void DisplayBoard(Game game)
        {
            game.DisplayBoard();
        }

        public object GameState(Game game)
        {
            return game.GameState;
        }

        public void MakeMove(Game game)
        {
            game.MakeMove();
        }
    }

}

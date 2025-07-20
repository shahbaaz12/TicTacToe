using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Constants;
using TicTacToe.Controllers;
using TicTacToe.Strategies;

namespace TicTacToe.Models
{
    public class Game
    {
        public Board Board { get; set; }
        public List<Player> Players { get; set; }
        public GAME_STATE GameState { get; set; }
        public Player NextToPlay;

        public List<Move> Moves { get; set; }

        public List<WinningStrategy> WinningStrategies { get; set; }

        public void DisplayBoard()
        {
            this.Board.Display();
        }

        public void MakeMove()
        {
            //Get the player making the move
            var curr = this.NextToPlay;
            //Try making the move
            var move = curr.MakeMove(this.Board);
            //Validate the move
            if (Validate(move))
            {
                //Update the grid
                this.Board.grid[move.Cell.X][move.Cell.Y] = move.Cell;
            }
            else
            {
                Console.WriteLine("Invalid Move !!");
                return;
            }
            //Update Move List
            Moves.Add(move);

            //Update the player
            UpdateNextPlayer(curr);

            //Check for winner
            if (IsWinner(move))
            {
                Console.WriteLine("The winner is : " + curr.Name);
                this.GameState = GAME_STATE.WIN; //Update the Game State
            }
            else if (this.Moves.Count() == this.Board.Size * this.Board.Size)
            {
                Console.WriteLine("The game is a draw");
                this.GameState = GAME_STATE.DRAW; //Update the Game State
            }

           
        }

        private void UpdateNextPlayer(Player curr)
        {
            var currentIndex = this.Players.IndexOf(curr);
            var nextIndex = (currentIndex + 1) % this.Players.Count;
            this.NextToPlay = this.Players[nextIndex];
        }


        private bool IsWinner(Move move)
        {
            foreach (var strategy in this.WinningStrategies)
            {
                if (strategy.CheckWinningCondition(this.Board.Size, move))
                    return true;
            }
            return false;
        }

        private bool Validate(Move move)
        {
            var i = move.Cell.X;
            var j = move.Cell.Y;

            if (this.Board.grid[i][j].Symbol.Sym == SYMBOLS.DEFAULT)
                return true;
            return false;

        }

        public class GameBuilder
        {
            private int size;
            private List<Player> players;
            private Player ntp;
            private List<WinningStrategy> strategies;

            private GameBuilder() { }

            public static GameBuilder Create() => new GameBuilder();

            public GameBuilder SetBoardSize(int size)
            {
                this.size = size;
                return this;
            }

            public GameBuilder SetPlayers(List<Player> players)
            {
                this.players = players;
                return this;
            }
            public GameBuilder SetFirstPlayer(Player player)
            {
                this.ntp = player;
                return this;
            }
            public GameBuilder SetWinningStrategies(List<WinningStrategy> strats)
            {
                this.strategies = strats;
                return this;
            }

            public Game Build()
            {
                var game = new Game
                {
                    Board = new Board(size),
                    Players = players,
                    GameState = GAME_STATE.INPROGRESS
                };
                game.NextToPlay = ntp != null ? ntp : players.FirstOrDefault();
                game.WinningStrategies = strategies;
                game.Moves = new List<Move>();
                return game;
            }
        }




    }
}

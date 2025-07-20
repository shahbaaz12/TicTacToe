
using System;
using TicTacToe.Constants;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{
    public abstract class Player
    {
        internal Player(int id, string name, PLAYER_TYPES pt, Symbol sym)
        {
            Id = id;
            Name = name;
            PlayerType = pt;
            symbol = sym;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public PLAYER_TYPES PlayerType { get; set; }
        public Symbol symbol { get; set; }

        public abstract Move MakeMove(Board board);

        

    }
}

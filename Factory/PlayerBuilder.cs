using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Constants;
using TicTacToe.Controllers;
using TicTacToe.Models;

namespace TicTacToe.Factory
{
    public class PlayerBuilder
    {
        private int id;
        private string name;
        private PLAYER_TYPES pt;
        private SYMBOLS sym;
        private DifficultyLevel dff;

        private PlayerBuilder() { }

        public static PlayerBuilder Create()
        {
            return new PlayerBuilder();
        }

        public PlayerBuilder SetId(int id)
        {
            this.id = id;
            return this;
        }

        public PlayerBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public PlayerBuilder SetPlayerType(PLAYER_TYPES pt)
        {
            this.pt = pt;
            return this;
        }
        public PlayerBuilder SetPlayerSymbol(SYMBOLS s)
        {
            this.sym = s;
            return this;
        }

        public PlayerBuilder SetDifficultyIfBot(DifficultyLevel difficulty)
        {
            this.dff = difficulty;
            return this;
        }

        public Player Build()
        {
            Player createdPlayer;
            var symbol = new Symbol(sym);
            if (pt == PLAYER_TYPES.HUMAN)
            {
                createdPlayer = new HumanPlayer(id, name, pt, symbol);
            }
            else
            {
                createdPlayer = new BotPlayer(id, name, pt, symbol, dff);
            }
            return createdPlayer;
        }
    }
}

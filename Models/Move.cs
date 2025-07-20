using TicTacToe.Models;

namespace TicTacToe.Controllers
{
    public class Move
    {
        public Cell Cell { get; set; }
        public Player Player { get; set; }

        public Move(Cell c, Player p)
        {
            Cell = c;
            Player = p;
        }
    }
}
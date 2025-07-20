using System;
using TicTacToe.Constants;
using TicTacToe.Controllers;
using TicTacToe.Models;

namespace TicTacToe.Models
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(int id, string name, PLAYER_TYPES pt, Symbol sym) : base(id, name, pt, sym)
        {
        }

        public override Move MakeMove(Board board)
        {
            Console.WriteLine($"Player {Name}, make your move:");

            Console.Write("Enter row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter column: ");
            int col = Convert.ToInt32(Console.ReadLine());

            var cell = new Cell(row, col, this.symbol);
            var move = new Move(cell, this);

            return move;
        }
    }
}
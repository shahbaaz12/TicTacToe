
using System;
using TicTacToe.Controllers;
using TicTacToe.Models;

namespace TicTacToe.Strategies
{
    internal class EasyPlayingStrategy : PlayingStragegy
    {
        public Move MakeMove(Board board)
        {
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    if (board.grid[i][j].Symbol.Sym == SYMBOLS.DEFAULT)
                    {
                        return new Move(new Cell(i, j), null); // Early return
                    }
                }
            }

            throw new InvalidOperationException("No valid moves available on the board.");
        }

    }
}
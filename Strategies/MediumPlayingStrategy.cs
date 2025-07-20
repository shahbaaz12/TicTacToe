using System.Collections.Generic;
using System;
using TicTacToe.Controllers;
using TicTacToe.Models;
using TicTacToe.Strategies;
using System.Linq;

internal class MediumPlayingStrategy : PlayingStragegy
{
    private static readonly Random random = new Random(); //   Reuse this

    public Move MakeMove(Board board)
    {
        var emptyCells = new List<Cell>();

        for (int i = 0; i < board.Size; i++)
        {
            for (int j = 0; j < board.Size; j++)
            {
                if (board.grid[i][j].Symbol.Sym == SYMBOLS.DEFAULT)
                {
                    emptyCells.Add(new Cell(i, j));
                }
            }
        }

        if (!emptyCells.Any())
        {
            throw new InvalidOperationException("No valid moves available on the board.");
        }

        int index = random.Next(emptyCells.Count); //  Use the static one

        return new Move(emptyCells[index], null);
    }
}

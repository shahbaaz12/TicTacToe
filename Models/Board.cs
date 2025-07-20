using System;
using System.Collections.Generic;

namespace TicTacToe.Models
{
    public class Board
    {
        public int Size { get; set; }
        public List<List<Cell>>  grid { get; set; }

        public Board(int size)
        {
            this.Size = size;
            this.grid = new List<List<Cell>>();
            for (int i = 0; i < Size; i++)
            {
                grid.Add(new List<Cell>());
                for(int j = 0; j < Size; j++)
                {
                    grid[i].Add(new Cell(i, j));
                }
            }
        }

        public void Display()
        {
            Console.WriteLine();
            for (int i = 0;i < Size;i++)
            {
                for(int j = 0;j < Size;j++)
                {
                    Console.Write($"| {grid[i][j].Symbol.Sym.ToChar()} |");
                }
                Console.WriteLine();
            }
        }
    }
}
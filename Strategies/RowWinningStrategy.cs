using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Constants;
using TicTacToe.Controllers;

namespace TicTacToe.Strategies
{
    public class RowWinningStrategy : WinningStrategy
    {
        Dictionary<int, Dictionary<SYMBOLS, int>> rows;
        public RowWinningStrategy()
        {
            rows = new Dictionary<int, Dictionary<SYMBOLS, int>>();
        }
        public bool CheckWinningCondition(int size, Move move)
        {

            var x = move.Cell.X;
            var y = move.Cell.Y;
            var sym = move.Cell.Symbol.Sym;

             
            if (!rows.ContainsKey(x))
            {
                rows.Add(x, new Dictionary<SYMBOLS, int>());
            }
            var row = rows[x];

            if (!row.ContainsKey(sym))
            {
                row.Add(sym, 1);
            }
            else
            {
                row[sym]++;
            }

            return row[sym] == size;
        }
    }
}

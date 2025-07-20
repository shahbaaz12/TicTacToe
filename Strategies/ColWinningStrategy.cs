using System.Collections.Generic;
using TicTacToe.Controllers;

namespace TicTacToe.Strategies
{
    public class ColWinningStrategy : WinningStrategy
    {
        Dictionary<int, Dictionary<SYMBOLS, int>> cols;
        public ColWinningStrategy()
        {
            cols = new Dictionary<int, Dictionary<SYMBOLS, int>>();
        }
        public bool CheckWinningCondition(int size, Move move)
        {

            var x = move.Cell.X;
            var y = move.Cell.Y;
            var sym = move.Cell.Symbol.Sym;

             
            if (!cols.ContainsKey(y))
            {
                cols.Add(y, new Dictionary<SYMBOLS, int>());
            }
            var col = cols[y];

            if (!col.ContainsKey(sym))
            {
                col.Add(sym, 1);
            }
            else
            {
                col[sym]++;
            }

            return col[sym] == size;
        }
    }
}

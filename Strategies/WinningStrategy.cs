using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Controllers;

namespace TicTacToe.Strategies
{
    public interface WinningStrategy
    {
          bool CheckWinningCondition(int size, Move move);
    }
}

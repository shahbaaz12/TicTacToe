using TicTacToe.Controllers;
using TicTacToe.Models;

namespace TicTacToe.Strategies
{
    public interface PlayingStragegy
    {
        Move MakeMove(Board board);
    }
}
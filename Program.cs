using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Constants;
using TicTacToe.Controllers;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gc = new GameController();
            var game = gc.CreateGame();

             

            gc.DisplayBoard(game);

            while(gc.GameState(game).Equals(GAME_STATE.INPROGRESS))
            {
                gc.MakeMove(game);
                gc.DisplayBoard(game);

               // gc.CheckForUndo(game);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}

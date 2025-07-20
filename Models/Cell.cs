namespace TicTacToe.Models
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Symbol Symbol { get; set; }

        public Cell(int x, int y )
        {
            this.X = x;
            this.Y = y;
            this.Symbol = new Symbol();
        }
        public Cell(int x, int y, Symbol s)
        {
            this.X = x;
            this.Y = y;
            this.Symbol = s;
        }

    }
}
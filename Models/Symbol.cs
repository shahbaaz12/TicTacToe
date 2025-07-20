using TicTacToe.Constants;

namespace TicTacToe.Models
{
    public class Symbol
    {
        public SYMBOLS Sym  { get; set; }
       // public string Color { get; set; }

        public Symbol()
        {
            Sym = SYMBOLS.DEFAULT;
           // Color = 
        }
        public Symbol(SYMBOLS sym)
        {
            Sym = sym;
        }
    }
}
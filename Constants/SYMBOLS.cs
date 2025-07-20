using System;

public enum SYMBOLS
{
    DEFAULT,
    CROSS,
    ZERO
}

public static class SymbolExtensions
{
    public static char ToChar(this SYMBOLS symbol)
    {
        if (symbol == SYMBOLS.CROSS) return 'X';
        if (symbol == SYMBOLS.ZERO) return '0';
        return '-';
    }
}

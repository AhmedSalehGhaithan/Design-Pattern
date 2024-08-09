using System;

namespace FlyweightDesignPattern.TextEditor
{
    // The ConcreteFlyweight class with external states.
    public class Character
    {
        private readonly CharacterStyle _style;
        public char Symbol { get; }
        public int Position { get; }
        public Character(char symbol, int position, CharacterStyle style)
        {
            Symbol = symbol;
            Position = position;
            _style = style;
        }
        public void Display()
        {
            Console.Write(Symbol);
            _style.DisplayStyle();
        }
    }
}

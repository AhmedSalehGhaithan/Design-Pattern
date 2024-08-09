using System.Collections.Generic;
using System;

namespace FlyweightDesignPattern.TextEditor
{
    // Client
    class TextEditors
    {
        private readonly List<Character> _document = new List<Character>();
        private readonly StyleFactory _styleFactory = new StyleFactory();
        public void InsertCharacter(char symbol, int position, string font, int size, bool isBold, bool isItalic)
        {
            var style = _styleFactory.GetStyle(font, size, isBold, isItalic);
            _document.Add(new Character(symbol, position, style));
        }
        public void DisplayDocument()
        {
            foreach (var character in _document)
            {
                character.Display();
                Console.WriteLine("-----");
            }
        }
    }
}

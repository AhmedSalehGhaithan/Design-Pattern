using System;

namespace FlyweightDesignPattern.TextEditor
{
    // Flyweight: CharacterStyle holds the shared properties
    public class CharacterStyle
    {
        public string Font { get; }
        public int Size { get; }
        public bool IsBold { get; }
        public bool IsItalic { get; }
        public CharacterStyle(string font, int size, bool isBold, bool isItalic)
        {
            Font = font;
            Size = size;
            IsBold = isBold;
            IsItalic = isItalic;
        }
        public void DisplayStyle()
        {
            Console.WriteLine($"Font: {Font}, Size: {Size}, Bold: {IsBold}, Italic: {IsItalic}");
        }
    }
}

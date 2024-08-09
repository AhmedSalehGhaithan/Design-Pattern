using System.Collections.Generic;

namespace FlyweightDesignPattern.TextEditor
{
    // Flyweight Factory
    public class StyleFactory
    {
        private readonly Dictionary<string, CharacterStyle> _styles = new Dictionary<string, CharacterStyle>();
        public CharacterStyle GetStyle(string font, int size, bool isBold, bool isItalic)
        {
            var key = $"{font}_{size}_{isBold}_{isItalic}";
            if (!_styles.ContainsKey(key))
            {
                _styles[key] = new CharacterStyle(font, size, isBold, isItalic);
            }
            return _styles[key];
        }
    }
}

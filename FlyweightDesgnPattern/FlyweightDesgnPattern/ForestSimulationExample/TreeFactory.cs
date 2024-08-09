using System.Collections.Generic;

namespace FlyweightDesignPattern.ForestSimulationExample
{
    public class TreeFactory
    {
        private static readonly Dictionary<string,TreeType> _treeType = new Dictionary<string,TreeType>();

        public static TreeType GetTreeType(string name,string color,string texture)
        {
            var key = $"{name}_{color}_{texture}";
            if (!_treeType.ContainsKey(key))
            {
                var type = new TreeType(name, color, texture);
                _treeType.Add(key, type);
            }

            return _treeType[key];
        }
    }
}

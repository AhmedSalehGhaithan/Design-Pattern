using System;
using System.Collections.Generic;

namespace CompositeDesignPattern.filesystem
{
    public class Directory : FileSystemComponent
    {
        private string _name;
        private List<FileSystemComponent> _components = new List<FileSystemComponent>();
        public Directory(string name) => _name = name;

        public void Add(FileSystemComponent component)
        {
            _components.Add(component);
        }
        public void Remove(FileSystemComponent component)
        {
            _components.Remove(component);
        }

        public override void Display(string indent)
        {
            Console.WriteLine($"{indent}+ {_name}");
            foreach (var component in _components)
            {
                component.Display(indent + "  ");
            }
        }
    }
}

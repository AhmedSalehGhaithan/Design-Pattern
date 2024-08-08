using System;

namespace CompositeDesignPattern.filesystem
{
    public class File : FileSystemComponent
    {
        private string _name;
        public File(string name) => _name = name;
        public override void Display(string indent)
        {
            Console.WriteLine($"{indent}- {_name}");
        }
    }
}

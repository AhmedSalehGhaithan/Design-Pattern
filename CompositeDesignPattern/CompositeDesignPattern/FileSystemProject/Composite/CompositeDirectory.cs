using System.Collections.Generic;
using System.Linq;
namespace CompositeDesignPattern.FileSystemProject.Composite
{
    public class CompositeDirectory : FileSystemItem
    {
        private List<FileSystemItem> _Childrens = new List<FileSystemItem>();
        public CompositeDirectory(string name) : base(name) {}

        public void AddComponent(FileSystemItem NewNode) => _Childrens.Add(NewNode);

        public void RemoveComponent(FileSystemItem RemoveNode) => _Childrens.Remove(RemoveNode);    

        public override decimal GetSizeInKB()
        {
            // Summarizing the size of children
            return this._Childrens.Sum(x => x.GetSizeInKB());
        }
    }
}

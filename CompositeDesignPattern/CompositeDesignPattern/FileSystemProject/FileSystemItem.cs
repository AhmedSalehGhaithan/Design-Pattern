namespace CompositeDesignPattern.FileSystemProject
{
    public abstract class FileSystemItem
    {
        public string _name { get; }
        public FileSystemItem(string name) => _name = name;
        public abstract decimal GetSizeInKB();
    }
}

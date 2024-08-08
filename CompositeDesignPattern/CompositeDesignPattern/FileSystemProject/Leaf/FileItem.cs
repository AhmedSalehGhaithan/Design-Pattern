namespace CompositeDesignPattern.FileSystemProject.Leaf
{
    public class FileItem : FileSystemItem
    {
        public long FileBytes { get; }
        public FileItem(string name, long fileBytes) : base(name) => this.FileBytes = fileBytes;

        public override decimal GetSizeInKB()
        {
            return decimal.Divide(FileBytes, 1024);
        }
    }
}

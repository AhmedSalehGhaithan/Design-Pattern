namespace FlyweightDesignPattern.ForestSimulationExample
{
    public class Tree
    {
        private readonly TreeType _treeType;
        private readonly int _x;
        private readonly int _y;

        public Tree(int x,int y, TreeType treeType)
        {
            _treeType = treeType;
            _x = x;
            _y = y;
        }

        public void Draw()
        {
            _treeType.Draw(_x, _y); 
        }
    }
}

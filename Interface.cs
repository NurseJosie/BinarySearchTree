namespace BinarySearchTree
{
    public interface BST_G<T> where T : IComparable<T>
    {
        public void Insert(T value);

        public bool Exists(T value);

        public int Count();
    }
}
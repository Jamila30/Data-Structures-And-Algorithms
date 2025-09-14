namespace DataStructuresAndAlgorithms.DataStructures.NonLinear.BinarySearchTrees
{
    public class BinarySearchTreeLinkedListNode<T> where T : IComparable<T>
    {
        public T? Element;
        public BinarySearchTreeLinkedListNode<T>? LeftChild ;
        public BinarySearchTreeLinkedListNode<T>? RightChild ;
        public BinarySearchTreeLinkedListNode(T item)
        {
            Element = item;
            LeftChild = null;
            RightChild = null;
        }

    }
}

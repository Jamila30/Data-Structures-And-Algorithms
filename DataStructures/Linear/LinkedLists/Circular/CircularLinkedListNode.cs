namespace DataStructuresAndAlgorithms.DataStructures.Linear.LinkedLists.Circular
{
    public class CircularLinkedListNode<T>
    {
        public T? Element;
        public CircularLinkedListNode<T>? Next {  get;  set; }

        public CircularLinkedListNode()
        {}

        public CircularLinkedListNode(T element)
        {
            Element = element;
        }
    }
}

namespace DataStructuresAndAlgorithms.DataStructures.Linear.Deques.LinkedListBaseDeque
{
    public class DequeLinkedListNode<T>
    {
        internal T? Element;
        internal DequeLinkedListNode<T>? Next { get; set; }

        public DequeLinkedListNode(T? element)
        {
            Element = element;
            Next = null;
        }
        public DequeLinkedListNode(T? element, DequeLinkedListNode<T>? next)
        {
            Element = element;
            Next = next;
        }
    }
}

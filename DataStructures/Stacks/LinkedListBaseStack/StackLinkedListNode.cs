namespace DataStructuresAndAlgorithms.DataStructures.Stacks.LinkedListBaseStack
{
    public class StackLinkedListNode<T>
    {
        internal T? Element;
        internal StackLinkedListNode<T>? Next { get; set; }

        public StackLinkedListNode(T? element)
        {
            Element= element;
            Next = null;
        }
        public StackLinkedListNode(T? element, StackLinkedListNode<T>? next)
        {
            Element = element;
            Next = next;
        }

    }
}

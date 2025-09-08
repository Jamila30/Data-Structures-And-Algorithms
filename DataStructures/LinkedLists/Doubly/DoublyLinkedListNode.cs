namespace DataStructuresAndAlgorithms.DataStructures.LinkedLists.Doubly
{
    public class DoublyLinkedListNode<T>
    {
        public T Element { get; set; }
        public DoublyLinkedListNode<T>? Next { get; set; }
        public DoublyLinkedListNode<T>? Prev { get; set; }

        public DoublyLinkedListNode(T element, DoublyLinkedListNode<T>? next, DoublyLinkedListNode<T>? prev)
        {
            Element = element;
            Next = next;
            Prev = prev;
        }
    }
}

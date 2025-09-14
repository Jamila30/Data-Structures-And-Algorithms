namespace DataStructuresAndAlgorithms.DataStructures.Linear.Queues.LinkedListBaseQueue
{
    public class QueueLinkedListNode<T>
    {
        internal T? Element;
        internal QueueLinkedListNode<T>? Next { get; set; }

        public QueueLinkedListNode(T? element)
        {
            Element = element;
            Next = null;
        }
        public QueueLinkedListNode(T? element, QueueLinkedListNode<T>? next)
        {
            Element = element;
            Next = next;
        }
    }
}

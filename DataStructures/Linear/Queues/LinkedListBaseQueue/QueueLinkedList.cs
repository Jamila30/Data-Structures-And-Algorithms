using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures.Linear.Queues.LinkedListBaseQueue
{
    public class QueueLinkedList<T> :IEnumerable<T>,IEnumerable
    {
        public int _size = 0;
        public QueueLinkedListNode<T>? _headNode;
        public QueueLinkedListNode<T>? _tailNode;
        public QueueLinkedList()
        {
            _headNode = null;
            _tailNode = null;
        }

        public bool IsEmpty => _size == 0;

        public void Enqueue(T item)
        {
            QueueLinkedListNode<T> newNode = new QueueLinkedListNode<T>(item);
            if (IsEmpty)
            {
                _headNode = newNode;
                _tailNode = newNode;
            }
            else
            {
                QueueLinkedListNode<T>? currentNode = _headNode;
                _tailNode.Next = newNode;
                _tailNode = newNode;

            }
            _size++;
        }

        public T Dequeue()
        {

            if (IsEmpty)
            {
                throw new InvalidOperationException("Empty");
            }
            else
            {
                T lastDeletedValue = _headNode.Element;
               _headNode = _headNode.Next;
               _size--;

                if(IsEmpty)
                {
                    _tailNode = null;
                }
                return lastDeletedValue;
            }
        }

        public  T First()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Empty");
            }
            else
            {
                T lastDeletedValue = _headNode.Element;
                return lastDeletedValue;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            QueueLinkedListNode<T> current = _headNode;
            while (current != null)
            {
                yield return current.Element!;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}

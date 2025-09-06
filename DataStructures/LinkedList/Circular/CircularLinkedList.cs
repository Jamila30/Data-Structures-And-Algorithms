using DataStructuresAndAlgorithms.DataStructures.LinkedList.Linear;
using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList.Circular
{
    public class CircularLinkedList<T> :  IEnumerable<T>, IEnumerable
    {
        private int _size;

        public CircularLinkedListNode<T>? _headNode;
        public CircularLinkedListNode<T>? _tailNode;

        public CircularLinkedList()
        {
            _size = 0;
            _headNode = null;
            _tailNode = null;
        }

        public bool IsEmpty() => _size == 0;

        public void AddLast(T item)
        {
            CircularLinkedListNode<T> newNode = new CircularLinkedListNode<T>(item);
            if (IsEmpty())
            {
                 newNode.Next = newNode;
                _headNode= newNode;            
            }
            else
            {
                newNode.Next = _tailNode.Next;
                _tailNode.Next = newNode;
            }

            _tailNode= newNode;
            _size++;
        }

        public void AddFirst(T item)
        {
            CircularLinkedListNode<T> newNode = new CircularLinkedListNode<T>(item);
            if (IsEmpty())
            {
                 newNode.Next = newNode;
                _tailNode= newNode;            
            }
            else
            {
                newNode.Next = _headNode;
                _tailNode.Next = newNode;
            }

            _headNode= newNode;
            _size++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            CircularLinkedListNode<T> current = _headNode ;         
            int i = 0;
            while (i < _size)
            {
                yield return current.Element!;
                current = current.Next;
                i++;
            }
          
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

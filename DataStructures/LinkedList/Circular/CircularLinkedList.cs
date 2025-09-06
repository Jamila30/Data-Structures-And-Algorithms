using DataStructuresAndAlgorithms.DataStructures.LinkedList.Linear;
using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList.Circular
{
    public class CircularLinkedList<T> : IEnumerable<T>, IEnumerable
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
                _headNode = newNode;
            }
            else
            {
                newNode.Next = _tailNode.Next;
                _tailNode.Next = newNode;
            }

            _tailNode = newNode;
            _size++;
        }

        public void AddFirst(T item)
        {
            CircularLinkedListNode<T> newNode = new CircularLinkedListNode<T>(item);
            if (IsEmpty())
            {
                newNode.Next = newNode;
                _tailNode = newNode;
            }
            else
            {
                newNode.Next = _headNode;
                _tailNode.Next = newNode;
            }

            _headNode = newNode;
            _size++;
        }

        public void AddToAny(int position, T item)
        {
            if (position <= 0 || position >= _size)
            {
                throw new Exception("Invalid Position");
            }
            CircularLinkedListNode<T> newNode = new CircularLinkedListNode<T>(item);
            CircularLinkedListNode<T> currentNode = _headNode;
            int i = 1;
            while (i < position - 1)
            {
                currentNode = currentNode.Next;
                i++;
            }
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
            _size++;
        }

        public void DeleteFirst()
        {
            if (IsEmpty()) { return; }
            else
            {
                _tailNode.Next = _headNode.Next;
                _headNode = _headNode.Next;
                _size--;
            }

            if (IsEmpty())
            {
                _headNode = null;
                _tailNode = null;
            }
        }

        public void DeleteLast()
        {
            if (IsEmpty()) { return; }
            else
            {
                int i = 1;
                CircularLinkedListNode<T> currentNode =_headNode;
                while (i < _size-1) {
                    currentNode = currentNode.Next;
                    i++;
                }
                currentNode.Next = _tailNode.Next;
                _tailNode = currentNode;
                _size--;
            }

            if (IsEmpty())
            {
                _headNode = null;
                _tailNode = null;
            }
        }

        public void DeleteAtPosition(int position)
        {
            if (position <= 0 || position >= _size)
            {
                throw new Exception("Invalid Position");
            }

            if (IsEmpty()) { return; }
            else
            {
                int i = 1;
                CircularLinkedListNode<T> currentNode =_headNode;
                while (i < position-1) {
                    currentNode = currentNode.Next;
                    i++;
                }
                currentNode.Next = currentNode.Next.Next;
                _size--;
            }

            if (IsEmpty())
            {
                _headNode = null;
                _tailNode = null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            CircularLinkedListNode<T> current = _headNode;
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

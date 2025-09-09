using DataStructuresAndAlgorithms.DataStructures.LinkedLists.Linear;
using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures.Deques.LinkedListBaseDeque
{
    public class DequeLinkedList<T> : IEnumerable<T>, IEnumerable
    {
        private int _size;

        public DequeLinkedListNode<T>? _headNode;
        public DequeLinkedListNode<T>? _tailNode;

        public DequeLinkedList()
        {
            _size = 0;
            _headNode = null;
            _tailNode = null;
        }

        public bool IsEmpty() => _size == 0;
        public void AddLast(T element)
        {
            DequeLinkedListNode<T> newNode = new DequeLinkedListNode<T>(element);
            if (IsEmpty())
            {
                _headNode = newNode;
            }
            else
            {
                _tailNode!.Next = newNode;
            };
            _tailNode = newNode;
            _size++;
        }
        public void AddFirst(T element)
        {
            DequeLinkedListNode<T> newNode = new DequeLinkedListNode<T>(element);
            if (IsEmpty())
            {
                _headNode = newNode;
                _tailNode = newNode;
            }
            else
            {
                newNode.Next = _headNode;
                _headNode = newNode;
            };
            _size++;
        }
      
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                return;
            }

            DequeLinkedListNode<T> tempHeadNodeNext = _headNode.Next;
            _headNode = tempHeadNodeNext;

            if (IsEmpty())
            {
                _tailNode = null;
            }
            _size--;
        }


        public void RemoveLast()
        {
            if (IsEmpty())
            {
                return;
            }

            int i = 1;
            DequeLinkedListNode<T> currentNode = _headNode;
            while (i < _size - 1)
            {
                currentNode = currentNode.Next;
                i++;
            }
            currentNode.Next = null;
            _tailNode = currentNode;
            _size--;


            if (IsEmpty())
            {
                _headNode = null;
                _tailNode = null;
            }

        }
        public T First()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Deque is empty");
            }
            else
            {
                return _headNode.Element;
            }
        }
        
        public T Last()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Deque is empty");
            }
            else
            {
                return _tailNode.Element;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            DequeLinkedListNode<T> current = _headNode;
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

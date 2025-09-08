using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedLists.Doubly
{
    public class DoublyLinkedList<T> : IEnumerable<T>, IEnumerable
    {
        private int _size;

        public DoublyLinkedListNode<T>? _headNode;
        public DoublyLinkedListNode<T>? _tailNode;
        public DoublyLinkedList()
        {
            _size = 0;
            _headNode = null;
            _tailNode = null;
        }

        public bool IsEmpty() => _size == 0;
        public void AddLast(T item)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(item, null, null);
            if (IsEmpty())
            {
                _headNode = newNode;
                _tailNode = newNode;
            }
            else
            {
                newNode.Prev = _tailNode;
                _tailNode.Next = newNode;
                _tailNode = newNode;

            }
            _size++;
        }

        public void AddFirst(T item)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(item, null, null);
            if (IsEmpty())
            {
                _headNode = newNode;
                _tailNode = newNode;
            }
            else
            {
                newNode.Next = _headNode;
                _headNode.Prev = newNode;
                _headNode = newNode;

            }
            _size++;
        }

        public void AddToPosition(int position, T item)
        {
            if (position <= 0 || position >= _size)
            {
                throw new Exception("Invalid Position");
            }

            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(item, null, null);
            DoublyLinkedListNode<T> currentNode = _headNode;

            int i = 1;
            while (i < position - 1)
            {
                currentNode = currentNode.Next;
                i++;
            }
            newNode.Prev = currentNode;
            newNode.Next=currentNode.Next;
            currentNode.Next=newNode;
            newNode.Next.Prev=newNode;


            _size++;

        }

        public void DeleteFirst()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                _headNode = _headNode.Next;
            }
            _size--;

            if (IsEmpty())
            {
                _tailNode = null;
            }
            else 
            {
                _headNode.Prev = null;
            }
        }

        public void DeleteLast()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                _tailNode= _tailNode.Prev;
            }
            _size--;

            if (IsEmpty())
            {
                _headNode = null;
            }
            else 
            {
                _tailNode.Next = null;
            }
        }

        public void DeleteAtPosition(int position)
        {
            if (position <= 0 || position >= _size)
            {
                throw new Exception("Invalid Position");
            }

            DoublyLinkedListNode<T> currentNode = _headNode;

            int i = 1;
            while (i < position - 1)
            {
                currentNode = currentNode.Next;
                i++;
            }
            currentNode.Next.Next.Prev=currentNode;
            currentNode.Next =currentNode.Next.Next;

            _size--;
        }
        public IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedListNode<T> current = _headNode;
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

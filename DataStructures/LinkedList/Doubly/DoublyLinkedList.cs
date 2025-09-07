using DataStructuresAndAlgorithms.DataStructures.LinkedList.Circular;
using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList.Doubly
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
